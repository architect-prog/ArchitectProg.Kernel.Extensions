namespace ArchitectProg.Kernel.Extensions.Utils;

public class Result<TValue>
{
    private readonly TValue? value;
    private readonly Exception? exception;

    public TValue? ValueOrDefault => value;
    public Exception? Exception => exception;
    public bool IsSuccess => exception is null;

    public Result(TValue value)
    {
        this.value = value;
    }

    public Result(Exception exception)
    {
        value = default;
        this.exception = exception;
    }

    public TResult Match<TResult>(Func<TValue?, TResult> success, Func<Exception?, TResult> fail)
    {
        var result = IsSuccess ? success(value) : fail(exception);
        return result;
    }

    public static implicit operator Result<TValue>(TValue source)
    {
        var result = new Result<TValue>(source);
        return result;
    }
}

public class Result
{
    private readonly Exception? exception;

    public Exception? Exception => exception;
    public bool IsSuccess => exception is null;

    public Result()
    {
    }

    public Result(Exception exception)
    {
        this.exception = exception;
    }

    public R Match<R>(Func<R> success, Func<Exception?, R> fail)
    {
        var result = IsSuccess ? success() : fail(exception);
        return result;
    }
}