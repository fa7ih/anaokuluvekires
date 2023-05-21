using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig43 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StudentStatusTeachNotes",
                table: "StudentStatuses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "StudentStatusInClassSituation",
                table: "StudentStatuses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "StudentStatuses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentStatusDance",
                table: "StudentStatuses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentStatusMusic",
                table: "StudentStatuses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentStatusSport",
                table: "StudentStatuses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "StudentStatuses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_StudentStatuses_StudentId",
                table: "StudentStatuses",
                column: "StudentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentStatuses_TeacherId",
                table: "StudentStatuses",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentStatuses_Students_StudentId",
                table: "StudentStatuses",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentStatuses_Teachers_TeacherId",
                table: "StudentStatuses",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentStatuses_Students_StudentId",
                table: "StudentStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentStatuses_Teachers_TeacherId",
                table: "StudentStatuses");

            migrationBuilder.DropIndex(
                name: "IX_StudentStatuses_StudentId",
                table: "StudentStatuses");

            migrationBuilder.DropIndex(
                name: "IX_StudentStatuses_TeacherId",
                table: "StudentStatuses");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "StudentStatuses");

            migrationBuilder.DropColumn(
                name: "StudentStatusDance",
                table: "StudentStatuses");

            migrationBuilder.DropColumn(
                name: "StudentStatusMusic",
                table: "StudentStatuses");

            migrationBuilder.DropColumn(
                name: "StudentStatusSport",
                table: "StudentStatuses");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "StudentStatuses");

            migrationBuilder.AlterColumn<int>(
                name: "StudentStatusTeachNotes",
                table: "StudentStatuses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StudentStatusInClassSituation",
                table: "StudentStatuses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
