using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConradEnergy.EFCore.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ElectricityDemands",
                columns: table => new
                {
                    SettlementDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SettlementPeriod = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricityDemands", x => new { x.SettlementDate, x.SettlementPeriod });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ElectricityDemands");
        }
    }
}
