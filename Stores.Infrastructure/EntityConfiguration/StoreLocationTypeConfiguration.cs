using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stores.Domain.AggregateModel.StoreAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stores.Infrastructure.EntityConfiguration
{
    public class StoreLocationTypeConfiguration : IEntityTypeConfiguration<StoreLocation>
    {
        public void Configure(EntityTypeBuilder<StoreLocation> builder)
        {
            builder.HasKey(o => o.Id);

            builder.Property(o => o.Country)
                .IsRequired();

            builder.Property(o => o.State)
               .IsRequired();

            builder.Property(o => o.Region)
               .IsRequired();

            builder.Property(o => o.Street)
               .IsRequired();

            builder.Property(o => o.Street2)
               .IsRequired();

            builder.Property(o => o.ZipCode)
               .IsRequired();

            builder.Property(o => o.PostalCode)
               .IsRequired();

            builder.Property(o => o.PhoneNumber)
               .IsRequired();

            builder.Property(o => o.PhoneNumber2)
               .IsRequired();

            builder.HasOne<StoreLogs>()
                .WithOne(o => o.StoreLocation)
                .OnDelete(DeleteBehavior.SetNull)
                .HasForeignKey<StoreLocation>(o => o.FK_StoreLocation_StoreLogs);
            

        }
    }
}
