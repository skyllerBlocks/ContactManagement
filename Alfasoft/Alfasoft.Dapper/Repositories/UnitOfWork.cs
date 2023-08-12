using Alfasoft.Domain.Enum;
using Alfasoft.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfasoft.Dapper.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly IDbConnection _dbConnection;
        private IDbTransaction _dbTransaction = null;

        public UnitOfWork(IDbConnectionFactory dbConnectionFactory)
        {
            _dbConnection = dbConnectionFactory.CreateConnection(EnumDataBaseConnection.DBSQLite);
        }

        public UnitOfWork(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        IDbConnection IUnitOfWork.DbConnection => _dbConnection;
        IDbTransaction IUnitOfWork.DbTransaction => _dbTransaction;

        public void Begin()
        {
            if (_dbConnection.State == ConnectionState.Closed) _dbConnection.Open();

            if (_dbTransaction != null) return;

            _dbTransaction = _dbConnection.BeginTransaction();
        }

        public void Commit()
        {
            if (_dbTransaction != null)
            {
                try
                {
                    _dbTransaction.Commit();
                    Dispose();
                }
                catch (Exception)
                {
                    RollBack();
                    throw;
                }
            }
        }

        public void RollBack()
        {
            _dbTransaction.Rollback();
            Dispose();
        }

        public void Dispose()
        {
            _dbTransaction?.Dispose();
            _dbTransaction = null;
        }

    }

}
