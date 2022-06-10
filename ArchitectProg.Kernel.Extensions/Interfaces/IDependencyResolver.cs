namespace ArchitectProg.Kernel.Extensions.Interfaces;

public interface IDependencyResolver
{
    public TDependency ResolveDependency<TDependency>() where TDependency : class;
}