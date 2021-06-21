using Microsoft.EntityFrameworkCore.Migrations;

namespace tcms.Data.Migrations
{
    public partial class TestcaseText : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Text",
                schema: "testcases",
                table: "TestCases",
                type: "character varying(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                schema: "testcases",
                table: "Types",
                keyColumn: "TestCaseTypeId",
                keyValue: 1,
                column: "Name",
                value: "Other");

            migrationBuilder.UpdateData(
                schema: "testcases",
                table: "Types",
                keyColumn: "TestCaseTypeId",
                keyValue: 2,
                column: "Name",
                value: "Functional");

            migrationBuilder.UpdateData(
                schema: "testcases",
                table: "Types",
                keyColumn: "TestCaseTypeId",
                keyValue: 3,
                column: "Name",
                value: "Usability");

            migrationBuilder.UpdateData(
                schema: "testcases",
                table: "Types",
                keyColumn: "TestCaseTypeId",
                keyValue: 4,
                column: "Name",
                value: "Performance");

            migrationBuilder.InsertData(
                schema: "testcases",
                table: "Types",
                columns: new[] { "TestCaseTypeId", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[] { 5, null, null, null, null, "Regression" });

            migrationBuilder.CreateIndex(
                name: "IX_TestCases_Title",
                schema: "testcases",
                table: "TestCases",
                column: "Title");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TestCases_Title",
                schema: "testcases",
                table: "TestCases");

            migrationBuilder.DeleteData(
                schema: "testcases",
                table: "Types",
                keyColumn: "TestCaseTypeId",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Text",
                schema: "testcases",
                table: "TestCases");

            migrationBuilder.UpdateData(
                schema: "testcases",
                table: "Types",
                keyColumn: "TestCaseTypeId",
                keyValue: 1,
                column: "Name",
                value: "Functional");

            migrationBuilder.UpdateData(
                schema: "testcases",
                table: "Types",
                keyColumn: "TestCaseTypeId",
                keyValue: 2,
                column: "Name",
                value: "Usability");

            migrationBuilder.UpdateData(
                schema: "testcases",
                table: "Types",
                keyColumn: "TestCaseTypeId",
                keyValue: 3,
                column: "Name",
                value: "Performance");

            migrationBuilder.UpdateData(
                schema: "testcases",
                table: "Types",
                keyColumn: "TestCaseTypeId",
                keyValue: 4,
                column: "Name",
                value: "Regression");
        }
    }
}
