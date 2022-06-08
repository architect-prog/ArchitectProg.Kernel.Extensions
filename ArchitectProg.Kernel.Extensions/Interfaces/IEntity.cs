namespace ArchitectProg.Kernel.Extensions.Interfaces;

public interface IEntity<out TId>
{
    TId? Id { get; }
}