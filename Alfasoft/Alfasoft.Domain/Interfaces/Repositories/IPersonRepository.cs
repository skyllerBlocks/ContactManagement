using Alfasoft.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfasoft.Domain.Interfaces.Repositories
{
    public interface IPersonRepository : ICrudRepository<PersonModel>
    {
    }
}
