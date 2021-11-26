using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Product.Domain.AggregateModel.ProductDetailsAggregate.Packaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Infrastructure.EntityConfiguration
{
    public class LeadTimeQuantityTypeConfiguration : IEntityTypeConfiguration<LeadTime_Quantity>
    {
        public void Configure(EntityTypeBuilder<LeadTime_Quantity> builder)
        {
            builder.HasKey(o => o.Id);

            builder.Property<int>(o => o.LessThanTen)
               .HasMaxLength(400)
               .IsRequired();

            builder.Property<int>(o => o.ZeroToTen)
               .HasMaxLength(400)
               .IsRequired();

            builder.Property<int>(o => o.TenToTwenty)
             .HasMaxLength(400)
             .IsRequired();

            builder.Property<int>(o => o.TwentyToFifty)
               .HasMaxLength(400)
               .IsRequired();

            builder.Property<int>(o => o.FiftyToHundred)
               .HasMaxLength(400)
               .IsRequired();

            builder.Property<int>(o => o.GreaterThan1000)
             .HasMaxLength(400)
             .IsRequired();

            builder.HasOne<LeadTime>()
                .WithOne(o => o.LeadTime_Quantity)
                .HasForeignKey<LeadTime_Quantity>(o => o.LeadTimeFk2);

        }
    }
}
