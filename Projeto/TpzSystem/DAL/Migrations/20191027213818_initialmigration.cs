using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_client",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ExcludedAt = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PrimaryTelephone = table.Column<string>(nullable: true),
                    SecondaryTelephone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    ResidentialAddress = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true),
                    HomeNumber = table.Column<string>(nullable: true),
                    Cep = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_client", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ExcludedAt = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    UnitaryPrice = table.Column<decimal>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_order",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ExcludedAt = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    IdClient = table.Column<int>(nullable: true),
                    TotalValue = table.Column<decimal>(nullable: true),
                    Discount = table.Column<decimal>(nullable: true),
                    Status = table.Column<byte>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_order_tb_client_IdClient",
                        column: x => x.IdClient,
                        principalTable: "tb_client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_order_item",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ExcludedAt = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    IdOrder = table.Column<int>(nullable: true),
                    IdProduct = table.Column<int>(nullable: true),
                    OrderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_order_item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_order_item_tb_order_IdOrder",
                        column: x => x.IdOrder,
                        principalTable: "tb_order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tb_order_item_tb_product_IdProduct",
                        column: x => x.IdProduct,
                        principalTable: "tb_product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tb_order_item_tb_order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "tb_order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_order_IdClient",
                table: "tb_order",
                column: "IdClient");

            migrationBuilder.CreateIndex(
                name: "IX_tb_order_item_IdOrder",
                table: "tb_order_item",
                column: "IdOrder");

            migrationBuilder.CreateIndex(
                name: "IX_tb_order_item_IdProduct",
                table: "tb_order_item",
                column: "IdProduct");

            migrationBuilder.CreateIndex(
                name: "IX_tb_order_item_OrderId",
                table: "tb_order_item",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_order_item");

            migrationBuilder.DropTable(
                name: "tb_order");

            migrationBuilder.DropTable(
                name: "tb_product");

            migrationBuilder.DropTable(
                name: "tb_client");
        }
    }
}
