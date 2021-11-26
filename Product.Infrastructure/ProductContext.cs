using Microsoft.EntityFrameworkCore;
using Product.Domain.AggregateModel.ProductAggregate;
using Product.Domain.AggregateModel.ProductCouponAggregate;
using Product.Domain.AggregateModel.ProductDetailsAggregate.Packaging;
using Product.Domain.AggregateModel.ProductDiscountAggregate;
using Product.Infrastructure.EntityConfiguration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Infrastructure
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) 
        {
            
        }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<ProductAmount> ProductAmounts { get; set; }
        public DbSet<ProductDescription> ProductDescriptions { get; set; }
        public DbSet<ProductRating> ProductRating { get; set; }
        public DbSet<LeadTime_EsTime> LeadTimeExtimates { get; set; }
        public DbSet<LeadTime> LeadTime { get; set; }
        public DbSet<LeadTime_Quantity> LeadTimeQuantity { get; set; }
        public DbSet<ProductDiscontInfo> ProductDiscount { get; set; }
        public DbSet<ProductCouponInfo> ProductCoupon { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ProductAmountTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProductDescriptionTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProductRatingTypeConfiguration());
            modelBuilder.ApplyConfiguration(new LeadTimeEstimateTypeConfiguration());
            modelBuilder.ApplyConfiguration(new LeadTimeTypeConfiguration());
            modelBuilder.ApplyConfiguration(new LeadTimeQuantityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProductDiscountTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProductCouponTypeConfiguration());
        }
    }

}