using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Product.Domain.AggregateModel.ProductDiscountAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Infrastructure.EntityConfiguration
{
    public class ProductDiscountTypeConfiguration : IEntityTypeConfiguration<ProductDiscontInfo>
    {
        public void Configure(EntityTypeBuilder<ProductDiscontInfo> builder)
        {        
            builder.HasKey(x => x.Id);

            builder.Property<DateTime>(x => x.DiscountExpiryDate)
                .IsRequired();

            builder.Property<DateTime>(x => x.DiscontStartDate)
                .IsRequired();

            builder.Property<int>(x => x.Discount)
                .IsRequired();

            builder.Property<int>(x => x.DiscountValidityPeriod)
                .IsRequired();

            builder.Property<bool>(x => x.IsDiscountavaliable)
                .IsRequired();


        }
    }
}
