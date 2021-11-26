using Microsoft.EntityFrameworkCore;
using Product.Domain.AggregateModel.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Product.API.Application.Queries.ProductViewModel;

namespace Product.API.Application.Queries
{
    public class ProductQueries : IProductQueries
    {
        public string ProductConnectionString { get; }

        public ProductQueries(string productConnectionString)
        {
            ProductConnectionString = productConnectionString;
        }

        public Task<IEnumerable<ProductDto>> GetAllProduct()
        {
            throw new NotImplementedException();
        }

        public Task<ProductDto> GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        //public async Task<IEnumerable<ProductDto>> GetAllProduct()
        //{
        //    var result = await productContext.Products.ToListAsync();
        //    return (IEnumerable<ProductDto>)result;
        //}

        //public async Task<ProductDto> GetProductById(int id)
        //{
        //    var result = await productContext.Products.FirstOrDefaultAsync(e => e.Id == id);
        //    if(result == null)
        //    {
        //        return null;
        //    }
        //    return (ProductDto)result;
        //}
    }
}
