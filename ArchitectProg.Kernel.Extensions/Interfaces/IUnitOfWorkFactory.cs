namespace ArchitectProg.Kernel.Extensions.Interfaces;

public interface IUnitOfWorkFactory
{
    IUnitOfWork BeginTransaction();
}