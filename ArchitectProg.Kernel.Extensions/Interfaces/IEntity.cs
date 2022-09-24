namespace ArchitectProg.Kernel.Extensions.Interfaces;

public interface IEntity<TId> : IEquatable<IEntity<TId>> where TId : struct
{
    TId Id { get; }
}