using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addLanguagePackages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Packages",
                columns: new[] { "Id", "Description", "Name", "Price", "UserId" },
                values: new object[,]
                {
                    { 6, "İngilizce temelden gelişmişe okuma,yazma,konuşma ve dinleme becerileri geliştirme dersleri", "İngilizce A1-A2 Temel Seviye Eğitim", 15000.0m, null },
                    { 7, "İspanyolca temelden gelişmişe okuma,yazma,konuşma ve dinleme becerileri geliştirme dersleri", "İspanyolca A1-A2 Temel Seviye Eğitim", 12000.0m, null },
                    { 8, "Korece temelden gelişmişe okuma,yazma,konuşma ve dinleme becerileri geliştirme dersleri", "Korece A1-A2 Temel Seviye Eğitim", 16000.0m, null },
                    { 9, "Almanca temelden gelişmişe okuma,yazma,konuşma ve dinleme becerileri geliştirme dersleri", "Almanca A1-B2 Temelden Orta Düzeye(İntermediate) Seviye Eğitim", 17000.0m, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
