using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminLteExample.Migrations
{
    public partial class brands3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "CarBrands",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "CarBrands");
        }
    }
}
