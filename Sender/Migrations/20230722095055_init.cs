using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sender.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "consignors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NIP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    priceNetto = table.Column<double>(type: "float", nullable: false),
                    priceBrutto = table.Column<double>(type: "float", nullable: false),
                    VatTax = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_consignors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTimeCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatadateOfReceipt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CommissionBrutto = table.Column<double>(type: "float", nullable: false),
                    CommissionNetto = table.Column<double>(type: "float", nullable: false),
                    VatTax = table.Column<double>(type: "float", nullable: false),
                    NIP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "boxes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PosGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Consignor = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateTimeCreateBox = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTimeUpdateBox = table.Column<DateTime>(type: "datetime2", nullable: false),
                    weight = table.Column<double>(type: "float", nullable: false),
                    ConsignorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PosId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_boxes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_boxes_Pos_PosId",
                        column: x => x.PosId,
                        principalTable: "Pos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_boxes_consignors_ConsignorId",
                        column: x => x.ConsignorId,
                        principalTable: "consignors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_boxes_customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "customers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_boxes_ConsignorId",
                table: "boxes",
                column: "ConsignorId");

            migrationBuilder.CreateIndex(
                name: "IX_boxes_CustomerId",
                table: "boxes",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_boxes_PosId",
                table: "boxes",
                column: "PosId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "boxes");

            migrationBuilder.DropTable(
                name: "Pos");

            migrationBuilder.DropTable(
                name: "consignors");

            migrationBuilder.DropTable(
                name: "customers");
        }
    }
}
