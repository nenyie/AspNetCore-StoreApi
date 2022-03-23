using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Product.Domain.AggregateModel.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Infrastructure.EntityConfiguration
{
    public class ProductAmountTypeConfiguration : IEntityTypeConfiguration<ProductAmount>
    {
        public void Configure(EntityTypeBuilder<ProductAmount> builder)
        {
            builder.HasKey(o => o.Id);

            builder.Property<int>(o => o.ProductPrice)
                .HasMaxLength(16)
                .IsRequired();

            builder.Property<int>(o => o.ProductDiscount)
                .IsRequired()
                .HasMaxLength(16);

            builder.Property(o => o.CouponExpiryDate)
                .IsRequired();

            builder.Property<bool>(o => o.GetCoupon)
                .IsRequired();

            builder.Property<int>(o => o.ProductOnSale)
                .IsRequired();
            
            builder.Property<int>(o => o.FreeShiping)
                .IsRequired();
            
            builder.Property<bool>(o => o.IsNegotiable)
                .IsRequired();

            builder.HasOne<ProductEntity>()
                .WithOne(o => o.ProductAmount)
                .HasForeignKey<ProductAmount>(o => o.ProductEntityId);
                

        }
    }

}
