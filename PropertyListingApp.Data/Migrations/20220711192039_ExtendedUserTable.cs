using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PropertyListingApp.Data.Migrations
{
    public partial class ExtendedUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApiUserId",
                table: "PropertyListings",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyListings_ApiUserId",
                table: "PropertyListings",
                column: "ApiUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyListings_AspNetUsers_ApiUserId",
                table: "PropertyListings",
                column: "ApiUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyListings_AspNetUsers_ApiUserId",
                table: "PropertyListings");

            migrationBuilder.DropIndex(
                name: "IX_PropertyListings_ApiUserId",
                table: "PropertyListings");

            migrationBuilder.DropColumn(
                name: "ApiUserId",
                table: "PropertyListings");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");
        }
    }
}
