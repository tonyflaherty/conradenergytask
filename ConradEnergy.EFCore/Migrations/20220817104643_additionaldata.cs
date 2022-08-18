using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConradEnergy.EFCore.Migrations
{
    public partial class additionaldata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BritnedInterconnectorFlow",
                table: "ElectricityDemands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EastWestInterconnectorFlow",
                table: "ElectricityDemands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ElecLinkInterconnectorFlow",
                table: "ElectricityDemands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmbeddedSolarCapacity",
                table: "ElectricityDemands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmbeddedSolarGeneration",
                table: "ElectricityDemands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmbeddedWindCapacity",
                table: "ElectricityDemands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmbeddedWindGeneration",
                table: "ElectricityDemands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EnglandWalesDemand",
                table: "ElectricityDemands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ForecastActualIndicator",
                table: "ElectricityDemands",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "IFA2InterconnectorFlow",
                table: "ElectricityDemands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IFAInterConnectorFlow",
                table: "ElectricityDemands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MoyleInterconnectorFlow",
                table: "ElectricityDemands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NationalDemand",
                table: "ElectricityDemands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NemoInterconnectorFlow",
                table: "ElectricityDemands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NorthSeaLinkInterconnectorFlow",
                table: "ElectricityDemands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PumpStoragePumping",
                table: "ElectricityDemands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ShortTermOperatingReserve",
                table: "ElectricityDemands",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TransmissionSystemDemand",
                table: "ElectricityDemands",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BritnedInterconnectorFlow",
                table: "ElectricityDemands");

            migrationBuilder.DropColumn(
                name: "EastWestInterconnectorFlow",
                table: "ElectricityDemands");

            migrationBuilder.DropColumn(
                name: "ElecLinkInterconnectorFlow",
                table: "ElectricityDemands");

            migrationBuilder.DropColumn(
                name: "EmbeddedSolarCapacity",
                table: "ElectricityDemands");

            migrationBuilder.DropColumn(
                name: "EmbeddedSolarGeneration",
                table: "ElectricityDemands");

            migrationBuilder.DropColumn(
                name: "EmbeddedWindCapacity",
                table: "ElectricityDemands");

            migrationBuilder.DropColumn(
                name: "EmbeddedWindGeneration",
                table: "ElectricityDemands");

            migrationBuilder.DropColumn(
                name: "EnglandWalesDemand",
                table: "ElectricityDemands");

            migrationBuilder.DropColumn(
                name: "ForecastActualIndicator",
                table: "ElectricityDemands");

            migrationBuilder.DropColumn(
                name: "IFA2InterconnectorFlow",
                table: "ElectricityDemands");

            migrationBuilder.DropColumn(
                name: "IFAInterConnectorFlow",
                table: "ElectricityDemands");

            migrationBuilder.DropColumn(
                name: "MoyleInterconnectorFlow",
                table: "ElectricityDemands");

            migrationBuilder.DropColumn(
                name: "NationalDemand",
                table: "ElectricityDemands");

            migrationBuilder.DropColumn(
                name: "NemoInterconnectorFlow",
                table: "ElectricityDemands");

            migrationBuilder.DropColumn(
                name: "NorthSeaLinkInterconnectorFlow",
                table: "ElectricityDemands");

            migrationBuilder.DropColumn(
                name: "PumpStoragePumping",
                table: "ElectricityDemands");

            migrationBuilder.DropColumn(
                name: "ShortTermOperatingReserve",
                table: "ElectricityDemands");

            migrationBuilder.DropColumn(
                name: "TransmissionSystemDemand",
                table: "ElectricityDemands");
        }
    }
}
