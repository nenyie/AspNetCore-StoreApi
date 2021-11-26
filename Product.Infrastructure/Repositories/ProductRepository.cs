using Microsoft.EntityFrameworkCore;
using Product.Domain.AggregateModel.ProductAggregate;
using Product.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _productContext;

        //public IUnitOfWork unitofWork
        //{
        //    get
        //    {
        //        return (IUnitOfWork)_productContext;
        //    }
        //}

        public ProductRepository(ProductContext productContext)
        {
            _productContext = productContext;
        }
        public async Task<ProductEntity> AddProduct(ProductEntity product)
        {
            var result = await _productContext.Products.AddAsync(product);
      
            return result.Entity; 
        }

        public async Task<bool> DeleteProduct(int id)
        {
            try
            {
                // var result = await _productContext.Products.Where(e => e.Id == id).FirstOrDefaultAsync();
                var result = await _productContext.Products.FirstOrDefaultAsync(e => e.Id == id);
                if (result == null) return false;

                _productContext.Products.Remove(result);

                return true;
            }
            catch (Exception)
            {
                return false; 
            }
        }

        public Task<ProductEntity> UpdateProduct(ProductEntity product)
        {
            //var result = await _productContext.Products.FirstOrDefaultAsync(e => e.Id == product.Id)
            return null;                    
        }

        public async Task<IEnumerable<ProductEntity>> GetAllProduct()
        {
            return  await _productContext.Products.ToListAsync();
        }
    }
}
