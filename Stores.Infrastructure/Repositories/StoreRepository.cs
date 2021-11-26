using Microsoft.EntityFrameworkCore;
using Stores.Domain.AggregateModel.StoreAggregate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stores.Infrastructure.Repositories
{
    public class StoreRepository : GenericRepository<Store>, IStoreRepository
    {
        protected readonly StoreContext context;
        new readonly DbSet<Store> dbSet;

        public StoreRepository(StoreContext context)
        {
            this.context = context;
        }
        public override async Task<bool> Createstore(Store entity)
        {
            //await context.Stores.AddAsync(entity);
            await dbSet.AddAsync(entity);
            return true;
        }

        public override Task<bool> DeleteStore(Guid id)
        {
            throw new NotImplementedException();
        }

        public override Task<IEnumerable<Store>> Get()
        {
            throw new NotImplementedException();
        }

        public override Task<bool> GetStore(Guid id)
        {
            throw new NotImplementedException();
        }

        public override Task<Store> Updatestore(Store entity)
        {
            throw new NotImplementedException();
        }
    }
}
