﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Product.Infrastructure;

#nullable disable

namespace Product.API.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20211113150413_initial migration2")]
    partial class initialmigration2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Product.Domain.AggregateModel.ProductAggregate.ProductAmount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CouponExpiryDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("FreeShiping")
                        .HasColumnType("integer");

                    b.Property<bool>("GetCoupon")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsNegotiable")
                        .HasColumnType("boolean");

                    b.Property<int?>("MaximumPrice")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.Property<int?>("MinimunPrice")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.Property<int>("ProductDiscount")
                        .HasMaxLength(16)
                        .HasColumnType("integer");

                    b.Property<int>("ProductEntityId")
                        .HasColumnType("integer");

                    b.Property<int>("ProductOnSale")
                        .HasColumnType("integer");

                    b.Property<int>("ProductPrice")
                        .HasMaxLength(16)
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ProductEntityId")
                        .IsUnique();

                    b.ToTable("ProductAmounts");
                });

            modelBuilder.Entity("Product.Domain.AggregateModel.ProductAggregate.ProductDescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AmountBought")
                        .HasMaxLength(100)
                        .HasColumnType("integer");

                    b.Property<int>("EntityId")
                        .HasColumnType("integer");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("ProductRatingId")
                        .HasColumnType("integer");

                    b.Property<string>("StoreName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.HasIndex("EntityId")
                        .IsUnique();

                    b.HasIndex("ProductRatingId")
                        .IsUnique();

                    b.ToTable("ProductDescriptions");
                });

            modelBuilder.Entity("Product.Domain.AggregateModel.ProductAggregate.ProductEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Coupon")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<int>("Discount")
                        .HasColumnType("integer");

                    b.Property<int?>("F_ProductEntityId")
                        .HasColumnType("integer");

                    b.Property<int>("LeadTimeFK")
                        .HasColumnType("integer");

                    b.Property<int>("ProductAmountID")
                        .HasColumnType("integer");

                    b.Property<int?>("ProductCouponInfoId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ProductDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("ProductDescriptionID")
                        .HasColumnType("integer");

                    b.Property<int?>("ProductDiscountInfoId")
                        .HasColumnType("integer");

                    b.Property<int>("ProductRatingFK")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("F_ProductEntityId");

                    b.HasIndex("LeadTimeFK")
                        .IsUnique();

                    b.HasIndex("ProductAmountID")
                        .IsUnique();

                    b.HasIndex("ProductCouponInfoId");

                    b.HasIndex("ProductDescriptionID")
                        .IsUnique();

                    b.HasIndex("ProductDiscountInfoId");

                    b.HasIndex("ProductRatingFK");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Product.Domain.AggregateModel.ProductAggregate.ProductRating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("F_ProductEntityId")
                        .HasColumnType("integer");

                    b.Property<int>("Five")
                        .HasMaxLength(25)
                        .HasColumnType("integer");

                    b.Property<int>("Four")
                        .HasMaxLength(25)
                        .HasColumnType("integer");

                    b.Property<int>("One")
                        .HasMaxLength(25)
                        .HasColumnType("integer");

                    b.Property<int>("ProductDescID")
                        .HasColumnType("integer");

                    b.Property<int>("Three")
                        .HasMaxLength(25)
                        .HasColumnType("integer");

                    b.Property<int>("Two")
                        .HasMaxLength(25)
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ProductDescID")
                        .IsUnique();

                    b.ToTable("ProductRating");
                });

            modelBuilder.Entity("Product.Domain.AggregateModel.ProductCouponAggregate.ProductCouponInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Coupon")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CouponExpiryDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("CouponStartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CouponValidityPeriod")
                        .HasColumnType("integer");

                    b.Property<bool>("IsCouponavaliable")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("ProductCoupon");
                });

            modelBuilder.Entity("Product.Domain.AggregateModel.ProductDetailsAggregate.Packaging.LeadTime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("LeadTime_EsTimeFk")
                        .HasColumnType("integer");

                    b.Property<int>("LeadTime_QuantityFk")
                        .HasColumnType("integer");

                    b.Property<string>("PackageDetails")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Port")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)");

                    b.Property<int>("ProductEntityLeadTimeFK")
                        .HasColumnType("integer");

                    b.Property<string>("Weight")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)");

                    b.HasKey("Id");

                    b.HasIndex("LeadTime_EsTimeFk")
                        .IsUnique();

                    b.HasIndex("LeadTime_QuantityFk")
                        .IsUnique();

                    b.HasIndex("ProductEntityLeadTimeFK")
                        .IsUnique();

                    b.ToTable("LeadTime");
                });

            modelBuilder.Entity("Product.Domain.AggregateModel.ProductDetailsAggregate.Packaging.LeadTime_EsTime", b =>
                {
                    b.Property<int>("LeadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("LeadId"));

                    b.Property<int>("FiftyToHundredDays")
                        .HasColumnType("integer");

                    b.Property<int>("GreaterThan1000Days")
                        .HasMaxLength(16)
                        .HasColumnType("integer");

                    b.Property<int>("LdTimeFk")
                        .HasColumnType("integer");

                    b.Property<int>("LessThanTenDays")
                        .HasMaxLength(16)
                        .HasColumnType("integer");

                    b.Property<int>("TenToTwentyDays")
                        .HasColumnType("integer");

                    b.Property<int>("TwentyToFiftyDays")
                        .HasColumnType("integer");

                    b.Property<int>("ZeroToTenDays")
                        .HasColumnType("integer");

                    b.HasKey("LeadId");

                    b.HasIndex("LdTimeFk")
                        .IsUnique();

                    b.ToTable("LeadTimeExtimates");
                });

            modelBuilder.Entity("Product.Domain.AggregateModel.ProductDetailsAggregate.Packaging.LeadTime_Quantity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("FiftyToHundred")
                        .HasMaxLength(400)
                        .HasColumnType("integer");

                    b.Property<int>("GreaterThan1000")
                        .HasMaxLength(400)
                        .HasColumnType("integer");

                    b.Property<int>("LeadTimeFk2")
                        .HasColumnType("integer");

                    b.Property<int>("LessThanTen")
                        .HasMaxLength(400)
                        .HasColumnType("integer");

                    b.Property<int>("TenToTwenty")
                        .HasMaxLength(400)
                        .HasColumnType("integer");

                    b.Property<int>("TwentyToFifty")
                        .HasMaxLength(400)
                        .HasColumnType("integer");

                    b.Property<int>("ZeroToTen")
                        .HasMaxLength(400)
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("LeadTimeFk2")
                        .IsUnique();

                    b.ToTable("LeadTimeQuantity");
                });

            modelBuilder.Entity("Product.Domain.AggregateModel.ProductDiscountAggregate.ProductDiscontInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DiscontStartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Discount")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DiscountExpiryDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DiscountValidityPeriod")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDiscountavaliable")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("ProductDiscount");
                });

            modelBuilder.Entity("Product.Domain.AggregateModel.ProductAggregate.ProductAmount", b =>
                {
                    b.HasOne("Product.Domain.AggregateModel.ProductAggregate.ProductEntity", null)
                        .WithOne("ProductAmount")
                        .HasForeignKey("Product.Domain.AggregateModel.ProductAggregate.ProductAmount", "ProductEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Product.Domain.AggregateModel.ProductAggregate.ProductDescription", b =>
                {
                    b.HasOne("Product.Domain.AggregateModel.ProductAggregate.ProductEntity", null)
                        .WithOne("ProductDescription")
                        .HasForeignKey("Product.Domain.AggregateModel.ProductAggregate.ProductDescription", "EntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Product.Domain.AggregateModel.ProductAggregate.ProductRating", null)
                        .WithOne("ProductDescription")
                        .HasForeignKey("Product.Domain.AggregateModel.ProductAggregate.ProductDescription", "ProductRatingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Product.Domain.AggregateModel.ProductAggregate.ProductEntity", b =>
                {
                    b.HasOne("Product.Domain.AggregateModel.ProductAggregate.ProductRating", "ProductRating")
                        .WithMany()
                        .HasForeignKey("F_ProductEntityId");

                    b.HasOne("Product.Domain.AggregateModel.ProductDetailsAggregate.Packaging.LeadTime", null)
                        .WithOne("ProductEntityLeadTime")
                        .HasForeignKey("Product.Domain.AggregateModel.ProductAggregate.ProductEntity", "LeadTimeFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Product.Domain.AggregateModel.ProductAggregate.ProductAmount", null)
                        .WithOne("ProductEntity")
                        .HasForeignKey("Product.Domain.AggregateModel.ProductAggregate.ProductEntity", "ProductAmountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Product.Domain.AggregateModel.ProductCouponAggregate.ProductCouponInfo", "ProductCouponInfo")
                        .WithMany()
                        .HasForeignKey("ProductCouponInfoId");

                    b.HasOne("Product.Domain.AggregateModel.ProductAggregate.ProductDescription", null)
                        .WithOne("ProductEntityAD")
                        .HasForeignKey("Product.Domain.AggregateModel.ProductAggregate.ProductEntity", "ProductDescriptionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Product.Domain.AggregateModel.ProductDiscountAggregate.ProductDiscontInfo", "ProductDiscountInfo")
                        .WithMany()
                        .HasForeignKey("ProductDiscountInfoId");

                    b.HasOne("Product.Domain.AggregateModel.ProductAggregate.ProductRating", null)
                        .WithMany("ProductEntities")
                        .HasForeignKey("ProductRatingFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductCouponInfo");

                    b.Navigation("ProductDiscountInfo");

                    b.Navigation("ProductRating");
                });

            modelBuilder.Entity("Product.Domain.AggregateModel.ProductAggregate.ProductRating", b =>
                {
                    b.HasOne("Product.Domain.AggregateModel.ProductAggregate.ProductDescription", null)
                        .WithOne("ProductRatingTT")
                        .HasForeignKey("Product.Domain.AggregateModel.ProductAggregate.ProductRating", "ProductDescID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Product.Domain.AggregateModel.ProductDetailsAggregate.Packaging.LeadTime", b =>
                {
                    b.HasOne("Product.Domain.AggregateModel.ProductDetailsAggregate.Packaging.LeadTime_EsTime", null)
                        .WithOne("LeadTimePK")
                        .HasForeignKey("Product.Domain.AggregateModel.ProductDetailsAggregate.Packaging.LeadTime", "LeadTime_EsTimeFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Product.Domain.AggregateModel.ProductDetailsAggregate.Packaging.LeadTime_Quantity", null)
                        .WithOne("LeadTimePK2")
                        .HasForeignKey("Product.Domain.AggregateModel.ProductDetailsAggregate.Packaging.LeadTime", "LeadTime_QuantityFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Product.Domain.AggregateModel.ProductAggregate.ProductEntity", null)
                        .WithOne("LeadTime")
                        .HasForeignKey("Product.Domain.AggregateModel.ProductDetailsAggregate.Packaging.LeadTime", "ProductEntityLeadTimeFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Product.Domain.AggregateModel.ProductDetailsAggregate.Packaging.LeadTime_EsTime", b =>
                {
                    b.HasOne("Product.Domain.AggregateModel.ProductDetailsAggregate.Packaging.LeadTime", null)
                        .WithOne("LeadTime_EsTime")
                        .HasForeignKey("Product.Domain.AggregateModel.ProductDetailsAggregate.Packaging.LeadTime_EsTime", "LdTimeFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Product.Domain.AggregateModel.ProductDetailsAggregate.Packaging.LeadTime_Quantity", b =>
                {
                    b.HasOne("Product.Domain.AggregateModel.ProductDetailsAggregate.Packaging.LeadTime", null)
                        .WithOne("LeadTime_Quantity")
                        .HasForeignKey("Product.Domain.AggregateModel.ProductDetailsAggregate.Packaging.LeadTime_Quantity", "LeadTimeFk2")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Product.Domain.AggregateModel.ProductAggregate.ProductAmount", b =>
                {
                    b.Navigation("ProductEntity");
                });

            modelBuilder.Entity("Product.Domain.AggregateModel.ProductAggregate.ProductDescription", b =>
                {
                    b.Navigation("ProductEntityAD");

                    b.Navigation("ProductRatingTT");
                });

            modelBuilder.Entity("Product.Domain.AggregateModel.ProductAggregate.ProductEntity", b =>
                {
                    b.Navigation("LeadTime");

                    b.Navigation("ProductAmount");

                    b.Navigation("ProductDescription")
                        .IsRequired();
                });

            modelBuilder.Entity("Product.Domain.AggregateModel.ProductAggregate.ProductRating", b =>
                {
                    b.Navigation("ProductDescription");

                    b.Navigation("ProductEntities");
                });

            modelBuilder.Entity("Product.Domain.AggregateModel.ProductDetailsAggregate.Packaging.LeadTime", b =>
                {
                    b.Navigation("LeadTime_EsTime");

                    b.Navigation("LeadTime_Quantity");

                    b.Navigation("ProductEntityLeadTime");
                });

            modelBuilder.Entity("Product.Domain.AggregateModel.ProductDetailsAggregate.Packaging.LeadTime_EsTime", b =>
                {
                    b.Navigation("LeadTimePK");
                });

            modelBuilder.Entity("Product.Domain.AggregateModel.ProductDetailsAggregate.Packaging.LeadTime_Quantity", b =>
                {
                    b.Navigation("LeadTimePK2");
                });
#pragma warning restore 612, 618
        }
    }
}
