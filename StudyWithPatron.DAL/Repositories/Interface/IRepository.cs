using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudyWithPatron.DAL.Repositories.Interface
{
    public interface IRepository<T> 
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        void Create(T entity);
        void Update(T item);
        void Delete(T item);
    }
}