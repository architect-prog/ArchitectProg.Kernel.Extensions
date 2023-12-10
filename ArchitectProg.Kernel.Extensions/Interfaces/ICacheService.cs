namespace ArchitectProg.Kernel.Extensions.Interfaces;

public interface ICacheService
{
    Task<T?> GetValueOrDefault<T>(string key);
    Task SetValue<T>(string key, T value, TimeSpan? expirationTime = null);
    Task Delete(string key);
}