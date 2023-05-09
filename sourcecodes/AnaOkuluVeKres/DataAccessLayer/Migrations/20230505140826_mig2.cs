using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    FeatureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeatureHeadTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureTitle1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureTitle2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureTitle3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureTitle4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureDescription1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureDescription2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureDescription3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureDescription4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.FeatureId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Features");
        }
    }
}
