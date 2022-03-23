using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gest.SqliteMigration.Migrations
{
    public partial class UpdateSaleItemId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SaleItem",
                table: "SaleItem");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "SaleItem",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SaleItem",
                table: "SaleItem",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: new Guid("453412a3-578b-446b-9406-bd7077bdce01"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 46, 26, 829, DateTimeKind.Utc).AddTicks(9431), new DateTime(2022, 3, 22, 20, 46, 26, 829, DateTimeKind.Utc).AddTicks(9428) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("654412a3-578b-446b-9406-bd7077bdce01"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 46, 26, 829, DateTimeKind.Utc).AddTicks(9435), new DateTime(2022, 3, 22, 20, 46, 26, 829, DateTimeKind.Utc).AddTicks(9433) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 46, 26, 829, DateTimeKind.Utc).AddTicks(9426), new DateTime(2022, 3, 22, 20, 46, 26, 829, DateTimeKind.Utc).AddTicks(9423) });

            migrationBuilder.UpdateData(
                table: "UserCompanies",
                keyColumns: new[] { "CompanyId", "UserId" },
                keyValues: new object[] { new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"), new Guid("d5ccad5b-6cbc-4993-96e3-e8cd7c76d8b9") },
                column: "Joined",
                value: new DateTime(2022, 3, 22, 20, 46, 26, 829, DateTimeKind.Utc).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5ccad5b-6cbc-4993-96e3-e8cd7c76d8b9"),
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 46, 26, 829, DateTimeKind.Utc).AddTicks(9407), "uC8W7OCxJbCrEwQpbYFe8C2WtfxY7Zx4MdFqlK2AQwMwuC0NvxuN2pFHl37tAFNJFoJkKo71vX60Y3JHejVrnNLiYGJDkx4rYHkogRgpu2zZ/uRH7WVTKqojF8Kc5c6qPzdgQTN33wgdN4MkO4lzGrkZXr51yIFqhdMkulmtz45x13CeLYd79Pd7E7TOP9aIyv9ykFT7U7RPBWUkpsNs4PMwaOjJupGkVErk9FYv+0x842cO83ju/1nnTzVDfUHFUDBa7gN6q0HnHM9B8Pjn2ESNpl3NtH80WLb24vnPa1PDA+QSU+HLkqcoxnU+EBMh9ZhBCrHSrcWHW0C8qu8UXw==", "z/GVSh2V+S6QswNz3wdWYTEBO9bplYQse3kqmYlExVQ3B2yioAtR8ULhcZyoq+qggfgY1/Vp9R+w9XF5Ik1phg==", new DateTime(2022, 3, 22, 20, 46, 26, 829, DateTimeKind.Utc).AddTicks(9382) });

            migrationBuilder.CreateIndex(
                name: "IX_SaleItem_SaleId",
                table: "SaleItem",
                column: "SaleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SaleItem",
                table: "SaleItem");

            migrationBuilder.DropIndex(
                name: "IX_SaleItem_SaleId",
                table: "SaleItem");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "SaleItem",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SaleItem",
                table: "SaleItem",
                columns: new[] { "SaleId", "Id" });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: new Guid("453412a3-578b-446b-9406-bd7077bdce01"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 13, 8, 26, 21, 316, DateTimeKind.Utc).AddTicks(5117), new DateTime(2022, 3, 13, 8, 26, 21, 316, DateTimeKind.Utc).AddTicks(5115) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("654412a3-578b-446b-9406-bd7077bdce01"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 13, 8, 26, 21, 316, DateTimeKind.Utc).AddTicks(5120), new DateTime(2022, 3, 13, 8, 26, 21, 316, DateTimeKind.Utc).AddTicks(5119) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 13, 8, 26, 21, 316, DateTimeKind.Utc).AddTicks(5114), new DateTime(2022, 3, 13, 8, 26, 21, 316, DateTimeKind.Utc).AddTicks(5107) });

            migrationBuilder.UpdateData(
                table: "UserCompanies",
                keyColumns: new[] { "CompanyId", "UserId" },
                keyValues: new object[] { new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"), new Guid("d5ccad5b-6cbc-4993-96e3-e8cd7c76d8b9") },
                column: "Joined",
                value: new DateTime(2022, 3, 13, 8, 26, 21, 316, DateTimeKind.Utc).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5ccad5b-6cbc-4993-96e3-e8cd7c76d8b9"),
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 13, 8, 26, 21, 316, DateTimeKind.Utc).AddTicks(5092), "AeCBjHabRWTA11fgDc1onZRA6X2KOeXg+bGCMYTmGKbSav7Fa0GUWTeCzR+fcgmrg6Z2JsnVwLWpXIlHsbkPMD5NQAW3kwFgAxXcqhT0qjhe9cpbvzJ0UTyf7sbva/hPWf2AnhH48U/aNcl/TI3CdWHsMwC9mr4x1JNQGN0wzeftZsleaS0FGFNg/L8pf6S88oFDQhwPkQ/oEz70xG5ZJnRshftsGaGMbFb7+kEFx4dZJZW6gBP5ax1s5AVE+Lg1PcNQ9/FJDeKP1/diOeXu+mYn+ylJF75eVtGdFzpRLoAe7//udtA9cdGIiP6eeIXkRrANXfoxCyd3LlG7z+7iVQ==", "w4VA6eatiXF21vAY3VuNscKEaipb8E0bFFsTn7K7u4IcYOH3zd8TxNlC4ru3WDMjJPCs0eSZKwuQEWv1GP71kg==", new DateTime(2022, 3, 13, 8, 26, 21, 316, DateTimeKind.Utc).AddTicks(5069) });
        }
    }
}
