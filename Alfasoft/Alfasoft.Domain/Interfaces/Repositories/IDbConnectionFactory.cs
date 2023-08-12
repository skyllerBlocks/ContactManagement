using Alfasoft.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfasoft.Domain.Interfaces.Repositories
{
    public interface IDbConnectionFactory
    {
        IDbConnection CreateConnection(EnumDataBaseConnection database);

    }
}
