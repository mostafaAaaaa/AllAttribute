using Microsoft.EntityFrameworkCore.Migrations;

namespace Attribute.Migrations
{
    public partial class add_foreignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "vendors",
                newName: "Phone");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "vendors",
                newName: "PhoneNumber");
        }
    }
}
