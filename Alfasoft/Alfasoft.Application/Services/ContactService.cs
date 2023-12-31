﻿using Alfasoft.Domain.Interfaces.Repositories;
using Alfasoft.Domain.Interfaces.Services;
using Alfasoft.Domain.Models;
using ExternalServices.ExternalInterface;
using ExternalServices.ExternalInterface.Restcountries.Model;

namespace Alfasoft.Application.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;
        private readonly IRestcountriesService _restcountriesService;

        public ContactService(IContactRepository contactRepository, IRestcountriesService restcountriesService)
        {
            _contactRepository = contactRepository;
            _restcountriesService = restcountriesService;
        }

        public async Task DeleteAsync(ContactModel entity)
        {
            await _contactRepository.Delete(entity);
        }

        public async Task<List<ContactModel>> GetAll()
        {
            var result = await _contactRepository.GetAll();
            return (result.ToList());
        }

        public async Task<ContactModel> GetById(int Id)
        {
            var result = await _contactRepository.GetById(Id);
            return (result);
        }

        public async Task<bool> Insert(ContactModel entity)
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

        public async Task<bool> Update(ContactModel entity)
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

        public async Task<List<RestcointriesModel>> GetRestcountriesList()
        {
           return await _restcountriesService.GetAll();
        }
    }
}
