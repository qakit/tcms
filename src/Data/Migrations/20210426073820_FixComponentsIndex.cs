using Microsoft.EntityFrameworkCore.Migrations;

namespace tcms.Data.Migrations
{
    public partial class FixComponentsIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Components_Name",
                schema: "core",
                table: "Components");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                schema: "core",
                table: "Components",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Components_Name_ProductId",
                schema: "core",
                table: "Components",
                columns: new[] { "Name", "ProductId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Components_Name_ProductId",
                schema: "core",
                table: "Components");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                schema: "core",
                table: "Components",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.CreateIndex(
                name: "IX_Components_Name",
                schema: "core",
                table: "Components",
                column: "Name",
                unique: true);
        }
    }
}
