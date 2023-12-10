namespace ArchitectProg.Kernel.Extensions.Mappers;

public interface IMapper<in TSource, out TDestination>
{
    TDestination Map(TSource source);

    IEnumerable<TDestination> MapCollection(IEnumerable<TSource> source)
    {
        ArgumentNullException.ThrowIfNull(source);

        var result = source.Select(x => Map(x)).ToArray();
        return result;
    }
}