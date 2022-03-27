using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gest.SqlServerMigration.Migrations
{
    public partial class AddExpenses2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Payments");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: new Guid("453412a3-578b-446b-9406-bd7077bdce01"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 24, 20, 49, 5, 972, DateTimeKind.Utc).AddTicks(8187), new DateTime(2022, 3, 24, 20, 49, 5, 972, DateTimeKind.Utc).AddTicks(8179) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("654412a3-578b-446b-9406-bd7077bdce01"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 24, 20, 49, 5, 972, DateTimeKind.Utc).AddTicks(8194), new DateTime(2022, 3, 24, 20, 49, 5, 972, DateTimeKind.Utc).AddTicks(8191) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 24, 20, 49, 5, 972, DateTimeKind.Utc).AddTicks(8176), new DateTime(2022, 3, 24, 20, 49, 5, 972, DateTimeKind.Utc).AddTicks(8174) });

            migrationBuilder.UpdateData(
                table: "UserCompanies",
                keyColumns: new[] { "CompanyId", "UserId" },
                keyValues: new object[] { new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"), new Guid("d5ccad5b-6cbc-4993-96e3-e8cd7c76d8b9") },
                column: "Joined",
                value: new DateTime(2022, 3, 24, 20, 49, 5, 972, DateTimeKind.Utc).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5ccad5b-6cbc-4993-96e3-e8cd7c76d8b9"),
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 24, 20, 49, 5, 972, DateTimeKind.Utc).AddTicks(8123), "fpJtR2USmTuCLB8bWVhZP6SzLbPuYogfpqzF0EH320G49tocHNYH8uY6PHXQ04z8/l9Vq2vMnVsGYWUmqvjSRlCtk7wD7SYE9ZQTkvcGR5Tg0sAqzzPb6D50PUcm4AuGOeQrUODdHzQFueYuyAb1XNJE8sTBIKxOS2bh/FaCiqrONOMlQeOG3LQIT5KQh/51SlvxnIMv/XhATWwanvnuVvzJ1LHO8jA6EtsdHcnHPsz9g6FYsweJ3QWDb7vRJflwDk9T7cfXKjqhZ3wj95isNxiIlqgD4FbbawWfOUmvSKZYevCsa+hPSgQ9diIA+cU5YS+1luA2X+wb6cBvJ3Fm6w==", "KYU7Gy/sWGFB5vV991yjPeUMj3dcKYW6stMWQFP6eZ7H7fD5C/7q15A+uD4rAf1seuiIxr6jaZDcbbxKAphJMw==", new DateTime(2022, 3, 24, 20, 49, 5, 972, DateTimeKind.Utc).AddTicks(8087) });
        }
    }
}
