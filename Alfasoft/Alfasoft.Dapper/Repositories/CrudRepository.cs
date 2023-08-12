using Alfasoft.Domain.Interfaces.Repositories;
using Dommel;
using System.Linq.Expressions;

namespace Alfasoft.Dapper.Repositories
{
    public abstract class CrudRepository<T> : ICrudRepository<T> where T : class
    {
        private readonly IUnitOfWork _unitOfWork;

        protected CrudRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Delete(T obj)
        {
            try
            {
                _unitOfWork.Begin();

                await _unitOfWork.DbConnection.DeleteAsync<T>(obj, _unitOfWork.DbTransaction);

                Save();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            try
            {

                return await _unitOfWork.DbConnection.GetAllAsync<T>();

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public async Task<T> GetById(object id)
        {
            try
            {

                return await _unitOfWork.DbConnection.GetAsync<T>(id);

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public async Task<T> SelectFirst(Expression<Func<T, bool>> predicate)
        {
            try
            {

                var result = await _unitOfWork.DbConnection.SelectAsync<T>(predicate);

                return result.FirstOrDefault();

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<IEnumerable<T>> SelectAll(Expression<Func<T, bool>> predicate)
        {
            try
            {

                return await _unitOfWork.DbConnection.SelectAsync<T>(predicate);

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public async Task Insert(T obj)
        {
            try
            {
                _unitOfWork.Begin();

                await _unitOfWork.DbConnection.InsertAsync(obj, _unitOfWork.DbTransaction);

                Save();

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task Update(T obj)
        {
            try
            {
                _unitOfWork.Begin();

                await _unitOfWork.DbConnection.UpdateAsync(obj, _unitOfWork.DbTransaction);

                Save();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Save()
        {
            try
            {
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.RollBack();
                throw;
            }
        }
    }
}
