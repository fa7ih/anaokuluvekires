using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class migaddtablecontact2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts2",
                columns: table => new
                {
                    Contact2Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contact2Reciver = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact2Sender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact2Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact2Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact2Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact2Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts2", x => x.Contact2Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts2");
        }
    }
}
