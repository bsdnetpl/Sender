using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sender.Migrations
{
    /// <inheritdoc />
    public partial class changeNameBox : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Consignor",
                table: "boxes",
                newName: "ConsignorGuid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ConsignorGuid",
                table: "boxes",
                newName: "Consignor");
        }
    }
}
