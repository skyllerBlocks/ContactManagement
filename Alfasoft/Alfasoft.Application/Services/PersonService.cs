using Alfasoft.Domain.Interfaces.Repositories;
using Alfasoft.Domain.Interfaces.Services;
using Alfasoft.Domain.Models;
using System.Diagnostics;

namespace Alfasoft.Application.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _contactRepository;

        public PersonService(IPersonRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public async Task DeleteAsync(PersonModel entity)
        {
            await _contactRepository.Delete(entity);
        }

        public async Task<List<PersonModel>> GetAll()
        {
            var result = await _contactRepository.GetAll();
            return (result.ToList());
        }

        public async Task<PersonModel> GetById(int Id)
        {
            var result = await _contactRepository.GetById(Id);
            return (result);
        }

        public async Task<bool> Insert(PersonModel entity)
        {
            try
            {
                await _contactRepository.Insert(entity);
                return (true);
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> Update(PersonModel entity)
        {
            try
            {
                await _contactRepository.Update(entity);
                return (true);
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception(ex.Message);
            }
        }
    }
}
