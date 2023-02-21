using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GNTask.Data.Migrations
{
    public partial class addtargetproductservice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TargetProductService",
                columns: table => new
                {
                    productId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    selectProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    targetVolume = table.Column<int>(type: "int", nullable: false),
                    targetAmount = table.Column<int>(type: "int", nullable: false),
                    salesStage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    stageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    stageWeightage = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TargetProductService", x => x.productId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TargetProductService");
        }
    }
}
