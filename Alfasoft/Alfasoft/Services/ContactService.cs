using ContactManagement.Interface;
using ContactManagement.Models;

namespace ContactManagement.Service
{
    public class ContactService : IContactService
    {
        public List<ContactModel> GetAll()
        {
            var contactList = new List<ContactModel>
            {
                new ContactModel
                {
                    Id = 1,
                    Name = "Teste",
                    Email = "Teste@teste.com",
                    Address = "Teste Street",
                    Contact = "+55 11 5555-5555"
                },
                new ContactModel
                {
                    Id = 2,
                    Name = "Teste",
                    Email = "Teste@teste.com",
                    Address = "Teste Street",
                    Contact = "+55 11 5555-5555"
                },
                new ContactModel
                {
                    Id = 3,
                    Name = "Teste",
                    Email = "Teste@teste.com",
                    Address = "Teste Street",
                    Contact = "+55 11 5555-5555"
                },
                new ContactModel
                {
                    Id = 4,
                    Name = "Teste",
                    Email = "Teste@teste.com",
                    Address = "Teste Street",
                    Contact = "+55 11 5555-5555"
                },
            };

            return contactList;
        }

        public ContactModel GetById(int Id)
        {
            var contactList = new List<ContactModel>
            {
                new ContactModel
                {
                    Id = 1,
                    Name = "Teste",
                    Email = "Teste@teste.com",
                    Address = "Teste Street",
                    Contact = "+55 11 5555-5555"
                },
                new ContactModel
                {
                    Id = 2,
                    Name = "Teste",
                    Email = "Teste@teste.com",
                    Address = "Teste Street",
                    Contact = "+55 11 5555-5555"
                },
                new ContactModel
                {
                    Id = 3,
                    Name = "Teste",
                    Email = "Teste@teste.com",
                    Address = "Teste Street",
                    Contact = "+55 11 5555-5555"
                },
                new ContactModel
                {
                    Id = 4,
                    Name = "Teste",
                    Email = "Teste@teste.com",
                    Address = "Teste Street",
                    Contact = "+55 11 5555-5555"
                },
            };

            return contactList.FirstOrDefault(a => a.Id == Id);
        }
        public Task Create(ContactModel entity)
        {
            throw new NotImplementedException();
        }

        public Task Datail(ContactModel entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task Edit(ContactModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
