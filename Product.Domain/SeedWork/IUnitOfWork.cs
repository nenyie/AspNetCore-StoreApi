using Product.Domain.AggregateModel.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Product.Domain.SeedWork
{
     public interface IUnitOfWork
    {
        IProductRepository Product { get; }
        Task<int> Save(CancellationToken cancellationToken);
    }
}
