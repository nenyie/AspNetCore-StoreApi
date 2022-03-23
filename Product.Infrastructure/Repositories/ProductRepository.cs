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
            //var result = await _productContext.Products.AddAsync(product);
            var result = await _productContext.Products
                                .Include(x => x.ProductDescription)
                                .Include(x => x.ProductAmount)
                                .Include(x => x.ProductCouponInfo)
                                .Include(x => x.ProductVerification)
                                .Include(x => x.ProductDiscountInfo).SingleOrDefaultAsync();

                              await  _productContext.Products.AddAsync(result);
                              await _productContext.SaveChangesAsync();
                             return result; 
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
            if (product == null) 
                return null;
            var updatedproduct = new ProductEntity();
            updatedproduct.Id = product.Id;
            updatedproduct.ProductDescription = product.ProductDescription;
            updatedproduct.ProductVerification = product.ProductVerification;
            updatedproduct.ProductDiscountInfo = product.ProductDiscountInfo;
            updatedproduct.ProductCouponInfo = product.ProductCouponInfo;
            updatedproduct.ActivateReorderLevel = product.ActivateReorderLevel;
            updatedproduct.CartegoryName = product.CartegoryName;
            updatedproduct.ProductVerification = product.ProductVerification;
            updatedproduct.CartegoryName = product.CartegoryName ?? string.Empty;
            updatedproduct.Description = product.Description;   
            updatedproduct.SupplyAmount = product.SupplyAmount;
            updatedproduct.SupplyAmount = product?.SupplyAmount ?? 0;
            updatedproduct.SupplyDuration = product?.SupplyDuration;
            updatedproduct.MaximumStock = product?.MaximumStock ?? 0;
            updatedproduct.VendorName = product?.VendorName ?? string.Empty;
            updatedproduct.ProductRefNumber = product.ProductRefNumber;

             _productContext.Products.Update(updatedproduct);
             _productContext.SaveChangesAsync();
            return null;                    
        }

        public async Task<IEnumerable<ProductEntity>> GetAllProduct()
        {
            return  await _productContext.Products.ToListAsync();
        }
    }
}
