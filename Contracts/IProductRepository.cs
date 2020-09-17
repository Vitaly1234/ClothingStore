using Entities.Models;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IProductRepository
    {
        Task<PagedList<Product>> GetAllProductsAsync(ProductParameters productParameters, bool trackChanges);
        Task<Product> GetProductByIdAsync(int productId, bool trackChanges);
        void CreateProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
    }
}