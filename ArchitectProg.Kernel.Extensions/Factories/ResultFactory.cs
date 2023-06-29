using ArchitectProg.Kernel.Extensions.Exceptions;
using ArchitectProg.Kernel.Extensions.Factories.Interfaces;
using ArchitectProg.Kernel.Extensions.Utils;

namespace ArchitectProg.Kernel.Extensions.Factories;

public class ResultFactory : IResultFactory
{
    public Result Failure(Exception exception)
    {
        var result = new Result(exception);
        return result;
    }

    public Result<T> Failure<T>(Exception exception)
    {
        var result = new Result<T>(exception);
        return result;
    }

    public Result ValidationFailure(string message)
    {
        var exception = new ValidationException(message);
        var result = new Result(exception);

        return result;
    }

    public Result<T> ValidationFailure<T>(string message)
    {
        var exception = new ValidationException(message);
        var result = new Result<T>(exception);

        return result;
    }

    public Result AuthorizationFailure(string message)
    {
        var exception = new UnauthorizedException(message);
        var result = new Result(exception);

        return result;
    }

    public Result<T> AuthorizationFailure<T>(string message)
    {
        var exception = new UnauthorizedException(message);
        var result = new Result<T>(exception);

        return result;
    }

    public Result ResourceNotFoundFailure(string resourceName)
    {
        var exception = new ResourceNotFoundException(resourceName);
        var result = new Result(exception);

        return result;
    }

    public Result<T> ResourceNotFoundFailure<T>(string resourceName)
    {
        var exception = new ResourceNotFoundException(resourceName);
        var result = new Result<T>(exception);

        return result;
    }

    public Result Success()
    {
        var result = new Result();
        return result;
    }
}