using ArchitectProg.Kernel.Extensions.Interfaces;

namespace ArchitectProg.Kernel.Extensions.Base;

public abstract class BaseMapper<TSource, TDestination> : IMapper<TSource, TDestination>
{
    public abstract TDestination Map(TSource source);

    public virtual IEnumerable<TDestination> MapCollection(IEnumerable<TSource> source)
    {
        if (source == null)
        {
            throw new ArgumentNullException(nameof(source));
        }

        var result = source.Select(x => Map(x)).ToArray();
        return result;
    }
}
