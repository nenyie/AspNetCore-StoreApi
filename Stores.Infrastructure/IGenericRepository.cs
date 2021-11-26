using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stores.Infrastructure
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> Get();
        Task<bool> Createstore(T entity);
        Task<bool> DeleteStore(Guid id);
        Task<T> Updatestore(T entity);
        Task<bool> GetStore(Guid id);
    }
}
