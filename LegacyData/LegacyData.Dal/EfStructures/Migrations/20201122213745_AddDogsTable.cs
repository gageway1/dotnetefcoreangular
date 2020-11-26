using Microsoft.EntityFrameworkCore.Migrations;

namespace LegacyData.Dal.EfStructures.Migrations
{
    public partial class AddDogsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dogs",
                schema: "LegacyData",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    MiddleInit = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    AgeInYears = table.Column<int>(nullable: false),
                    CheckingAccountAmount = table.Column<decimal>(nullable: false),
                    LocationX = table.Column<float>(nullable: false),
                    LocationY = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dogs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dogs",
                schema: "LegacyData");
        }
    }
}
