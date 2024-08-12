using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HFT.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class renameIDS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RoomID",
                table: "Rooms",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "ReservationID",
                table: "Reservations",
                newName: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Rooms",
                newName: "RoomID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Reservations",
                newName: "ReservationID");
        }
    }
}
