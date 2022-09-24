using ArchitectProg.Kernel.Extensions.Exceptions;

namespace ArchitectProg.Kernel.Extensions.Common;

public static class ResultFactory
{
    public static Result<T> Failure<T>(Exception exception)
    {
        var result = new Result<T>(exception);
        return result;
    }

    public static Result<T> ValidationFailure<T>(string message)
    {
        var exception = new ValidationException(message);
        var result = new Result<T>(exception);

        return result;
    }

    public static Result<T> AuthorizationFailure<T>(string message)
    {
        var exception = new UnauthorizedException(message);
        var result = new Result<T>(exception);

        return result;
    }

    public static Result<T> ResourceNotFoundFailure<T>(string resourceName)
    {
        var exception = new ResourceNotFoundException(resourceName);
        var result = new Result<T>(exception);

        return result;
    }

    public static Result Success()
    {
        var result = new Result();
        return result;
    }

    public static Result Failure(Exception exception)
    {
        var result = new Result(exception);
        return result;
    }

    public static Result ValidationFailure(string message)
    {
        var exception = new ValidationException(message);
        var result = new Result(exception);

        return result;
    }

    public static Result AuthorizationFailure(string message)
    {
        var exception = new UnauthorizedException(message);
        var result = new Result(exception);

        return result;
    }

    public static Result ResourceNotFoundFailure(string resourceName)
    {
        var exception = new ResourceNotFoundException(resourceName);
        var result = new Result(exception);

        return result;
    }
}