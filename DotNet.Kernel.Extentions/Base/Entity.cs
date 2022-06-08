using QuickChecks.Kernel.Interfaces;

namespace DotNet.Kernel.Extentions.Base;

public abstract class Entity<TId> : IEntity<TId>, IEquatable<Entity<TId>>
{
    public virtual TId? Id { get; set; }

    public static bool operator ==(Entity<TId>? first, Entity<TId>? second)
    {
        if (first == null && second == null)
            return true;

        if (first == null || second == null)
            return false;

        var result = first.Equals(second);
        return result;
    }

    public static bool operator !=(Entity<TId>? first, Entity<TId>? second)
    {
        var result = !(first == second);
        return result;
    }

    public bool Equals(Entity<TId>? other)
    {
        if (other == null)
            return false;

        if (ReferenceEquals(this, other))
            return true;

        if (!other.GetType().Equals(GetType()))
            return false;

        var result = Id?.Equals(other.Id) ?? false;
        return result;
    }

    public override bool Equals(object? obj)
    {
        var other = obj as Entity<TId>;
        var result = Equals(other);

        return result;
    }

    public override int GetHashCode()
    {
        var result = HashCode.Combine(Id);
        return result;
    }
}
