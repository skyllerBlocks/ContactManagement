using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alfasoft.Domain.Enum;
using Microsoft.Data.Sqlite;
using Alfasoft.Domain.Interfaces.Repositories;

namespace Alfasoft.Dapper.Factory
{
    public class DapperConnectionFactory : IDbConnectionFactory
    {
        private readonly IDictionary<EnumDataBaseConnection, string> _connectionDict;

        public DapperConnectionFactory(IDictionary<EnumDataBaseConnection, string> connectionDict)
        {
            _connectionDict = connectionDict;
        }

        public IDbConnection CreateConnection(EnumDataBaseConnection database)
        {
            string connectionString = null;

            if (_connectionDict.TryGetValue(database, out connectionString))
            {
                DbProviderFactory factory = SqliteFactory.Instance;
                var conn = factory.CreateConnection();
                conn.ConnectionString = connectionString;
                return conn;
            }

            throw new ArgumentNullException();
        }

    }
}
