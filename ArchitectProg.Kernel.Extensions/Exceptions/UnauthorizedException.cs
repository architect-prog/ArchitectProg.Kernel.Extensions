namespace ArchitectProg.Kernel.Extensions.Exceptions;

[Serializable]
public class UnauthorizedException(string message) : Exception(message);