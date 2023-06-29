using ArchitectProg.Kernel.Extensions.Entities;

namespace ArchitectProg.Kernel.Extensions.Tests.Entities;

public class TestEntity : Entity<int>
{
    public float TestProperty { get; set; }
}