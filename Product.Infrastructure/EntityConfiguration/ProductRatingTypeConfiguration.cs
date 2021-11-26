using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Product.Domain.AggregateModel.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Infrastructure.EntityConfiguration
{
    public class ProductRatingTypeConfiguration : IEntityTypeConfiguration<ProductRating>
    {
        public void Configure(EntityTypeBuilder<ProductRating> builder)
        {
            builder.HasKey(o => o.Id);

            builder.Property<int>(o => o.One)
                .HasMaxLength(25)
                .IsRequired();

            builder.Property<int>(o => o.Two)
                .HasMaxLength(25)
                .IsRequired();

            builder.Property<int>(o => o.Three)
                .HasMaxLength(25)
                .IsRequired();

            builder.Property<int>(o => o.Four)
                .HasMaxLength(25)
                .IsRequired();

            builder.Property<int>(o => o.Five)
                .HasMaxLength(25)
                .IsRequired();

            builder.HasOne<ProductDescription>()
                .WithOne(o => o.ProductRatingTT)
                .HasForeignKey<ProductRating>(o => o.ProductDescID);

            builder.HasMany<ProductEntity>()
               .WithOne(o => o.ProductRating)
               .HasForeignKey("F_ProductEntityId");

        }
    }
}
