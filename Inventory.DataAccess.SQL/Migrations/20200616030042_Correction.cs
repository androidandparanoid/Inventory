using Microsoft.EntityFrameworkCore.Migrations;

namespace Inventory.DataAccess.SQL.Migrations
{
    public partial class Correction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SoftID",
                table: "SoftwareScan");

            migrationBuilder.AddColumn<string>(
                name: "ScanID",
                table: "SoftwareScan",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ScanID",
                table: "SoftwareScan");

            migrationBuilder.AddColumn<string>(
                name: "SoftID",
                table: "SoftwareScan",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
