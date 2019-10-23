using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingApp.Api.Migrations
{
    public partial class fixDateOfBirthSpell : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateOfBrith",
                table: "Users",
                newName: "DateOfBirth");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "Users",
                newName: "DateOfBrith");
        }
    }
}
