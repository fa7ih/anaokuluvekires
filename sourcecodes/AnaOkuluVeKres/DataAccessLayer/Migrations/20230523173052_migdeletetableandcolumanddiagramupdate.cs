using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class migdeletetableandcolumanddiagramupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_StudentStatuses_StudentId",
                table: "StudentStatuses");

            migrationBuilder.CreateIndex(
                name: "IX_StudentStatuses_StudentId",
                table: "StudentStatuses",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_StudentStatuses_StudentId",
                table: "StudentStatuses");

            migrationBuilder.CreateIndex(
                name: "IX_StudentStatuses_StudentId",
                table: "StudentStatuses",
                column: "StudentId",
                unique: true);
        }
    }
}
