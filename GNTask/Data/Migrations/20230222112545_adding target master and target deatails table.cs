using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GNTask.Data.Migrations
{
    public partial class addingtargetmasterandtargetdeatailstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "userName",
                table: "UserInformation",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "UserInformation",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<double>(
                name: "stageWeightage",
                table: "SalesStage",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Sales_Target_Details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    serviceProductId = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    targetVolume = table.Column<int>(type: "int", nullable: false),
                    targetAmount = table.Column<int>(type: "int", nullable: false),
                    salesStageId = table.Column<int>(type: "int", nullable: false),
                    stageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    stageWeightage = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales_Target_Details", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sales_Target_Master",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userId = table.Column<int>(type: "int", nullable: false),
                    fromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    toDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales_Target_Master", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sales_Target_Details");

            migrationBuilder.DropTable(
                name: "Sales_Target_Master");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "UserInformation");

            migrationBuilder.AlterColumn<string>(
                name: "userName",
                table: "UserInformation",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "stageWeightage",
                table: "SalesStage",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
