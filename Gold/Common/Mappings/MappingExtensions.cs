using Gold.Common.Models;
using Microsoft.EntityFrameworkCore;

namespace Gold.Common.Mappings
{
    public static class MappingExtensions
    {
        public static Task<PaginatedList<TDestination>> PaginatedListAsync<TDestination>(this IQueryable<TDestination> queryable, int pageNumber, int pageSize) where TDestination : class
            => PaginatedList<TDestination>.CreateAsync(queryable.AsNoTracking(), pageNumber, pageSize);

        public static PaginatedList<TDestination> PaginatedEnumerable<TDestination>(this IEnumerable<TDestination> queryable, int pageNumber, int pageSize) where TDestination : class
            => PaginatedList<TDestination>.Create(queryable.ToList(), pageNumber, pageSize);
    }
}
