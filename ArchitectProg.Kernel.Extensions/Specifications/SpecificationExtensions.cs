using ArchitectProg.Kernel.Extensions.Specifications.Interfaces;

namespace ArchitectProg.Kernel.Extensions.Specifications
{
    public static class SpecificationExtensions
    {
        public static ISpecification<T> AsSpecification<T>(this ISpecification<T> source)
        {
            return source;
        }

        public static IQueryable<T> ApplySpecification<T>(this IQueryable<T> entities, ISpecification<T> specification)
        {
            var result = specification.AddEagerFetching(entities);
            result = specification.AddPredicates(result);
            result = specification.AddSorting(result);

            return result;
        }
    }
}