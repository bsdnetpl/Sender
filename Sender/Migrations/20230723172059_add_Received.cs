using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sender.Migrations
{
    /// <inheritdoc />
    public partial class add_Received : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Received",
                table: "boxes",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Received",
                table: "boxes");
        }
    }
}
