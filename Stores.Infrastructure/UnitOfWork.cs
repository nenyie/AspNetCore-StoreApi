using Stores.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stores.Infrastructure
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly StoreContext _context; 
        public IStoreRepository StoreRepository { get; private set; }
        public UnitOfWork(StoreContext context)
        {
            _context = context;
            StoreRepository = new StoreRepository(context);
        }

        public async Task SaveAsync()
        {
           await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
