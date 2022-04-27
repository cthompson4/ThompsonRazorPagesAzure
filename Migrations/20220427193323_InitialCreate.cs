using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThompsonRazorPagesAzure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserPreferences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    FavBook = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FavMovie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FavGenre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorstGenre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPreferences", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserPreferences");
        }
    }
}
