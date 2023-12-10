namespace ArchitectProg.Kernel.Extensions.Exceptions;

[Serializable]
public class ValidationException : Exception
{
    public ValidationException(string message) : base(message)
    {
    }

    public ValidationException(IEnumerable<string> messages) : base(string.Join(". ", messages))
    {
    }
}