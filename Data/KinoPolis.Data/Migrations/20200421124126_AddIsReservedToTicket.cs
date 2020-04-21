using Microsoft.EntityFrameworkCore.Migrations;

namespace KinoPolis.Data.Migrations
{
    public partial class AddIsReservedToTicket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsReserved",
                table: "Tickets",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsReserved",
                table: "Tickets");
        }
    }
}
