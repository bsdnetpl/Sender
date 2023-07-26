using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sender.Migrations
{
    /// <inheritdoc />
    public partial class addReturn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateTimeReturnBox",
                table: "boxes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
            name: "ReturnBox",
            table: "boxes",
            type: "bit",
            nullable: false,
            defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTimeReturnBox",
                table: "boxes");

            migrationBuilder.DropColumn(
               name: "ReturnBox",
               table: "boxes");
        }
    }
}
