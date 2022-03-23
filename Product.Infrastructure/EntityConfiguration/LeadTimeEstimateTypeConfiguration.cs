using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Product.Domain.AggregateModel.ProductDetailsAggregate.Packaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Infrastructure.EntityConfiguration
{
    public class LeadTimeEstimateTypeConfiguration : IEntityTypeConfiguration<LeadTime_EsTime>
    {
        public void Configure(EntityTypeBuilder<LeadTime_EsTime> builder)
        {
            builder.HasKey(o => o.LeadId);

            builder.Property<int>(o => o.LessThanTenDays)
                .HasMaxLength(16)
                .IsRequired();

            builder.Property<int>(o => o.GreaterThan1000Days)
                .IsRequired()
                .HasMaxLength(16);

            builder.Property<int>(o => o.FiftyToHundredDays)
                .IsRequired();

            builder.Property<int>(o => o.ZeroToTenDays)
                .IsRequired();

            builder.Property<int?>(o => o.TwentyToFiftyDays)
                .IsRequired();

            builder.Property<int>(o => o.TenToTwentyDays)
                .IsRequired();

           // builder.HasOne<LeadTime>()
             //   .WithOne(o => o.LeadTime_EsTime)
              //  .HasForeignKey<LeadTime_EsTime>(o => o.LdTimeFk);
        }

    }
}
