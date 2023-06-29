namespace ArchitectProg.Kernel.Extensions.Entities.Interfaces;

public interface IEntity<TId> : IEquatable<IEntity<TId>> where TId : struct
{
    TId Id { get; }
}