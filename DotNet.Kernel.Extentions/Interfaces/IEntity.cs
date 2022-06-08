namespace QuickChecks.Kernel.Interfaces;

public interface IEntity<TId>
{
    TId? Id { get; }
}