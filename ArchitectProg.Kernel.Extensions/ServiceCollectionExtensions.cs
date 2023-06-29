using ArchitectProg.Kernel.Extensions.Factories;
using ArchitectProg.Kernel.Extensions.Factories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ArchitectProg.Kernel.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddKernelExtensions(this IServiceCollection serviceCollection)
    {
        if (serviceCollection is null)
            throw new ArgumentNullException(nameof(serviceCollection));

        serviceCollection.AddScoped<IResultFactory, ResultFactory>();
        serviceCollection.AddScoped<ISpecificationFactory, SpecificationFactory>();

        return serviceCollection;
    }
}