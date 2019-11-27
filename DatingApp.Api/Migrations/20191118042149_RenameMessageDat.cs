using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingApp.Api.Migrations
{
    public partial class RenameMessageDat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MessageDate",
                table: "Messages",
                newName: "MessageSent");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MessageSent",
                table: "Messages",
                newName: "MessageDate");
        }
    }
}
