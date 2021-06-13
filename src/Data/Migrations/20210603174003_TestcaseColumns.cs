using Microsoft.EntityFrameworkCore.Migrations;

namespace tcms.Data.Migrations
{
    public partial class TestcaseColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestCases_Priorities_PriorityTestCasePriorityId",
                schema: "testcases",
                table: "TestCases");

            migrationBuilder.DropForeignKey(
                name: "FK_TestCases_Statuses_StatusTestCaseStatusId",
                schema: "testcases",
                table: "TestCases");

            migrationBuilder.DropForeignKey(
                name: "FK_TestCases_Types_TypeTestCaseTypeId",
                schema: "testcases",
                table: "TestCases");

            migrationBuilder.DropIndex(
                name: "IX_TestCases_PriorityTestCasePriorityId",
                schema: "testcases",
                table: "TestCases");

            migrationBuilder.DropIndex(
                name: "IX_TestCases_TypeTestCaseTypeId",
                schema: "testcases",
                table: "TestCases");

            migrationBuilder.DropColumn(
                name: "PriorityTestCasePriorityId",
                schema: "testcases",
                table: "TestCases");

            migrationBuilder.DropColumn(
                name: "TypeTestCaseTypeId",
                schema: "testcases",
                table: "TestCases");

            migrationBuilder.RenameColumn(
                name: "StatusTestCaseStatusId",
                schema: "testcases",
                table: "TestCases",
                newName: "TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_TestCases_StatusTestCaseStatusId",
                schema: "testcases",
                table: "TestCases",
                newName: "IX_TestCases_TypeId");

            migrationBuilder.AddColumn<int>(
                name: "PriorityId",
                schema: "testcases",
                table: "TestCases",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                schema: "testcases",
                table: "TestCases",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(128)",
                oldMaxLength: 128);

            migrationBuilder.CreateIndex(
                name: "IX_TestCases_PriorityId",
                schema: "testcases",
                table: "TestCases",
                column: "PriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_TestCases_StatusId",
                schema: "testcases",
                table: "TestCases",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_TestCases_Priorities_PriorityId",
                schema: "testcases",
                table: "TestCases",
                column: "PriorityId",
                principalSchema: "testcases",
                principalTable: "Priorities",
                principalColumn: "TestCasePriorityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TestCases_Statuses_StatusId",
                schema: "testcases",
                table: "TestCases",
                column: "StatusId",
                principalSchema: "testcases",
                principalTable: "Statuses",
                principalColumn: "TestCaseStatusId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TestCases_Types_TypeId",
                schema: "testcases",
                table: "TestCases",
                column: "TypeId",
                principalSchema: "testcases",
                principalTable: "Types",
                principalColumn: "TestCaseTypeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestCases_Priorities_PriorityId",
                schema: "testcases",
                table: "TestCases");

            migrationBuilder.DropForeignKey(
                name: "FK_TestCases_Statuses_StatusId",
                schema: "testcases",
                table: "TestCases");

            migrationBuilder.DropForeignKey(
                name: "FK_TestCases_Types_TypeId",
                schema: "testcases",
                table: "TestCases");

            migrationBuilder.DropIndex(
                name: "IX_TestCases_PriorityId",
                schema: "testcases",
                table: "TestCases");

            migrationBuilder.DropIndex(
                name: "IX_TestCases_StatusId",
                schema: "testcases",
                table: "TestCases");

            migrationBuilder.DropColumn(
                name: "PriorityId",
                schema: "testcases",
                table: "TestCases");

            migrationBuilder.DropColumn(
                name: "StatusId",
                schema: "testcases",
                table: "TestCases");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                schema: "testcases",
                table: "TestCases",
                newName: "StatusTestCaseStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_TestCases_TypeId",
                schema: "testcases",
                table: "TestCases",
                newName: "IX_TestCases_StatusTestCaseStatusId");

            migrationBuilder.AddColumn<int>(
                name: "PriorityTestCasePriorityId",
                schema: "testcases",
                table: "TestCases",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TypeTestCaseTypeId",
                schema: "testcases",
                table: "TestCases",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.CreateIndex(
                name: "IX_TestCases_PriorityTestCasePriorityId",
                schema: "testcases",
                table: "TestCases",
                column: "PriorityTestCasePriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_TestCases_TypeTestCaseTypeId",
                schema: "testcases",
                table: "TestCases",
                column: "TypeTestCaseTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TestCases_Priorities_PriorityTestCasePriorityId",
                schema: "testcases",
                table: "TestCases",
                column: "PriorityTestCasePriorityId",
                principalSchema: "testcases",
                principalTable: "Priorities",
                principalColumn: "TestCasePriorityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TestCases_Statuses_StatusTestCaseStatusId",
                schema: "testcases",
                table: "TestCases",
                column: "StatusTestCaseStatusId",
                principalSchema: "testcases",
                principalTable: "Statuses",
                principalColumn: "TestCaseStatusId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TestCases_Types_TypeTestCaseTypeId",
                schema: "testcases",
                table: "TestCases",
                column: "TypeTestCaseTypeId",
                principalSchema: "testcases",
                principalTable: "Types",
                principalColumn: "TestCaseTypeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
