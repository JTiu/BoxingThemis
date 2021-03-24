using Microsoft.EntityFrameworkCore.Migrations;

namespace BoxingThemis.Data.Migrations
{
    public partial class Added_PKs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BoxingMatches",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FighterName1 = table.Column<string>(nullable: true),
                    FighterName2 = table.Column<string>(nullable: true),
                    Fighter1Won = table.Column<bool>(nullable: false),
                    Fighter1TotalScore = table.Column<int>(nullable: false),
                    Fighter2TotalScore = table.Column<int>(nullable: false),
                    YouTubeLink = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoxingMatches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Judges",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Full_Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Judges", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rounds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fighter1Score = table.Column<int>(nullable: false),
                    Fighter2Score = table.Column<int>(nullable: false),
                    EffectiveAggression = table.Column<bool>(nullable: false),
                    RingGeneralship = table.Column<bool>(nullable: false),
                    Defense = table.Column<bool>(nullable: false),
                    HardandCleanPunches = table.Column<bool>(nullable: false),
                    PointDeductionFighter1 = table.Column<int>(nullable: false),
                    PointDeductionFighter2 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rounds", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BoxingMatches");

            migrationBuilder.DropTable(
                name: "Judges");

            migrationBuilder.DropTable(
                name: "Rounds");
        }
    }
}
