using ArchitectProg.Kernel.Extensions.Abstractions;
using ArchitectProg.Kernel.Extensions.Interfaces;

namespace ArchitectProg.Kernel.Extensions.Specifications;

public static class SpecificationFactory
{
    public static ISpecification<T> AllSpecification<T>()
    {
        var result = new AllSpecification<T>();
        return result;
    }

    public static ISpecification<TEntity> ByIdSpecification<TEntity, TId>(TId id)
        where TEntity : Entity<TId>
        where TId : struct
    {
        var result = new ByIdSpecification<TEntity, TId>(id);
        return result;
    }
}