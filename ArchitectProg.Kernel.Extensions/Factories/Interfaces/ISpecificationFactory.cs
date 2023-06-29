using ArchitectProg.Kernel.Extensions.Entities;
using ArchitectProg.Kernel.Extensions.Specifications.Interfaces;

namespace ArchitectProg.Kernel.Extensions.Factories.Interfaces;

public interface ISpecificationFactory
{
    ISpecification<T> AllSpecification<T>();
    ISpecification<TEntity> ByIdSpecification<TEntity, TId>(TId id)
        where TEntity : Entity<TId>
        where TId : struct;
}