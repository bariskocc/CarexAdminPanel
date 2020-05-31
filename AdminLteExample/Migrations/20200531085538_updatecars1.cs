using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminLteExample.Migrations
{
    public partial class updatecars1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ModelName",
                table: "Cars",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Cars",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BrandName",
                table: "Cars",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ModelName",
                table: "Cars",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Cars",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "BrandName",
                table: "Cars",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 150);
        }
    }
}
