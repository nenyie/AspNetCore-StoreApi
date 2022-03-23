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

    }
}
