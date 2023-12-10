using ArchitectProg.Kernel.Extensions.Entities;

namespace ArchitectProg.Kernel.Extensions.Specifications;

public class ByIdSpecification<TEntity, TId>(TId id) : Specification<TEntity>
    where TEntity : Entity<TId>
    where TId : struct
{
    public override IQueryable<TEntity> AddPredicates(IQueryable<TEntity> query)
    {
        var result = query.Where(x => x.Id.Equals(id));
        return result;
    }
}