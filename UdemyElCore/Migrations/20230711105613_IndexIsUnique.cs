using Microsoft.EntityFrameworkCore.Migrations;

namespace UdemyElCore.Migrations
{
    public partial class IndexIsUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Products_product_name",
                table: "Products",
                column: "product_name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_product_name",
                table: "Products");
        }
    }
}
