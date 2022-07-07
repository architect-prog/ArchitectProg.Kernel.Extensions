namespace ArchitectProg.Kernel.Extensions.Common;

public class Result<T>
{
    private readonly T? value;
    private readonly Exception? exception;

    public T? ValueOrDefault => value;
    public bool IsSuccess => exception is null;

    public Result(T value)
    {
        this.value = value;
    }

    public Result(Exception exception)
    {
        value = default;
        this.exception = exception;
    }

    public R Match<R>(Func<T?, R> success, Func<Exception?, R> fail)
    {
        var result = IsSuccess ? success(value) : fail(exception);
        return result;
    }

    public static implicit operator Result<T>(T source)
    {
        var result = new Result<T>(source);
        return result;
    }
}