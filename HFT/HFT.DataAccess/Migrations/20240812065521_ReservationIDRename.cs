using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HFT.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ReservationIDRename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Reservations",
                newName: "ReservationID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReservationID",
                table: "Reservations",
                newName: "Id");
        }
    }
}
