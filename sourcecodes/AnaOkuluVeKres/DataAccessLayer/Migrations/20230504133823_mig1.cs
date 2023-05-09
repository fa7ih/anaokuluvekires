using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    AboutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutImage1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutDescription2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.AboutId);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

            migrationBuilder.CreateTable(
                name: "Newsletters",
                columns: table => new
                {
                    NewsletterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Newsletters", x => x.NewsletterId);
                });

            migrationBuilder.CreateTable(
                name: "Parents",
                columns: table => new
                {
                    ParentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentNameSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parents", x => x.ParentId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentSurName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentNo = table.Column<int>(type: "int", nullable: false),
                    StudentImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentClass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentBranch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "StudentStatuses",
                columns: table => new
                {
                    StudentStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentStatusHealth = table.Column<int>(type: "int", nullable: false),
                    StudentStatusDevelopment = table.Column<int>(type: "int", nullable: false),
                    StudentStatusAdaptation = table.Column<int>(type: "int", nullable: false),
                    StudentStatusInClassSituation = table.Column<int>(type: "int", nullable: false),
                    StudentStatusAlphabet = table.Column<int>(type: "int", nullable: false),
                    StudentStatusMaths = table.Column<int>(type: "int", nullable: false),
                    StudentStatusTeachNotes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentStatuses", x => x.StudentStatusId);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherNameSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeacherUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeacherPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeacherBranch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeacherImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeacherStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.TeacherId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Newsletters");

            migrationBuilder.DropTable(
                name: "Parents");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "StudentStatuses");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
