using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kuari.ShopApplication.Repository.Migrations
{
    public partial class rlsTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductBrands_Products_ProductId",
                table: "ProductBrands");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTypes_Products_ProductId",
                table: "ProductTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Productss");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Productss",
                table: "Productss",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductBrands_Productss_ProductId",
                table: "ProductBrands",
                column: "ProductId",
                principalTable: "Productss",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTypes_Productss_ProductId",
                table: "ProductTypes",
                column: "ProductId",
                principalTable: "Productss",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductBrands_Productss_ProductId",
                table: "ProductBrands");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductTypes_Productss_ProductId",
                table: "ProductTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Productss",
                table: "Productss");

            migrationBuilder.RenameTable(
                name: "Productss",
                newName: "Products");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductBrands_Products_ProductId",
                table: "ProductBrands",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductTypes_Products_ProductId",
                table: "ProductTypes",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
