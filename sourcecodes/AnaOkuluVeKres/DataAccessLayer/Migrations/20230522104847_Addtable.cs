using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class Addtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students2",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentSurName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentNo = table.Column<int>(type: "int", nullable: false),
                    StudentTc = table.Column<long>(type: "bigint", nullable: false),
                    StudentBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentGender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnrollmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    StudentStatusId = table.Column<int>(type: "int", nullable: true)
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
                    table.ForeignKey(
                        name: "FK_Students2_StudentStatuses_StudentStatusId",
                        column: x => x.StudentStatusId,
                        principalTable: "StudentStatuses",
                        principalColumn: "StudentStatusId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students2_AppUserId",
                table: "Students2",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Students2_StudentStatusId",
                table: "Students2",
                column: "StudentStatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students2");
        }
    }
}
