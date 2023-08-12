using Alfasoft.Domain.Interfaces.Repositories;
using Alfasoft.Domain.Models;

namespace Alfasoft.Domain.Interfaces.Services
{
    public interface IPersonService
    {
        Task DeleteAsync(PersonModel entity);
        Task<List<PersonModel>> GetAll();
        Task<PersonModel> GetById(int Id);
        Task<bool> Insert(PersonModel entity);
        Task<bool> Update(PersonModel entity);
    }
}
