using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students2");

            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Students_AppUserId",
                table: "Students",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_AspNetUsers_AppUserId",
                table: "Students",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_AspNetUsers_AppUserId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_AppUserId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "Students2",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    StudentBranch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentGender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentNo = table.Column<int>(type: "int", nullable: false),
                    StudentStatus = table.Column<bool>(type: "bit", nullable: false),
                    StudentSurName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students2", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students2_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students2_AppUserId",
                table: "Students2",
                column: "AppUserId");
        }
    }
}
