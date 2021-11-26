using Product.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Product.Domain.AggregateModel.ProductAggregate
{
    public interface IProductRepository
    {
        Task<ProductEntity> AddProduct(ProductEntity product);
        Task<ProductEntity> UpdateProduct(ProductEntity product);
        Task<bool> DeleteProduct(int id);
     
    }
}
