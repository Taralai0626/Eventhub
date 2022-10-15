using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventHub_App.Data.Migrations
{
    public partial class edit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FavouriteEvent",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FavouriteEventName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FavouriteEventDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FavouriteEventTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FavouriteEventPriceMin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FavouriteEventPriceMax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FavouriteEventPriceCurrency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FavouriteEventUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FavouriteEventVenue = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavouriteEvent", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavouriteEvent");
        }
    }
}
