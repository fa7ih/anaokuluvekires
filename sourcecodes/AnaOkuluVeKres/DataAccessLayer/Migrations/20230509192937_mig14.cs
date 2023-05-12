using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StudentAge",
                table: "Students",
                newName: "StudentTc");

            migrationBuilder.AddColumn<DateTime>(
                name: "StudentBirth",
                table: "Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentBirth",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "StudentTc",
                table: "Students",
                newName: "StudentAge");
        }
    }
}
