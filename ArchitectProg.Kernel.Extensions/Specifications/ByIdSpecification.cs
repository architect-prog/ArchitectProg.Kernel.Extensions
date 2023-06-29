using ArchitectProg.Kernel.Extensions.Entities;

namespace ArchitectProg.Kernel.Extensions.Specifications;

public class ByIdSpecification<TEntity, TId> : Specification<TEntity>
    where TEntity : Entity<TId>
    where TId : struct
{
    private readonly TId id;

    public ByIdSpecification(TId id)
    {
        this.id = id;
    }

    public override IQueryable<TEntity> AddPredicates(IQueryable<TEntity> query)
    {
        var result = query.Where(x => x.Id.Equals(id));
        return result;
    }
}