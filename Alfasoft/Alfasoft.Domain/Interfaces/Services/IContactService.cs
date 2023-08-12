using Alfasoft.Domain.Interfaces.Repositories;
using Alfasoft.Domain.Models;
using ExternalServices.ExternalInterface.Restcountries.Model;

namespace Alfasoft.Domain.Interfaces.Services
{
    public interface IContactService
    {
        Task DeleteAsync(ContactModel entity);
        Task<List<ContactModel>> GetAll();
        Task<ContactModel> GetById(int Id);
        Task<bool> Insert(ContactModel entity);
        Task<bool> Update(ContactModel entity);
        Task<List<RestcointriesModel>> GetRestcountriesList();
    }
}
