using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class removetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students2_StudentStatuses_StudentStatusId",
                table: "Students2");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentStatuses_Students_StudentId",
                table: "StudentStatuses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students2_StudentStatusId",
                table: "Students2");

            migrationBuilder.DropColumn(
                name: "StudentStatusId",
                table: "Students2");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentStatuses_Students2_StudentId",
                table: "StudentStatuses",
                column: "StudentId",
                principalTable: "Students2",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentStatuses_Students2_StudentId",
                table: "StudentStatuses");

            migrationBuilder.AddColumn<int>(
                name: "StudentStatusId",
                table: "Students2",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    EnrollmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentGender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentNo = table.Column<int>(type: "int", nullable: false),
                    StudentSurName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentTc = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students2_StudentStatusId",
                table: "Students2",
                column: "StudentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_AppUserId",
                table: "Students",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students2_StudentStatuses_StudentStatusId",
                table: "Students2",
                column: "StudentStatusId",
                principalTable: "StudentStatuses",
                principalColumn: "StudentStatusId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentStatuses_Students_StudentId",
                table: "StudentStatuses",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
