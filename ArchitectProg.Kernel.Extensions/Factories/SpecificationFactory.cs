using ArchitectProg.Kernel.Extensions.Entities;
using ArchitectProg.Kernel.Extensions.Factories.Interfaces;
using ArchitectProg.Kernel.Extensions.Specifications;
using ArchitectProg.Kernel.Extensions.Specifications.Interfaces;

namespace ArchitectProg.Kernel.Extensions.Factories;

public class SpecificationFactory : ISpecificationFactory
{
    public ISpecification<T> AllSpecification<T>()
    {
        var result = new AllSpecification<T>();
        return result;
    }

    public ISpecification<TEntity> ByIdSpecification<TEntity, TId>(TId id)
        where TEntity : Entity<TId>
        where TId : struct
    {
        var result = new ByIdSpecification<TEntity, TId>(id);
        return result;
    }
}