using ContactManagement.Models;

namespace ContactManagement.Interface
{
    public interface IContactService
    {
        List<ContactModel> GetAll();
        ContactModel GetById(int Id);
        public Task Create(ContactModel entity);
        public Task Datail(ContactModel entity);
        public Task Edit(ContactModel entity);
        public Task Delete(int Id);
    }
}
