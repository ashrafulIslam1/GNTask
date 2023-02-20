using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GNTask.Data.Migrations
{
    public partial class updatesalesstageweightagestringtoint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "stageWeightage",
                table: "SalesStage",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "stageWeightage",
                table: "SalesStage",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
