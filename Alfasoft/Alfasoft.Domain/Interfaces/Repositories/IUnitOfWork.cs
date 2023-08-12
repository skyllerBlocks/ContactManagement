using System.Data;

namespace Alfasoft.Domain.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IDbConnection DbConnection { get; }
        IDbTransaction DbTransaction { get; }
        void Begin();
        void Commit();
        void RollBack();
    }
}
