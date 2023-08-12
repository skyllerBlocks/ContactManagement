using Alfasoft.Domain.Interfaces.Repositories;
using Alfasoft.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfasoft.Dapper.Repositories
{
    public class PersonRepository : CrudRepository<PersonModel>, IPersonRepository
    {
        private readonly IUnitOfWork _unitOfWork;

        public PersonRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
