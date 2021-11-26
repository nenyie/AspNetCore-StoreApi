using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Product.Domain.AggregateModel.ProductCouponAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Infrastructure.EntityConfiguration
{
    public class ProductCouponTypeConfiguration : IEntityTypeConfiguration<ProductCouponInfo>
    {
        public void Configure(EntityTypeBuilder<ProductCouponInfo> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property<DateTime>(x => x.CouponStartDate)
                .IsRequired();

            builder.Property<DateTime>(x => x.CouponExpiryDate)
                .IsRequired();

            builder.Property<int>(x => x.Coupon)
                .IsRequired();

            builder.Property<int>(x => x.CouponValidityPeriod)
                .IsRequired();

            builder.Property<bool>(x => x.IsCouponavaliable)
                .IsRequired();

        }
    }
}
