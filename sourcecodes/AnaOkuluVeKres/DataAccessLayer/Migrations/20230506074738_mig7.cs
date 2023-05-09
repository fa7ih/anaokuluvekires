using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TestimonialImageStatsu",
                table: "Testimonials",
                newName: "TestimonialImageStatus");

            migrationBuilder.AddColumn<bool>(
                name: "About2Status",
                table: "Abouts2",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "About2Status",
                table: "Abouts2");

            migrationBuilder.RenameColumn(
                name: "TestimonialImageStatus",
                table: "Testimonials",
                newName: "TestimonialImageStatsu");
        }
    }
}
