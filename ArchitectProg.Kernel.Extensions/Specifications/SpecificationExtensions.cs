using ArchitectProg.Kernel.Extensions.Interfaces;

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
            var result = specification.AddPredicates(entities);
            result = specification.AddSorting(result);
            result = specification.AddEagerFetching(result);

            return result;
        }
    }
}