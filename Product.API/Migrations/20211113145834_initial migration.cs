using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Product.API.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductCoupon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Coupon = table.Column<int>(type: "integer", nullable: false),
                    CouponExpiryDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CouponStartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CouponValidityPeriod = table.Column<int>(type: "integer", nullable: false),
                    IsCouponavaliable = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCoupon", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductDiscount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DiscountExpiryDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DiscontStartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Discount = table.Column<int>(type: "integer", nullable: false),
                    DiscountValidityPeriod = table.Column<int>(type: "integer", nullable: false),
                    IsDiscountavaliable = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDiscount", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeadTimeExtimates",
                columns: table => new
                {
                    LeadId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LessThanTenDays = table.Column<int>(type: "integer", maxLength: 16, nullable: false),
                    ZeroToTenDays = table.Column<int>(type: "integer", nullable: false),
                    TenToTwentyDays = table.Column<int>(type: "integer", nullable: false),
                    TwentyToFiftyDays = table.Column<int>(type: "integer", nullable: false),
                    FiftyToHundredDays = table.Column<int>(type: "integer", nullable: false),
                    GreaterThan1000Days = table.Column<int>(type: "integer", maxLength: 16, nullable: false),
                    LdTimeFk = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadTimeExtimates", x => x.LeadId);
                });

            migrationBuilder.CreateTable(
                name: "LeadTimeQuantity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LessThanTen = table.Column<int>(type: "integer", maxLength: 400, nullable: false),
                    ZeroToTen = table.Column<int>(type: "integer", maxLength: 400, nullable: false),
                    TenToTwenty = table.Column<int>(type: "integer", maxLength: 400, nullable: false),
                    TwentyToFifty = table.Column<int>(type: "integer", maxLength: 400, nullable: false),
                    FiftyToHundred = table.Column<int>(type: "integer", maxLength: 400, nullable: false),
                    GreaterThan1000 = table.Column<int>(type: "integer", maxLength: 400, nullable: false),
                    LeadTimeFk2 = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadTimeQuantity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeadTime",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PackageDetails = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Weight = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: false),
                    Port = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: false),
                    LeadTime_EsTimeFk = table.Column<int>(type: "integer", nullable: false),
                    LeadTime_QuantityFk = table.Column<int>(type: "integer", nullable: false),
                    ProductEntityLeadTimeFK = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeadTime", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeadTime_LeadTimeExtimates_LeadTime_EsTimeFk",
                        column: x => x.LeadTime_EsTimeFk,
                        principalTable: "LeadTimeExtimates",
                        principalColumn: "LeadId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LeadTime_LeadTimeQuantity_LeadTime_QuantityFk",
                        column: x => x.LeadTime_QuantityFk,
                        principalTable: "LeadTimeQuantity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductAmounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductDiscount = table.Column<int>(type: "integer", maxLength: 16, nullable: false),
                    GetCoupon = table.Column<bool>(type: "boolean", nullable: false),
                    ProductEntityId = table.Column<int>(type: "integer", nullable: false),
                    CouponExpiryDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ProductPrice = table.Column<int>(type: "integer", maxLength: 16, nullable: false),
                    MinimunPrice = table.Column<int>(type: "integer", nullable: false),
                    MaximumPrice = table.Column<int>(type: "integer", nullable: false),
                    ProductOnSale = table.Column<int>(type: "integer", nullable: false),
                    FreeShiping = table.Column<int>(type: "integer", nullable: false),
                    IsNegotiable = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAmounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductRating",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Five = table.Column<int>(type: "integer", maxLength: 25, nullable: false),
                    Four = table.Column<int>(type: "integer", maxLength: 25, nullable: false),
                    Three = table.Column<int>(type: "integer", maxLength: 25, nullable: false),
                    Two = table.Column<int>(type: "integer", maxLength: 25, nullable: false),
                    One = table.Column<int>(type: "integer", maxLength: 25, nullable: false),
                    ProductDescID = table.Column<int>(type: "integer", nullable: false),
                    F_ProductEntityId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductRating", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductDescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    StoreName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    AmountBought = table.Column<int>(type: "integer", maxLength: 100, nullable: false),
                    ProductRatingId = table.Column<int>(type: "integer", nullable: false),
                    EntityId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDescriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductDescriptions_ProductRating_ProductRatingId",
                        column: x => x.ProductRatingId,
                        principalTable: "ProductRating",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ProductDescriptionID = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    ProductAmountID = table.Column<int>(type: "integer", nullable: false),
                    F_ProductEntityId = table.Column<int>(type: "integer", nullable: true),
                    ProductRatingFK = table.Column<int>(type: "integer", nullable: false),
                    LeadTimeFK = table.Column<int>(type: "integer", nullable: false),
                    ProductCouponInfoId = table.Column<int>(type: "integer", nullable: true),
                    Coupon = table.Column<int>(type: "integer", nullable: false),
                    ProductDiscountInfoId = table.Column<int>(type: "integer", nullable: true),
                    Discount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_LeadTime_LeadTimeFK",
                        column: x => x.LeadTimeFK,
                        principalTable: "LeadTime",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ProductAmounts_ProductAmountID",
                        column: x => x.ProductAmountID,
                        principalTable: "ProductAmounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ProductCoupon_ProductCouponInfoId",
                        column: x => x.ProductCouponInfoId,
                        principalTable: "ProductCoupon",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_ProductDescriptions_ProductDescriptionID",
                        column: x => x.ProductDescriptionID,
                        principalTable: "ProductDescriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ProductDiscount_ProductDiscountInfoId",
                        column: x => x.ProductDiscountInfoId,
                        principalTable: "ProductDiscount",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_ProductRating_F_ProductEntityId",
                        column: x => x.F_ProductEntityId,
                        principalTable: "ProductRating",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_ProductRating_ProductRatingFK",
                        column: x => x.ProductRatingFK,
                        principalTable: "ProductRating",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LeadTime_LeadTime_EsTimeFk",
                table: "LeadTime",
                column: "LeadTime_EsTimeFk",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LeadTime_LeadTime_QuantityFk",
                table: "LeadTime",
                column: "LeadTime_QuantityFk",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LeadTime_ProductEntityLeadTimeFK",
                table: "LeadTime",
                column: "ProductEntityLeadTimeFK",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LeadTimeExtimates_LdTimeFk",
                table: "LeadTimeExtimates",
                column: "LdTimeFk",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LeadTimeQuantity_LeadTimeFk2",
                table: "LeadTimeQuantity",
                column: "LeadTimeFk2",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductAmounts_ProductEntityId",
                table: "ProductAmounts",
                column: "ProductEntityId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductDescriptions_EntityId",
                table: "ProductDescriptions",
                column: "EntityId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductDescriptions_ProductRatingId",
                table: "ProductDescriptions",
                column: "ProductRatingId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductRating_ProductDescID",
                table: "ProductRating",
                column: "ProductDescID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_F_ProductEntityId",
                table: "Products",
                column: "F_ProductEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_LeadTimeFK",
                table: "Products",
                column: "LeadTimeFK",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductAmountID",
                table: "Products",
                column: "ProductAmountID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCouponInfoId",
                table: "Products",
                column: "ProductCouponInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductDescriptionID",
                table: "Products",
                column: "ProductDescriptionID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductDiscountInfoId",
                table: "Products",
                column: "ProductDiscountInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductRatingFK",
                table: "Products",
                column: "ProductRatingFK");

            migrationBuilder.AddForeignKey(
                name: "FK_LeadTimeExtimates_LeadTime_LdTimeFk",
                table: "LeadTimeExtimates",
                column: "LdTimeFk",
                principalTable: "LeadTime",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LeadTimeQuantity_LeadTime_LeadTimeFk2",
                table: "LeadTimeQuantity",
                column: "LeadTimeFk2",
                principalTable: "LeadTime",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LeadTime_Products_ProductEntityLeadTimeFK",
                table: "LeadTime",
                column: "ProductEntityLeadTimeFK",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductAmounts_Products_ProductEntityId",
                table: "ProductAmounts",
                column: "ProductEntityId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductRating_ProductDescriptions_ProductDescID",
                table: "ProductRating",
                column: "ProductDescID",
                principalTable: "ProductDescriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDescriptions_Products_EntityId",
                table: "ProductDescriptions",
                column: "EntityId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeadTime_LeadTimeExtimates_LeadTime_EsTimeFk",
                table: "LeadTime");

            migrationBuilder.DropForeignKey(
                name: "FK_LeadTime_LeadTimeQuantity_LeadTime_QuantityFk",
                table: "LeadTime");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_LeadTime_LeadTimeFK",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductAmounts_ProductAmountID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductDescriptions_Products_EntityId",
                table: "ProductDescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductDescriptions_ProductRating_ProductRatingId",
                table: "ProductDescriptions");

            migrationBuilder.DropTable(
                name: "LeadTimeExtimates");

            migrationBuilder.DropTable(
                name: "LeadTimeQuantity");

            migrationBuilder.DropTable(
                name: "LeadTime");

            migrationBuilder.DropTable(
                name: "ProductAmounts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ProductCoupon");

            migrationBuilder.DropTable(
                name: "ProductDiscount");

            migrationBuilder.DropTable(
                name: "ProductRating");

            migrationBuilder.DropTable(
                name: "ProductDescriptions");
        }
    }
}
