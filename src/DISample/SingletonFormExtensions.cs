using Microsoft.Extensions.DependencyInjection;

namespace DISample;

public static class SingletonFormExtensions
{
    public static IServiceCollection AddSingletonForm<T>(this IServiceCollection services) where T : SingletonForm
    {
        services.AddSingleton<T>();
        return services;
    }
}