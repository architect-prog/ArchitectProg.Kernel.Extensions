namespace ArchitectProg.Kernel.Extensions.Exceptions;

[Serializable]
public class ResourceNotFoundException(string resourceName)
    : Exception($"Resource: '{resourceName}' not found");