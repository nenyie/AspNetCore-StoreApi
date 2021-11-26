using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Product.Domain.AggregateModel.ProductAggregate;
using Product.Domain.AggregateModel.ProductDetailsAggregate.Packaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Infrastructure.EntityConfiguration
{
    public class LeadTimeTypeConfiguration : IEntityTypeConfiguration<LeadTime>
    {
        public void Configure(EntityTypeBuilder<LeadTime> builder)
        {
            builder.HasKey(o => o.Id);

            builder.Property<string>(o => o.PackageDetails)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property<string>(o => o.Weight)
               .HasMaxLength(40)
               .IsRequired();

            builder.Property<string>(o => o.Port)
             .HasMaxLength(40)
             .IsRequired();

            builder.HasOne<ProductEntity>()
                .WithOne(o => o.LeadTime)
                .HasForeignKey<LeadTime>(o => o.ProductEntityLeadTimeFK);

            builder.HasOne<LeadTime_EsTime>()
                .WithOne(o => o.LeadTimePK)
                .HasForeignKey<LeadTime>(o => o.LeadTime_EsTimeFk);
            
            builder.HasOne<LeadTime_Quantity>()
                .WithOne(o => o.LeadTimePK2)
                .HasForeignKey<LeadTime>(o => o.LeadTime_QuantityFk);
        }
    }
}
