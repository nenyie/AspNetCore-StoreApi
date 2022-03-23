using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Product.Domain.AggregateModel.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Infrastructure.EntityConfiguration
{
    public class ProductDescriptionTypeConfiguration : IEntityTypeConfiguration<ProductDescription>
    {
        public void Configure(EntityTypeBuilder<ProductDescription> builder)
        {
            builder.HasKey(o => o.Id);

            builder.HasOne<ProductEntity>()
              .WithOne(o => o.ProductDescription)
              .IsRequired()
             .HasForeignKey<ProductDescription>(o => o.EntityId);

            builder.Property<string>(o => o.ProductName)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property<string>(o => o.StoreName)
               .HasMaxLength(100)
               .IsRequired();

            //builder.HasOne<ProductRating>()
              //  .WithOne(o => o.ProductDescription)
                //.HasForeignKey<ProductDescription>(o => o.ProductRatingId)
                //.IsRequired();

            builder.Property<int>(o => o.AmountBought)
               .HasMaxLength(100)
               .IsRequired();

         
        }
    }
}
