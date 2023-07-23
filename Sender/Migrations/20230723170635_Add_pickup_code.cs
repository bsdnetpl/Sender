using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sender.Migrations
{
    /// <inheritdoc />
    public partial class Add_pickup_code : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "pickup_code",
                table: "boxes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "pickup_code",
                table: "boxes");
        }
    }
}
