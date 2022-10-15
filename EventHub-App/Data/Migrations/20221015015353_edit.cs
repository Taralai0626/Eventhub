using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventHub_App.Data.Migrations
{
    public partial class edit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FavouriteEventPriceCurrency",
                table: "FavouriteEvent",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "FavouriteEventPriceMax",
                table: "FavouriteEvent",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FavouriteEventPriceMin",
                table: "FavouriteEvent",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FavouriteEventTime",
                table: "FavouriteEvent",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FavouriteEventUrl",
                table: "FavouriteEvent",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FavouriteEventVenue",
                table: "FavouriteEvent",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FavouriteEventPriceCurrency",
                table: "FavouriteEvent");

            migrationBuilder.DropColumn(
                name: "FavouriteEventPriceMax",
                table: "FavouriteEvent");

            migrationBuilder.DropColumn(
                name: "FavouriteEventPriceMin",
                table: "FavouriteEvent");

            migrationBuilder.DropColumn(
                name: "FavouriteEventTime",
                table: "FavouriteEvent");

            migrationBuilder.DropColumn(
                name: "FavouriteEventUrl",
                table: "FavouriteEvent");

            migrationBuilder.DropColumn(
                name: "FavouriteEventVenue",
                table: "FavouriteEvent");
        }
    }
}
