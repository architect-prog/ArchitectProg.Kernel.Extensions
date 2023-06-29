using System.Runtime.Serialization;

namespace ArchitectProg.Kernel.Extensions.Exceptions;

[Serializable]
public class ResourceNotFoundException : Exception
{
    public ResourceNotFoundException(string resourceName)
        : base($"Resource: '{resourceName}' not found")
    {
    }

    protected ResourceNotFoundException(
        SerializationInfo info,
        StreamingContext context) : base(info, context)
    {
    }
}