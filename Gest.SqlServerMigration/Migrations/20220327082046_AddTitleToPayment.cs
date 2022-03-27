using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gest.SqlServerMigration.Migrations
{
    public partial class AddTitleToPayment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Expense_Amount",
                table: "Wallets",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "Expense_LastUpdated",
                table: "Wallets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: new Guid("453412a3-578b-446b-9406-bd7077bdce01"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 27, 8, 20, 45, 194, DateTimeKind.Utc).AddTicks(2701), new DateTime(2022, 3, 27, 8, 20, 45, 194, DateTimeKind.Utc).AddTicks(2694) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("654412a3-578b-446b-9406-bd7077bdce01"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 27, 8, 20, 45, 194, DateTimeKind.Utc).AddTicks(2711), new DateTime(2022, 3, 27, 8, 20, 45, 194, DateTimeKind.Utc).AddTicks(2705) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 27, 8, 20, 45, 194, DateTimeKind.Utc).AddTicks(2690), new DateTime(2022, 3, 27, 8, 20, 45, 194, DateTimeKind.Utc).AddTicks(2687) });

            migrationBuilder.UpdateData(
                table: "UserCompanies",
                keyColumns: new[] { "CompanyId", "UserId" },
                keyValues: new object[] { new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"), new Guid("d5ccad5b-6cbc-4993-96e3-e8cd7c76d8b9") },
                column: "Joined",
                value: new DateTime(2022, 3, 27, 8, 20, 45, 194, DateTimeKind.Utc).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5ccad5b-6cbc-4993-96e3-e8cd7c76d8b9"),
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 27, 8, 20, 45, 194, DateTimeKind.Utc).AddTicks(2659), "dzghSLPKG3GTVdAAO7ooJAN5ym3UDXXyWbDhFjS5O/GPzJFe0bCL6ALdGW1Quqw7LcM04Uz54+/b4FWYfW/KIcjUgBE4ywWyH6qIGhylwTTwQMcT4rlUz2gYQ8UzbpMoxdgEHV9qT0rM5qat/CvwTYDdHoLnGJejp8rZr6x/wfqq8xdhAI1MUihxonU+5BV/JKBISf6t3GiXMiaHmxriOui2n1+8g2A2OoAi8PkXmvRc071h1eAuk/y6LPtzpG5N2HDe2XiPmagkJ0chXMkNWGLKRE1Rk530f+J8En+XMyaqLb8xaeYqzHprcqGQI46C4hBf81cPdDjzg5vzvld23w==", "0O7nEzCAAegTYiOT0eK/8NT6mdzZEC5nDqakkYRpiwIo9FWQ63lQXqpY6a44PEtbmMwXLsG/+fbuIYwPcSx9Hw==", new DateTime(2022, 3, 27, 8, 20, 45, 194, DateTimeKind.Utc).AddTicks(2624) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Expense_Amount",
                table: "Wallets");

            migrationBuilder.DropColumn(
                name: "Expense_LastUpdated",
                table: "Wallets");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Payments");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: new Guid("453412a3-578b-446b-9406-bd7077bdce01"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 24, 20, 57, 16, 666, DateTimeKind.Utc).AddTicks(2149), new DateTime(2022, 3, 24, 20, 57, 16, 666, DateTimeKind.Utc).AddTicks(2146) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("654412a3-578b-446b-9406-bd7077bdce01"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 24, 20, 57, 16, 666, DateTimeKind.Utc).AddTicks(2155), new DateTime(2022, 3, 24, 20, 57, 16, 666, DateTimeKind.Utc).AddTicks(2152) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 24, 20, 57, 16, 666, DateTimeKind.Utc).AddTicks(2144), new DateTime(2022, 3, 24, 20, 57, 16, 666, DateTimeKind.Utc).AddTicks(2142) });

            migrationBuilder.UpdateData(
                table: "UserCompanies",
                keyColumns: new[] { "CompanyId", "UserId" },
                keyValues: new object[] { new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"), new Guid("d5ccad5b-6cbc-4993-96e3-e8cd7c76d8b9") },
                column: "Joined",
                value: new DateTime(2022, 3, 24, 20, 57, 16, 666, DateTimeKind.Utc).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5ccad5b-6cbc-4993-96e3-e8cd7c76d8b9"),
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 24, 20, 57, 16, 666, DateTimeKind.Utc).AddTicks(2128), "TCiVp/X2B1ixKt7XvfmQvBkmAsnfYfXLJHkl6iXOKG001rfrTpHzkYCmQko4elh6aWu+uw2E4mzJb7BvcFt9bbG4/dXTEwDwWf1ObmAAT9k6sqfpOuXMfHSFMSu+5ReszjvtZ/wF4jt6KLHB6Sf2NJ4S8mYoWXVXhAALdaLSB9Oe+C/sX24ToIA01lPTEQH/DBy1Q71jODft7Qs70AoLMLF1XHWQ1W/Qq91HpCUSW62Y8BSyosMeaoM1IPU7aO4u1wHx6tUAbFdSFWoY70LrdswhIE6NECMeDSDuwYveowHvD4CLXrSVAXk3eS/RieG2Jn7azzH6nZ5jH2GNyt7odg==", "d1Oaw5CmhClmY60X8bTC4RC6eMCIVMaJP/rQW6w8CH3UGYiPMykgH0kXKtGhGJJieWJOJ9FjyubuEEPTpUIEuQ==", new DateTime(2022, 3, 24, 20, 57, 16, 666, DateTimeKind.Utc).AddTicks(2105) });
        }
    }
}
