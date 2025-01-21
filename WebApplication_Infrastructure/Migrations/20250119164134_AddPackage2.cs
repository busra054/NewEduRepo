using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddPackage2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Packages",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 1, "TYT genel tüm dersler temelden gelişmişe adım adım Eğitim", "TYT-Eğitimi Full Paket", 14000.0m });

            migrationBuilder.InsertData(
                table: "Packages",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 2, "AYT temelden gelişmişe Matematik ,Fizik, Kimya, Biyoloji Dersleri Eğitimi", "AYT-Sayısal Eğitimi Full Paket", 20000.00m }); 

            migrationBuilder.InsertData(
                table: "Packages",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 3, "AYT temelden gelişmişe Matematik ,Tarih, Coğrafya, Edebiyat Dersleri eğitimi", "AYT-Eşit Ağırlık Eğitimi", 14000.0m });

            migrationBuilder.InsertData(
                table: "Packages",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 4, "KPSS temelden gelişmişe full hazırlık paketi dersleri", "KPSS Kapsamlı Eğitimi", 18000.0m }); 

            migrationBuilder.InsertData(
                table: "Packages",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[] { 5, "DGS temelden gelişmişe full hazırlık paketi dersleri", "DGS Kapsamlı Eğitimi", 13000.0m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
