using Microsoft.EntityFrameworkCore.Migrations;

namespace KinoPolis.Data.Migrations
{
    public partial class ChangeCinemaAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adress",
                table: "Cinemas");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Cinemas",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Cinemas");

            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "Cinemas",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
