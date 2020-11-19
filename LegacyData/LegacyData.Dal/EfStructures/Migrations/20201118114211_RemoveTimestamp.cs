using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LegacyData.Dal.EfStructures.Migrations
{
    public partial class RemoveTimestamp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeStamp",
                schema: "LegacyData",
                table: "TestNewClass");

            migrationBuilder.DropColumn(
                name: "TimeStamp",
                schema: "LegacyData",
                table: "CP01VTAInactiveAllData");

            migrationBuilder.DropColumn(
                name: "TimeStamp",
                schema: "LegacyData",
                table: "CP01PassportInactiveAllData");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "TimeStamp",
                schema: "LegacyData",
                table: "TestNewClass",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "TimeStamp",
                schema: "LegacyData",
                table: "CP01VTAInactiveAllData",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "TimeStamp",
                schema: "LegacyData",
                table: "CP01PassportInactiveAllData",
                type: "rowversion",
                rowVersion: true,
                nullable: true);
        }
    }
}
