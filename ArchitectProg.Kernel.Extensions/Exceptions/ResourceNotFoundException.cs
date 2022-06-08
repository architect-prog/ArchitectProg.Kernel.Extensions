using DotNet.Kernel.Extentions.Constants;
using System.Runtime.Serialization;

namespace QuickChecks.Kernel.Exceptions;

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