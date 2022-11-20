using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantWebApp.Migrations
{
    public partial class UpdatedReservation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "Reservation",
                newName: "Date");

            migrationBuilder.AddColumn<string>(
                name: "Time",
                table: "Reservation",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Time",
                table: "Reservation");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Reservation",
                newName: "DateTime");
        }
    }
}
