using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HFT.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class lol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoomID",
                table: "Reservations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "imgURL",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_RoomID",
                table: "Reservations",
                column: "RoomID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Rooms_RoomID",
                table: "Reservations",
                column: "RoomID",
                principalTable: "Rooms",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Rooms_RoomID",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_RoomID",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "RoomID",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "imgURL",
                table: "Reservations");
        }
    }
}
