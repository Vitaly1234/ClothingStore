using Contracts;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Extensions;
using System.Threading.Tasks;

namespace Repository
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public async Task<PagedList<Product>> GetAllProductsAsync(ProductParameters productParameters, bool trackChanges)
        {
            var products = FindAll(trackChanges)
                .Search(productParameters.SearchTerm)
                .Sort(productParameters.OrderBy);

            return await PagedList<Product>.ToPagedListAsync(
                products,
                productParameters.PageNumber,
                productParameters.PageSize);
        }

        public async Task<Product> GetProductByIdAsync(int productId, bool trackChanges) =>
            await FindByCondition(p => p.Id == productId, trackChanges)
            .FirstOrDefaultAsync();

        public void CreateProduct(Product product) => Create(product);
        public void UpdateProduct(Product product) => Update(product);
        public void DeleteProduct(Product product) => Delete(product);
    }
}