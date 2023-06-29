using ArchitectProg.Kernel.Extensions.Utils;

namespace ArchitectProg.Kernel.Extensions.Factories.Interfaces;

public interface IResultFactory
{
    Result Failure(Exception exception);
    Result<T> Failure<T>(Exception exception);
    Result ValidationFailure(string message);
    Result<T> ValidationFailure<T>(string message);
    Result AuthorizationFailure(string message);
    Result<T> AuthorizationFailure<T>(string message);
    Result ResourceNotFoundFailure(string resourceName);
    Result<T> ResourceNotFoundFailure<T>(string resourceName);
    Result Success();
}