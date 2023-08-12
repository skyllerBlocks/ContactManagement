using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Alfasoft.Domain.Interfaces.Repositories
{
    public interface ICrudRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();

        Task<T> GetById(object id);

        Task<T> SelectFirst(Expression<Func<T, bool>> predicate);

        Task<IEnumerable<T>> SelectAll(Expression<Func<T, bool>> predicate);

        Task Insert(T obj);

        Task Update(T obj);

        Task Delete(T obj);

        void Save();
    }
}
