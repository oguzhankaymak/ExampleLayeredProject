using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class SeedProductsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "ProductName", "QuantityPerUnit", "UnitPrice", "UnitsInStock" },
                values: new object[,]
                {
                    { 1, 1, "Dell Bilgisayar", "PC", 4500m, (short)100 },
                    { 2, 1, "Casper Bilgisayar", "PC", 2000m, (short)100 },
                    { 3, 1, "Huaweı Akıllı Telefon", "Telefon", 2200m, (short)100 },
                    { 4, 2, "Sütaş Yoğurt", "1000ml yoğurt", 10m, (short)10000 },
                    { 5, 3, "Fanta", "2,5 lt kola", 5m, (short)10000 },
                    { 6, 3, "Coca Cola", "2,5 lt kola", 5m, (short)10000 },
                    { 7, 4, "Poğaça", "1 adet poğaça", 2m, (short)10000 },
                    { 8, 4, "Simit", "1 adet simit", 2m, (short)10000 },
                    { 9, 4, "Kıymalı Pide", "1 adet kıymalı pide", 12m, (short)10000 },
                    { 10, 4, "Kurabiye", "1 kg kurabiye", 18m, (short)10000 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Password", "Username" },
                values: new object[] { 1, "123", "oguzhankaymak" });
        }
    }
}
