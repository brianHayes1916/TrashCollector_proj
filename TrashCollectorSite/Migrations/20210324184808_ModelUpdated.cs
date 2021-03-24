using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectorSite.Migrations
{
    public partial class ModelUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3906aa6-a0b1-4d73-91d3-f85224c73d85");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4c80d51-21b8-46be-88b6-5430f437614e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f9c2fb51-22bb-4e1d-baa2-6e4c2077b6aa", "9defed36-7769-48a6-ac95-3999f114d5e5", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ceb20ddb-dd59-4f45-9dbc-f6a8f009b42c", "920ac393-b6a9-4eba-b866-6c5f66037e22", "Customer", "CUSTOMER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ceb20ddb-dd59-4f45-9dbc-f6a8f009b42c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f9c2fb51-22bb-4e1d-baa2-6e4c2077b6aa");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d4c80d51-21b8-46be-88b6-5430f437614e", "5e07c4a1-87fa-44a8-9655-13eb8326b3d9", "Employee", "EMPLOYEE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a3906aa6-a0b1-4d73-91d3-f85224c73d85", "7994ae22-0f0f-4ff9-b6bc-fef87e522162", "Customer", "CUSTOMER" });
        }
    }
}
