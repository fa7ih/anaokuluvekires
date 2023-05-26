using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class migdeletetableandcolumanddiagram : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students2_AspNetUsers_AppUserId",
                table: "Students2");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentStatuses_Teachers_TeacherId",
                table: "StudentStatuses");

            migrationBuilder.DropTable(
                name: "AppRoleTeachers");

            migrationBuilder.DropIndex(
                name: "IX_StudentStatuses_TeacherId",
                table: "StudentStatuses");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "StudentStatuses");

            migrationBuilder.AddForeignKey(
                name: "FK_Students2_AspNetUsers_AppUserId",
                table: "Students2",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students2_AspNetUsers_AppUserId",
                table: "Students2");

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "StudentStatuses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AppRoleTeachers",
                columns: table => new
                {
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    AppRoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleTeachers", x => new { x.TeacherId, x.AppRoleId });
                    table.ForeignKey(
                        name: "FK_AppRoleTeachers_AspNetRoles_AppRoleId",
                        column: x => x.AppRoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppRoleTeachers_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentStatuses_TeacherId",
                table: "StudentStatuses",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_AppRoleTeachers_AppRoleId",
                table: "AppRoleTeachers",
                column: "AppRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students2_AspNetUsers_AppUserId",
                table: "Students2",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentStatuses_Teachers_TeacherId",
                table: "StudentStatuses",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
