using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class migrationaddcolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts3",
                columns: table => new
                {
                    Contact3Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contact2ReplyReciver = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact2ReplySender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact2ReplyTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact2ReplyBody = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact2ReplyMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact2ReplyPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact2ReplyCreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts3", x => x.Contact3Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts3");
        }
    }
}
