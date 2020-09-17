using System.Linq;
using System.Linq.Dynamic.Core;
using System.Reflection;
using System.Text;

namespace Repository.Extensions
{
    public static class RepositoryExtensions
    {
        public static IQueryable<T> Search<T>(this IQueryable<T> items, string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return items;
            }

            var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var whereQueryBuilder = new StringBuilder();

            foreach (var property in properties)
            {
                whereQueryBuilder.Append($"string(object({property.Name})).ToLower().Contains(@0) or ");
            }

            var whereQuery = whereQueryBuilder.ToString().TrimEnd('o', 'r', ' ');
            var lowerCaseSearchTerm = searchTerm.Trim().ToLower();

            return items.Where(whereQuery, lowerCaseSearchTerm);
        }
    }
}