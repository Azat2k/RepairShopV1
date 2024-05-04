using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepairShopV1.Migrations
{
    /// <inheritdoc />
    public partial class FixedModelsPartAndServiceRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartService_Parts_PartId",
                table: "PartService");

            migrationBuilder.DropForeignKey(
                name: "FK_PartService_Services_ServiceId",
                table: "PartService");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PartService",
                table: "PartService");

            migrationBuilder.RenameTable(
                name: "PartService",
                newName: "PartServices");

            migrationBuilder.RenameIndex(
                name: "IX_PartService_ServiceId",
                table: "PartServices",
                newName: "IX_PartServices_ServiceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PartServices",
                table: "PartServices",
                columns: new[] { "PartId", "ServiceId" });

            migrationBuilder.AddForeignKey(
                name: "FK_PartServices_Parts_PartId",
                table: "PartServices",
                column: "PartId",
                principalTable: "Parts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartServices_Services_ServiceId",
                table: "PartServices",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartServices_Parts_PartId",
                table: "PartServices");

            migrationBuilder.DropForeignKey(
                name: "FK_PartServices_Services_ServiceId",
                table: "PartServices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PartServices",
                table: "PartServices");

            migrationBuilder.RenameTable(
                name: "PartServices",
                newName: "PartService");

            migrationBuilder.RenameIndex(
                name: "IX_PartServices_ServiceId",
                table: "PartService",
                newName: "IX_PartService_ServiceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PartService",
                table: "PartService",
                columns: new[] { "PartId", "ServiceId" });

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
    }
}
