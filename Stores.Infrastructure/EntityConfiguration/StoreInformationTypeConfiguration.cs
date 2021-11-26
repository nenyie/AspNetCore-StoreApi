using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Stores.Domain.AggregateModel.StoreAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stores.Infrastructure.EntityConfiguration
{
    public class StoreInformationTypeConfiguration : IEntityTypeConfiguration<StoreInformation>
    {
        public void Configure(EntityTypeBuilder<StoreInformation> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.StoreName)
                .HasMaxLength(256)
                .IsRequired();

            builder.Property(x => x.StoreRating)
                .HasMaxLength(100);

            builder.Property(x => x.BrandPhoto)
                .IsRequired();

            builder.HasOne<Store>()
                .WithOne(x => x.StoreInformation)
                .HasForeignKey<StoreInformation>(x => x.FK_StoreInformation_Store);   
        }
    }
}
