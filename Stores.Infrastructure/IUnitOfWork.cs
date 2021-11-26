using Stores.Domain.AggregateModel.StoreAggregate;
using Stores.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stores.Infrastructure
{
    public interface IUnitOfWork
    {
        IStoreRepository StoreRepository { get; }
        Task SaveAsync();
    }
}
