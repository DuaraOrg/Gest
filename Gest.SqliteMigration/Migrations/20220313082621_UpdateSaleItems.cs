using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gest.SqliteMigration.Migrations
{
    public partial class UpdateSaleItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SaleId",
                table: "Sales",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "BuyingUnitPricePerUnitOfMeasure",
                table: "SaleItem",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "PayementId",
                table: "Payments",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SaleId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "BuyingUnitPricePerUnitOfMeasure",
                table: "SaleItem");

            migrationBuilder.DropColumn(
                name: "PayementId",
                table: "Payments");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: new Guid("453412a3-578b-446b-9406-bd7077bdce01"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 9, 17, 23, 11, 63, DateTimeKind.Utc).AddTicks(754), new DateTime(2022, 3, 9, 17, 23, 11, 63, DateTimeKind.Utc).AddTicks(748) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("654412a3-578b-446b-9406-bd7077bdce01"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 9, 17, 23, 11, 63, DateTimeKind.Utc).AddTicks(761), new DateTime(2022, 3, 9, 17, 23, 11, 63, DateTimeKind.Utc).AddTicks(756) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 9, 17, 23, 11, 63, DateTimeKind.Utc).AddTicks(744), new DateTime(2022, 3, 9, 17, 23, 11, 63, DateTimeKind.Utc).AddTicks(740) });

            migrationBuilder.UpdateData(
                table: "UserCompanies",
                keyColumns: new[] { "CompanyId", "UserId" },
                keyValues: new object[] { new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"), new Guid("d5ccad5b-6cbc-4993-96e3-e8cd7c76d8b9") },
                column: "Joined",
                value: new DateTime(2022, 3, 9, 17, 23, 11, 63, DateTimeKind.Utc).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5ccad5b-6cbc-4993-96e3-e8cd7c76d8b9"),
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 9, 17, 23, 11, 63, DateTimeKind.Utc).AddTicks(711), "yb2cLL9oyF5Hh31338npkaVjKHseF/Kg2GKTQTZaFuj3mk9lCq8GkotTI7NfUNiNY/lQfFzQsnus284dl3OyN7/PAbadj6Kxm6PYi+vRSfCuLRZSAXj23Ew/jWuhvU66gsaj2SnXJ2B/Lawim3GD+4xMibOjsQP67mhlCth+lfZm76O80f5GdSy36nJ+U46E6ObS6IrNa0O3HS6/bEscGwISWaMTDq5DW00DDJdBZ9YgB6IyNi1tDy3mGh80rVmQzBs9p+wD5HzMI5J6XkauUQ8XpTUY2miPhVllyuh9ccQo3D9jh6ymf93VMq9FZzUO0odBMV27cLBzQT54Rb+oDQ==", "VeTkK1o1e5GPGbwZIctCuzyJh2+Hak2aIR157dt4rp7lVAZldlksNcPlyynfdglRwa9BMhAb+bead3B0WTv4ZA==", new DateTime(2022, 3, 9, 17, 23, 11, 63, DateTimeKind.Utc).AddTicks(670) });
        }
    }
}
