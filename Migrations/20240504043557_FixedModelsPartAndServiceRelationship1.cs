using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepairShopV1.Migrations
{
    /// <inheritdoc />
    public partial class FixedModelsPartAndServiceRelationship1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PartId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "Parts");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PartId",
                table: "Services",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ServiceId",
                table: "Parts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
