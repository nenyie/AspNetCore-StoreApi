using Product.Domain.AggregateModel.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Product.Domain.SeedWork
{
    public interface IRepository<T>  where T : class
    {
        public IProductRepository ProductRepository { get; set; }
    }
}