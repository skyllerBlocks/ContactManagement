using Alfasoft.Domain.Interfaces.Repositories;
using Alfasoft.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alfasoft.Dapper.Repositories
{
    public class ContactRepository : CrudRepository<ContactModel>, IContactRepository
    {
        private readonly IUnitOfWork _unitOfWork;

        public ContactRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
