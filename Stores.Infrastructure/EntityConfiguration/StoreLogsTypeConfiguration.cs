using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stores.Domain.AggregateModel.StoreAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stores.Infrastructure.EntityConfiguration
{
    public class StoreLogsTypeConfiguration : IEntityTypeConfiguration<StoreLogs>
    {
        public void Configure(EntityTypeBuilder<StoreLogs> builder)
        {
            builder.HasKey(o => o.Id);

            builder.Property(o => o.AmountSold)
                .IsRequired();

            builder.Property(o => o.AmountBought)
                .IsRequired();

            builder.HasOne<StoreLocation>()
                .WithOne(o => o.StoreLogs)
                .HasForeignKey<StoreLogs>(o => o.FK_StoreLogs_StoreLocation);

            builder.Property(o => o.SimilarStroes)
                .IsRequired();

            builder.Property(o => o.MainProducts)
              .IsRequired();

            builder.Property(o => o.NumberOfClients)
              .IsRequired();

            builder.Property(o => o.NumberOfFemaleCustomer)
              .IsRequired();

            builder.Property(o => o.NumberOfMaleCustomer)
              .IsRequired();

            builder.Property(o => o.MainMarkets)
              .IsRequired();

            builder.HasOne<Store>()
                .WithOne(x => x.StoreLogs)
                .HasForeignKey<StoreLogs>(x => x.FK_StoreLogs_Store);

        }
    }
}
