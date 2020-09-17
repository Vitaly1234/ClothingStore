using Entities.Models;
using Repository.Extensions.Utility;
using System.Linq;
using System.Linq.Dynamic.Core;

namespace Repository.Extensions
{
    public static class RepositoryProductExtensions
    {
        public static IQueryable<Product> Sort(this IQueryable<Product> products, string orderByQueryString)
        {
            if (string.IsNullOrWhiteSpace(orderByQueryString))
            {
                return products.OrderBy(e => e.Id);
            }

            var orderQuery = OrderQueryBuilder.CreateOrderQuery<Product>(orderByQueryString);

            return string.IsNullOrWhiteSpace(orderQuery) ?
                products.OrderBy(e => e.Id) : 
                products.OrderBy(orderQuery);
        }
    }
}