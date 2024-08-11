using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HFT.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedRoommTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomID", "Cena", "LongDescription", "Name", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 300.0, "Velika soba za 6 ljudi ima 2 spalnici 3 kopalnice in raztegljivo sofo z velikim dnevnim prostorom in balkonom ki ima pogled na morje", "Velika soba", "Velika soba za 6 ljudi s pogledom na morje!" },
                    { 2, 300.0, "Velika soba za 6 ljudi ima 2 spalnici 3 kopalnice in raztegljivo sofo z velikim dnevnim prostorom in balkonom ki ima pogled na morje", "Velika soba2", "Velika soba za 6 ljudi s pogledom na morje!" },
                    { 3, 150.0, "Velika soba za 6 ljudi ima 2 spalnici 3 kopalnice in raztegljivo sofo z velikim dnevnim prostorom in balkonom ki ima pogled na morje", "Majhna soba", "Majhna soba za 3 ljudi s pogledom na morje!" },
                    { 4, 150.0, "Velika soba za 6 ljudi ima 2 spalnici 3 kopalnice in raztegljivo sofo z velikim dnevnim prostorom in balkonom ki ima pogled na morje", "Majhna soba2", "Majhna soba za 3 ljudi s pogledom na morje!" },
                    { 5, 500.0, "Penthouse za 2 ima spalnico s svojim balkonom in televizijo in 2 kopalnice ter velik dnevni prostor z vhodom na teraso. Ima še prostor za pisarno.", "Penthouse", "Penthouse za 2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 5);
        }
    }
}
