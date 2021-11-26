using Microsoft.EntityFrameworkCore;
using Stores.Domain.AggregateModel.StoreAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stores.Infrastructure
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {

        }
        public DbSet<Store> Stores { get; set; } 
    }
}
