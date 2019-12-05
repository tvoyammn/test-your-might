using Microsoft.EntityFrameworkCore.Migrations;

namespace TestYourMight.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AllGames",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gameName = table.Column<string>(nullable: true),
                    gameImage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllGames", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AllDeals",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    desc = table.Column<string>(nullable: true),
                    mode = table.Column<string>(nullable: true),
                    price = table.Column<int>(nullable: false),
                    isReal = table.Column<bool>(nullable: false),
                    gameID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllDeals", x => x.id);
                    table.ForeignKey(
                        name: "FK_AllDeals_AllGames_gameID",
                        column: x => x.gameID,
                        principalTable: "AllGames",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AllDeals_gameID",
                table: "AllDeals",
                column: "gameID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllDeals");

            migrationBuilder.DropTable(
                name: "AllGames");
        }
    }
}
