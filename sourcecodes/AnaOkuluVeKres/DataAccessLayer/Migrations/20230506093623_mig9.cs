using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Informations",
                columns: table => new
                {
                    InformationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InformationAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InformationPhone = table.Column<int>(type: "int", nullable: false),
                    InformationMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InformationStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Informations", x => x.InformationId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Informations");
        }
    }
}
