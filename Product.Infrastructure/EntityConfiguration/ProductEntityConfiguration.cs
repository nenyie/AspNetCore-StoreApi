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

            builder.HasOne<ProductDescription>()
                .WithOne(o => o.ProductEntityAD)
                .IsRequired()
                .HasForeignKey<ProductEntity>(o => o.ProductDescriptionID);

            builder.HasOne<ProductAmount>()
               .WithOne(o => o.ProductEntity)
               .HasForeignKey<ProductEntity>(o => o.ProductAmountID)
               .IsRequired();

            builder.HasOne<ProductRating>()
                .WithMany(o => o.ProductEntities)
                .HasForeignKey(o => o.ProductRatingFK);

            builder.Property(o => o.Description)
                .IsRequired()
                .HasMaxLength(250);

            builder.HasOne<LeadTime>()
                .WithOne(o => o.ProductEntityLeadTime)
                .HasForeignKey<ProductEntity>(o => o.LeadTimeFK);

        }
    }
}
