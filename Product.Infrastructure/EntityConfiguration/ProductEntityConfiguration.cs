using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Product.Domain.AggregateModel.ProductAggregate;
using Product.Domain.AggregateModel.ProductDetailsAggregate.Packaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Infrastructure.EntityConfiguration
{
    class ProductEntityConfiguration : IEntityTypeConfiguration<ProductEntity>
    {
        public void Configure(EntityTypeBuilder<ProductEntity> builder)
        {     
            builder.HasKey(o => o.Id);
         
            builder.Property(o => o.ProductDate)
                 .IsRequired();

            builder.Property(o => o.ProductContent)
                .IsRequired();

            builder.Property(o => o.SupplyAmount)
                .IsRequired();

            builder.Property(o => o.SupplyDuration)
                .IsRequired();

            builder.Property(o => o.ProductRefNumber)
                .IsRequired();

            builder.Property(o => o.StockId)
                .IsRequired();

            builder.Property(o => o.StoreId)
                .IsRequired();

            builder.Property(o => o.CartegoryId)
                .IsRequired();

            builder.Property(o => o.CartegoryName)
                .IsRequired();

            builder.Property(o => o.VendorId)
                .IsRequired();

            builder.Property(o => o.MaximumStock)
                .IsRequired();

            builder.Property(o => o.ActivateReorderLevel)
                .HasMaxLength(10)
                .IsRequired();

            builder.HasOne<ProductDescription>()
                .WithOne(o => o.ProductEntityAD)
                .IsRequired()
                .HasForeignKey<ProductEntity>(o => o.ProductDescriptionID);

            builder.HasOne<ProductAmount>()
               .WithOne(o => o.ProductEntity)
               .HasForeignKey<ProductEntity>(o => o.ProductAmountID)
               .IsRequired();

            builder.Property(x => x.ProductVerification)
                .HasConversion(x => x.ToString(),
                v => (ProductVerification)Enum.Parse(typeof(ProductVerification), v));
                
           // builder.HasOne<ProductRating>()
             //   .WithMany(o => o.ProductEntities)
               // .HasForeignKey(o => o.ProductRatingFK);

            builder.Property(o => o.Description)
                .IsRequired()
                .HasMaxLength(250);

           // builder.HasOne<LeadTime>()
             //   .WithOne(o => o.ProductEntityLeadTime)
               // .HasForeignKey<ProductEntity>(o => o.LeadTimeFK);

        }
    }
}
