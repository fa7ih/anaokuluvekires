using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig34 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_AdminStudentClasses_AdminStudentClassesId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Classes_ClassId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_ClassId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "Students");

            migrationBuilder.AlterColumn<int>(
                name: "AdminStudentClassesId",
                table: "Students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "StudentClassesClassesId",
                table: "Students",
                type: "int",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_AdminStudentClasses_AdminStudentClassesId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Classes_StudentClassesClassesId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_StudentClassesClassesId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentClassesClassesId",
                table: "Students");

            migrationBuilder.AlterColumn<int>(
                name: "AdminStudentClassesId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassId",
                table: "Students",
                column: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_AdminStudentClasses_AdminStudentClassesId",
                table: "Students",
                column: "AdminStudentClassesId",
                principalTable: "AdminStudentClasses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Classes_ClassId",
                table: "Students",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "ClassesId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
