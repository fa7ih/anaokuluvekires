using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class migadmincontact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts4",
                columns: table => new
                {
                    AdminContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminReplyReciver = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminReplySender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminReplyTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminReplyBody = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminReplyMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminReplyPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminReplyCreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts4", x => x.AdminContactId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts4");
        }
    }
}
