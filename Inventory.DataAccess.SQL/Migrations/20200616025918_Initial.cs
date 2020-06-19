using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Inventory.DataAccess.SQL.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HardwareInventory",
                columns: table => new
                {
                    HostName = table.Column<string>(maxLength: 24, nullable: false),
                    HDId = table.Column<string>(nullable: true),
                    ChassisType = table.Column<int>(nullable: false),
                    Location = table.Column<int>(nullable: false),
                    OperatingSystem = table.Column<string>(nullable: true),
                    IPAddress = table.Column<string>(nullable: true),
                    MacAddress = table.Column<string>(nullable: true),
                    DHCPServer = table.Column<string>(nullable: true),
                    DNSServer = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    DomainMember = table.Column<bool>(nullable: false),
                    Domain = table.Column<string>(nullable: true),
                    OSVersion = table.Column<string>(nullable: true),
                    SPVersion = table.Column<string>(nullable: true),
                    OSBuild = table.Column<string>(nullable: true),
                    OSInstallDate = table.Column<string>(nullable: true),
                    OSArchitecture = table.Column<string>(nullable: true),
                    LastUpdated = table.Column<string>(nullable: true),
                    LastBootUpTime = table.Column<string>(nullable: true),
                    RemoteDesktop = table.Column<string>(nullable: true),
                    TimeZone = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    RAM_MB = table.Column<string>(nullable: true),
                    Sockets = table.Column<string>(nullable: true),
                    Cores = table.Column<string>(nullable: true),
                    DiskSize_GB = table.Column<string>(nullable: true),
                    Processor = table.Column<string>(nullable: true),
                    SystemType = table.Column<string>(nullable: true),
                    FirmwareVersion = table.Column<string>(nullable: true),
                    Scanned = table.Column<bool>(nullable: false),
                    SerialNumber = table.Column<string>(nullable: true),
                    ScanDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HardwareInventory", x => x.HostName);
                });

            migrationBuilder.CreateTable(
                name: "SoftwareInventory",
                columns: table => new
                {
                    SoftID = table.Column<string>(nullable: false),
                    HostName = table.Column<string>(nullable: true),
                    Program = table.Column<string>(nullable: true),
                    Version = table.Column<string>(nullable: true),
                    Publisher = table.Column<string>(nullable: true),
                    InstallDate = table.Column<string>(nullable: true),
                    InstallSource = table.Column<string>(nullable: true),
                    InstallLocation = table.Column<string>(nullable: true),
                    RegistryKey = table.Column<string>(nullable: true),
                    ScanDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoftwareInventory", x => x.SoftID);
                });

            migrationBuilder.CreateTable(
                name: "SoftwareScan",
                columns: table => new
                {
                    HostName = table.Column<string>(nullable: false),
                    SoftID = table.Column<string>(nullable: true),
                    Scanned = table.Column<bool>(nullable: false),
                    ScanDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoftwareScan", x => x.HostName);
                });

            migrationBuilder.CreateTable(
                name: "WarrantyInformation",
                columns: table => new
                {
                    AssetTag = table.Column<string>(nullable: false),
                    WarrantyID = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    ModelFamily = table.Column<string>(nullable: true),
                    ProductId = table.Column<string>(nullable: true),
                    WarrantyStartDate = table.Column<DateTime>(nullable: false),
                    WarrantyEndDate = table.Column<DateTime>(nullable: false),
                    Checked = table.Column<bool>(nullable: false),
                    ScanDate = table.Column<DateTime>(nullable: false),
                    WarrantyDaysLeft = table.Column<int>(nullable: false),
                    WarrantyMonthsLeft = table.Column<int>(nullable: false),
                    WarrantyYearsLeft = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Memory = table.Column<string>(nullable: true),
                    Storage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarrantyInformation", x => x.AssetTag);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HardwareInventory");

            migrationBuilder.DropTable(
                name: "SoftwareInventory");

            migrationBuilder.DropTable(
                name: "SoftwareScan");

            migrationBuilder.DropTable(
                name: "WarrantyInformation");
        }
    }
}
