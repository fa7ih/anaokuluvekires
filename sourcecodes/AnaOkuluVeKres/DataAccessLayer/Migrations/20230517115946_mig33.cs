using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig33 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdminStudentClassesId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AdminStudentClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassesName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminStudentClasses", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_AdminStudentClassesId",
                table: "Students",
                column: "AdminStudentClassesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_AdminStudentClasses_AdminStudentClassesId",
                table: "Students",
                column: "AdminStudentClassesId",
                principalTable: "AdminStudentClasses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_AdminStudentClasses_AdminStudentClassesId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "AdminStudentClasses");

            migrationBuilder.DropIndex(
                name: "IX_Students_AdminStudentClassesId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "AdminStudentClassesId",
                table: "Students");
        }
    }
}
