using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace tcms.Data.Migrations
{
    public partial class TestCases : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_products",
                schema: "core",
                table: "products");

            migrationBuilder.EnsureSchema(
                name: "testcases");

            migrationBuilder.RenameTable(
                name: "products",
                schema: "core",
                newName: "Products",
                newSchema: "core");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "core",
                table: "Products",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_products_Name",
                schema: "core",
                table: "Products",
                newName: "IX_Products_Name");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "core",
                table: "Products",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "core",
                table: "Products",
                type: "character varying(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(2000)",
                oldMaxLength: 2000);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "core",
                table: "Products",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                schema: "core",
                table: "Products",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                schema: "core",
                table: "Products",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                schema: "core",
                table: "Products",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                schema: "core",
                table: "Products",
                column: "ProductId");

            migrationBuilder.CreateTable(
                name: "Components",
                schema: "core",
                columns: table => new
                {
                    ComponentId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    ProductId = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Components", x => x.ComponentId);
                    table.ForeignKey(
                        name: "FK_Components_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "core",
                        principalTable: "Products",
                        principalColumn: "ProductId");
                });

            migrationBuilder.CreateTable(
                name: "Priorities",
                schema: "testcases",
                columns: table => new
                {
                    TestCasePriorityId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Priorities", x => x.TestCasePriorityId);
                });

            migrationBuilder.CreateTable(
                name: "ProductVersions",
                schema: "core",
                columns: table => new
                {
                    ProductVersionId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    StartDate = table.Column<DateTime>(type: "Date", nullable: false),
                    EndDate = table.Column<DateTime>(type: "Date", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVersions", x => x.ProductVersionId);
                    table.ForeignKey(
                        name: "FK_ProductVersions_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "core",
                        principalTable: "Products",
                        principalColumn: "ProductId");
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                schema: "testcases",
                columns: table => new
                {
                    TestCaseStatusId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    IsApproved = table.Column<bool>(type: "boolean", nullable: false),
                    Description = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.TestCaseStatusId);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                schema: "testcases",
                columns: table => new
                {
                    TestCaseTypeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.TestCaseTypeId);
                });

            migrationBuilder.CreateTable(
                name: "TestCases",
                schema: "testcases",
                columns: table => new
                {
                    TestCaseId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    EstimateHr = table.Column<double>(type: "double precision", nullable: false),
                    ComponentId = table.Column<int>(type: "integer", nullable: false),
                    StatusTestCaseStatusId = table.Column<int>(type: "integer", nullable: false),
                    TypeTestCaseTypeId = table.Column<int>(type: "integer", nullable: true),
                    PriorityTestCasePriorityId = table.Column<int>(type: "integer", nullable: true),
                    IsAutomated = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestCases", x => x.TestCaseId);
                    table.ForeignKey(
                        name: "FK_TestCases_Components_ComponentId",
                        column: x => x.ComponentId,
                        principalSchema: "core",
                        principalTable: "Components",
                        principalColumn: "ComponentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TestCases_Priorities_PriorityTestCasePriorityId",
                        column: x => x.PriorityTestCasePriorityId,
                        principalSchema: "testcases",
                        principalTable: "Priorities",
                        principalColumn: "TestCasePriorityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TestCases_Statuses_StatusTestCaseStatusId",
                        column: x => x.StatusTestCaseStatusId,
                        principalSchema: "testcases",
                        principalTable: "Statuses",
                        principalColumn: "TestCaseStatusId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TestCases_Types_TypeTestCaseTypeId",
                        column: x => x.TypeTestCaseTypeId,
                        principalSchema: "testcases",
                        principalTable: "Types",
                        principalColumn: "TestCaseTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Steps",
                schema: "testcases",
                columns: table => new
                {
                    TestCaseStepId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Text = table.Column<string>(type: "text", nullable: false),
                    IsPrecondition = table.Column<bool>(type: "boolean", nullable: false),
                    Ordinal = table.Column<int>(type: "integer", nullable: false),
                    TestCaseId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Steps", x => x.TestCaseStepId);
                    table.ForeignKey(
                        name: "FK_Steps_TestCases_TestCaseId",
                        column: x => x.TestCaseId,
                        principalSchema: "testcases",
                        principalTable: "TestCases",
                        principalColumn: "TestCaseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Attachments",
                schema: "core",
                columns: table => new
                {
                    AttachmentId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Content = table.Column<byte[]>(type: "bytea", nullable: true),
                    AttachmentFile = table.Column<string>(type: "text", nullable: true),
                    ContentType = table.Column<string>(type: "text", nullable: true),
                    TestCaseStepId = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attachments", x => x.AttachmentId);
                    table.ForeignKey(
                        name: "FK_Attachments_Steps_TestCaseStepId",
                        column: x => x.TestCaseStepId,
                        principalSchema: "testcases",
                        principalTable: "Steps",
                        principalColumn: "TestCaseStepId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                schema: "testcases",
                table: "Priorities",
                columns: new[] { "TestCasePriorityId", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 3, null, null, null, null, "Low" },
                    { 2, null, null, null, null, "Medium" },
                    { 1, null, null, null, null, "High" }
                });

            migrationBuilder.InsertData(
                schema: "testcases",
                table: "Statuses",
                columns: new[] { "TestCaseStatusId", "CreatedBy", "CreatedDate", "Description", "IsApproved", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 3, null, null, null, true, null, null, "Approved" },
                    { 1, null, null, null, false, null, null, "Proposed" },
                    { 2, null, null, null, false, null, null, "RequireChanges" }
                });

            migrationBuilder.InsertData(
                schema: "testcases",
                table: "Types",
                columns: new[] { "TestCaseTypeId", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, null, null, null, null, "Functional" },
                    { 2, null, null, null, null, "Usability" },
                    { 3, null, null, null, null, "Performance" },
                    { 4, null, null, null, null, "Regression" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attachments_TestCaseStepId",
                schema: "core",
                table: "Attachments",
                column: "TestCaseStepId");

            migrationBuilder.CreateIndex(
                name: "IX_Components_Name",
                schema: "core",
                table: "Components",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Components_ProductId",
                schema: "core",
                table: "Components",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVersions_ProductId",
                schema: "core",
                table: "ProductVersions",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Steps_TestCaseId",
                schema: "testcases",
                table: "Steps",
                column: "TestCaseId");

            migrationBuilder.CreateIndex(
                name: "IX_TestCases_ComponentId",
                schema: "testcases",
                table: "TestCases",
                column: "ComponentId");

            migrationBuilder.CreateIndex(
                name: "IX_TestCases_PriorityTestCasePriorityId",
                schema: "testcases",
                table: "TestCases",
                column: "PriorityTestCasePriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_TestCases_StatusTestCaseStatusId",
                schema: "testcases",
                table: "TestCases",
                column: "StatusTestCaseStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_TestCases_TypeTestCaseTypeId",
                schema: "testcases",
                table: "TestCases",
                column: "TypeTestCaseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Types_Name",
                schema: "testcases",
                table: "Types",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attachments",
                schema: "core");

            migrationBuilder.DropTable(
                name: "ProductVersions",
                schema: "core");

            migrationBuilder.DropTable(
                name: "Steps",
                schema: "testcases");

            migrationBuilder.DropTable(
                name: "TestCases",
                schema: "testcases");

            migrationBuilder.DropTable(
                name: "Components",
                schema: "core");

            migrationBuilder.DropTable(
                name: "Priorities",
                schema: "testcases");

            migrationBuilder.DropTable(
                name: "Statuses",
                schema: "testcases");

            migrationBuilder.DropTable(
                name: "Types",
                schema: "testcases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                schema: "core",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "core",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                schema: "core",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "core",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                schema: "core",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                schema: "core",
                newName: "products",
                newSchema: "core");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                schema: "core",
                table: "products",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Products_Name",
                schema: "core",
                table: "products",
                newName: "IX_products_Name");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "core",
                table: "products",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "core",
                table: "products",
                type: "character varying(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_products",
                schema: "core",
                table: "products",
                column: "Id");
        }
    }
}
