using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepairShopV1.Migrations
{
    /// <inheritdoc />
    public partial class FixedModelsPartAndService : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartService_Parts_PartsId",
                table: "PartService");

            migrationBuilder.DropForeignKey(
                name: "FK_PartService_Services_ServicesId",
                table: "PartService");

            migrationBuilder.RenameColumn(
                name: "ServicesId",
                table: "PartService",
                newName: "ServiceId");

            migrationBuilder.RenameColumn(
                name: "PartsId",
                table: "PartService",
                newName: "PartId");

            migrationBuilder.RenameIndex(
                name: "IX_PartService_ServicesId",
                table: "PartService",
                newName: "IX_PartService_ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_PartService_Parts_PartId",
                table: "PartService",
                column: "PartId",
                principalTable: "Parts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartService_Services_ServiceId",
                table: "PartService",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartService_Parts_PartId",
                table: "PartService");

            migrationBuilder.DropForeignKey(
                name: "FK_PartService_Services_ServiceId",
                table: "PartService");

            migrationBuilder.RenameColumn(
                name: "ServiceId",
                table: "PartService",
                newName: "ServicesId");

            migrationBuilder.RenameColumn(
                name: "PartId",
                table: "PartService",
                newName: "PartsId");

            migrationBuilder.RenameIndex(
                name: "IX_PartService_ServiceId",
                table: "PartService",
                newName: "IX_PartService_ServicesId");

            migrationBuilder.AddForeignKey(
                name: "FK_PartService_Parts_PartsId",
                table: "PartService",
                column: "PartsId",
                principalTable: "Parts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartService_Services_ServicesId",
                table: "PartService",
                column: "ServicesId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
