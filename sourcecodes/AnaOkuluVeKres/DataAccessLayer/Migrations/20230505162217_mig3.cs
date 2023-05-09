using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AboutDescription2",
                table: "Abouts",
                newName: "AboutSubDescription3");

            migrationBuilder.AddColumn<string>(
                name: "AboutSubDescription1",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AboutSubDescription2",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Abouts2",
                columns: table => new
                {
                    About2Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    About2Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts2", x => x.About2Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts2");

            migrationBuilder.DropColumn(
                name: "AboutSubDescription1",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "AboutSubDescription2",
                table: "Abouts");

            migrationBuilder.RenameColumn(
                name: "AboutSubDescription3",
                table: "Abouts",
                newName: "AboutDescription2");
        }
    }
}
