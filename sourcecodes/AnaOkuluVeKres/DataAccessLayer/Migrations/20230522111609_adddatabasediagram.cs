using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class adddatabasediagram : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students2_AspNetUsers_AppUserId",
                table: "Students2");

            migrationBuilder.AddForeignKey(
                name: "FK_Students2_AspNetUsers_AppUserId",
                table: "Students2",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students2_AspNetUsers_AppUserId",
                table: "Students2");

            migrationBuilder.AddForeignKey(
                name: "FK_Students2_AspNetUsers_AppUserId",
                table: "Students2",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
