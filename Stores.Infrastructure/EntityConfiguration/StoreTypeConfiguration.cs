using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stores.Domain.AggregateModel.StoreAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stores.Infrastructure.EntityConfiguration
{
    public class StoreTypeConfiguration : IEntityTypeConfiguration<Store>
    {
        //var converter = new ValueConverter<StoreType, string>(
        //v => v.ToString(),
        //v => (StoreType)Enum.Parse(typeof(StoreType), v));

        // .HasConversion<string>();  .HasConversion<int>();

        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.StoreNumber)
                .IsRequired();

            builder.Property(x => x.StoreRating)
                .IsRequired();

            builder.Property(x => x.StoreType)
                .HasConversion(v => v.ToString(),         
                v => (StoreType)Enum.Parse(typeof(StoreType), v));

            builder.HasOne<StoreLogs>()
                .WithOne(x => x.Store)
                .HasForeignKey<Store>(x => x.FK_Store_StoreLogs_StoreLocation);

            builder.HasOne<StoreLocation>()
                .WithOne(x => x.Store)
                .HasForeignKey<Store>(x => x.FK_Store_StoreLocation);

            builder.HasOne<StoreInformation>()
                .WithOne(x => x.Store)
                .HasForeignKey<Store>(x => x.FK_Store_StoreInformation);

        }
    }
}
