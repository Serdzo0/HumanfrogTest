using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HFT.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addImageURLAttributeToRoom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 1,
                column: "ImageURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 2,
                column: "ImageURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 3,
                column: "ImageURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 4,
                column: "ImageURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "ID",
                keyValue: 5,
                column: "ImageURL",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Rooms");
        }
    }
}
