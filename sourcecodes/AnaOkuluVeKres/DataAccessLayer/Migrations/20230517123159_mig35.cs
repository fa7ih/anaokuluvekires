using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig35 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_AdminStudentClasses_AdminStudentClassesId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Classes_StudentClassesClassesId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "AdminStudentClasses");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_Students_AdminStudentClassesId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_StudentClassesClassesId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "AdminStudentClassesId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentClassesClassesId",
                table: "Students");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdminStudentClassesId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentClassesClassesId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AdminStudentClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassesName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminStudentClasses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    ClassesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassesName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.ClassesId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_AdminStudentClassesId",
                table: "Students",
                column: "AdminStudentClassesId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentClassesClassesId",
                table: "Students",
                column: "StudentClassesClassesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_AdminStudentClasses_AdminStudentClassesId",
                table: "Students",
                column: "AdminStudentClassesId",
                principalTable: "AdminStudentClasses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Classes_StudentClassesClassesId",
                table: "Students",
                column: "StudentClassesClassesId",
                principalTable: "Classes",
                principalColumn: "ClassesId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
