using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GNTask.Data.Migrations
{
    public partial class addingtargetmasterandtargetdetailstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "UserInformation");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "UserInformation",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
