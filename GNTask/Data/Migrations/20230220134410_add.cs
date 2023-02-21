using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GNTask.Data.Migrations
{
    public partial class add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "salesStage",
                table: "TargetProductService");

            migrationBuilder.DropColumn(
                name: "selectProduct",
                table: "TargetProductService");

            migrationBuilder.AddColumn<int>(
                name: "serviveId",
                table: "TargetProductService",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "stageId",
                table: "TargetProductService",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "serviveId",
                table: "TargetProductService");

            migrationBuilder.DropColumn(
                name: "stageId",
                table: "TargetProductService");

            migrationBuilder.AddColumn<string>(
                name: "salesStage",
                table: "TargetProductService",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "selectProduct",
                table: "TargetProductService",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
