using ArchitectProg.Kernel.Extensions.Interfaces;

namespace ArchitectProg.Kernel.Extensions;

public static class QueryableExtensions
{
    public static IQueryable<T> ApplySpecification<T>(this IQueryable<T> entities, ISpecification<T> specification)
    {
        var result = specification.AddPredicates(entities);
        result = specification.AddSorting(result);
        result = specification.AddEagerFetching(result);

        return result;
    }
}