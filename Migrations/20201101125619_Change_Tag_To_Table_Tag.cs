using Microsoft.EntityFrameworkCore.Migrations;

namespace Attribute.Migrations
{
    public partial class Change_Tag_To_Table_Tag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_vendors_VendorId",
                table: "Tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tags",
                table: "Tags");

            migrationBuilder.RenameTable(
                name: "Tags",
                newName: "Table_Tag");

            migrationBuilder.RenameIndex(
                name: "IX_Tags_VendorId",
                table: "Table_Tag",
                newName: "IX_Table_Tag_VendorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Table_Tag",
                table: "Table_Tag",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Table_Tag_vendors_VendorId",
                table: "Table_Tag",
                column: "VendorId",
                principalTable: "vendors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Table_Tag_vendors_VendorId",
                table: "Table_Tag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Table_Tag",
                table: "Table_Tag");

            migrationBuilder.RenameTable(
                name: "Table_Tag",
                newName: "Tags");

            migrationBuilder.RenameIndex(
                name: "IX_Table_Tag_VendorId",
                table: "Tags",
                newName: "IX_Tags_VendorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tags",
                table: "Tags",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_vendors_VendorId",
                table: "Tags",
                column: "VendorId",
                principalTable: "vendors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
