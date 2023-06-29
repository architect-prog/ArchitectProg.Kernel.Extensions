using ArchitectProg.Kernel.Extensions.Mappers.Interfaces;

namespace ArchitectProg.Kernel.Extensions.Mappers;

public abstract class Mapper<TSource, TDestination> : IMapper<TSource, TDestination>
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