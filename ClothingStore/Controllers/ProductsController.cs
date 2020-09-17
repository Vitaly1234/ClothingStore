using AutoMapper;
using ClothingStore.ActionFilters;
using Contracts;
using Entities.DataTransferObjects;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClothingStore.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ILoggerManager _logger;
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;

        public ProductsController(
            ILoggerManager logger,
            IRepositoryManager repository,
            IMapper mapper)
        {
            _logger = logger;
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts([FromQuery] ProductParameters productParameters)
        {
            var products = await _repository.Product.GetAllProductsAsync(productParameters, trackChanges: false);

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(products.MetaData));

            var productsResult = _mapper.Map<IEnumerable<ProductDto>>(products);
            return Ok(productsResult);
        }

        [HttpGet("{id}", Name = "ProductById")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await _repository.Product.GetProductByIdAsync(id, trackChanges: false);
            if (product == null)
            {
                _logger.LogError($"Product with id: {id} not found in DB.");
                return NotFound();
            }
            else
            {
                var productResult = _mapper.Map<ProductDto>(product);
                return Ok(productResult);
            }
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateProduct([FromBody]ProductForCreationDto product)
        {
            var productEntity = _mapper.Map<Product>(product);
            _repository.Product.CreateProduct(productEntity);
            await _repository.SaveAsync();
            var createdProduct = _mapper.Map<ProductDto>(productEntity);
            
            return CreatedAtRoute("ProductById", new { id = createdProduct.Id }, createdProduct);
        }

        [HttpPut("{id}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [ServiceFilter(typeof(ValidateProductExistsAttribute))]
        public async Task<IActionResult> UpdateProduct([FromBody]ProductForUpdateDto product)
        {
            var productEntity = HttpContext.Items["product"] as Product;

            _mapper.Map(product, productEntity);
            _repository.Product.UpdateProduct(productEntity);
            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        [ServiceFilter(typeof(ValidateProductExistsAttribute))]
        public async Task<IActionResult> DeleteProduct()
        {
            var product = HttpContext.Items["product"] as Product;

            _repository.Product.DeleteProduct(product);
            await _repository.SaveAsync();

            return NoContent();
        }
    }
}