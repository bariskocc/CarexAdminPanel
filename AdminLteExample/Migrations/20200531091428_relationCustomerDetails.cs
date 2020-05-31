using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminLteExample.Migrations
{
    public partial class relationCustomerDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Customer",
                newName: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerDetails_CustomerId",
                table: "CustomerDetails",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerDetails_Customer_CustomerId",
                table: "CustomerDetails",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerDetails_Customer_CustomerId",
                table: "CustomerDetails");

            migrationBuilder.DropIndex(
                name: "IX_CustomerDetails_CustomerId",
                table: "CustomerDetails");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Customer",
                newName: "Id");
        }
    }
}
