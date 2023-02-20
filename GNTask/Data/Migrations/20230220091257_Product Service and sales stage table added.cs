using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GNTask.Data.Migrations
{
    public partial class ProductServiceandsalesstagetableadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductService",
                columns: table => new
                {
                    productId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    productUnit = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductService", x => x.productId);
                });

            migrationBuilder.CreateTable(
                name: "SalesStage",
                columns: table => new
                {
                    stageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    salesStageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    stageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    stageWeightage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesStage", x => x.stageId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductService");

            migrationBuilder.DropTable(
                name: "SalesStage");
        }
    }
}
