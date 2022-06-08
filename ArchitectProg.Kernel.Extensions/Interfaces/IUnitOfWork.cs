namespace ArchitectProg.Kernel.Extensions.Interfaces;

public interface IUnitOfWork : IDisposable
{
    Task Commit();
    Task Rollback();
}