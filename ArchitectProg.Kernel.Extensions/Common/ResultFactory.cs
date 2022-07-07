namespace ArchitectProg.Kernel.Extensions.Common;

public static class ResultFactory
{
    public static Result<T> Failure<T>(Exception exception)
    {
        var result = new Result<T>(exception);
        return result;
    }
}