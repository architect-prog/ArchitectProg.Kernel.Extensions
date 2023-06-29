namespace ArchitectProg.Kernel.Extensions.Mappers.Interfaces;

public interface IMapper<in TSource, out TDestination>
{
    TDestination Map(TSource source);
    IEnumerable<TDestination> MapCollection(IEnumerable<TSource> source);
}