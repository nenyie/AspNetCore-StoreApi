using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stores.Infrastructure
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        internal DbSet<T> dbSet;
        private readonly StoreContext context;
        //private readonly ILogger logger
        public GenericRepository(StoreContext context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }

        public GenericRepository()
        {
        }

        public virtual async Task<bool> Createstore(T entity)
        {
            await dbSet.AddAsync(entity);
            return true;          
        }

        public virtual async Task<bool> GetStore(Guid id)
        {
            await dbSet.FindAsync(id);
            return true;
        }

        public virtual Task<bool> DeleteStore(Guid id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<IEnumerable<T>> Get()
        {
            throw new NotImplementedException();
        }


        public virtual Task<T> Updatestore(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
