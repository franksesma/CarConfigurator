using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBuilder.Migrations
{
    /// <inheritdoc />
    public partial class addedCarOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BodyColor",
                table: "CarOrders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BodyType",
                table: "CarOrders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WheelColor",
                table: "CarOrders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WheelType",
                table: "CarOrders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BodyColor",
                table: "CarOrders");

            migrationBuilder.DropColumn(
                name: "BodyType",
                table: "CarOrders");

            migrationBuilder.DropColumn(
                name: "WheelColor",
                table: "CarOrders");

            migrationBuilder.DropColumn(
                name: "WheelType",
                table: "CarOrders");
        }
    }
}
