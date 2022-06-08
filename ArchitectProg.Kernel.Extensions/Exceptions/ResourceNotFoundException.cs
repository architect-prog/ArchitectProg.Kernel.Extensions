using System.Runtime.Serialization;
using ArchitectProg.Kernel.Extensions.Constants;

namespace ArchitectProg.Kernel.Extensions.Exceptions;

[Serializable]
public class ResourceNotFoundException : Exception
{
    public ResourceNotFoundException(string resourceName)
        : base(string.Format(ExceptionConstants.ResourceNotFound, resourceName))
    {
    }

    protected ResourceNotFoundException(
        SerializationInfo info,
        StreamingContext context) : base(info, context)
    {
    }
}