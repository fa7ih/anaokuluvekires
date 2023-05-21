using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig42 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "About2Status",
                table: "Abouts2");

            migrationBuilder.DropColumn(
                name: "AboutStatus",
                table: "Abouts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "About2Status",
                table: "Abouts2",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AboutStatus",
                table: "Abouts",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
