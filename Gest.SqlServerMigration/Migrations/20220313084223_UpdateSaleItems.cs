using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gest.SqlServerMigration.Migrations
{
    public partial class UpdateSaleItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SaleId",
                table: "Sales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "BuyingUnitPricePerUnitOfMeasure",
                table: "SaleItem",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "PayementId",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: new Guid("453412a3-578b-446b-9406-bd7077bdce01"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 13, 8, 42, 22, 753, DateTimeKind.Utc).AddTicks(8250), new DateTime(2022, 3, 13, 8, 42, 22, 753, DateTimeKind.Utc).AddTicks(8243) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("654412a3-578b-446b-9406-bd7077bdce01"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 13, 8, 42, 22, 753, DateTimeKind.Utc).AddTicks(8268), new DateTime(2022, 3, 13, 8, 42, 22, 753, DateTimeKind.Utc).AddTicks(8257) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 13, 8, 42, 22, 753, DateTimeKind.Utc).AddTicks(8240), new DateTime(2022, 3, 13, 8, 42, 22, 753, DateTimeKind.Utc).AddTicks(8237) });

            migrationBuilder.UpdateData(
                table: "UserCompanies",
                keyColumns: new[] { "CompanyId", "UserId" },
                keyValues: new object[] { new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"), new Guid("d5ccad5b-6cbc-4993-96e3-e8cd7c76d8b9") },
                column: "Joined",
                value: new DateTime(2022, 3, 13, 8, 42, 22, 753, DateTimeKind.Utc).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5ccad5b-6cbc-4993-96e3-e8cd7c76d8b9"),
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 13, 8, 42, 22, 753, DateTimeKind.Utc).AddTicks(8206), "6ZJ8cyZeZs250u7jqCcPOowFQOeFmdWt8oKsWAAb+4ZciC88btOS6KJ3ICtsFY1kb/dqxgx1LUTWpOQ06mMeAVKnzGHOVXYGJeWEyy+CPmCScyHH4uTUQ3Naz7rACehWb8CBbIIZngurVPoMLxaALqwhvAPhr5VG6wDkUMoiEqs4QDTMsqJMeI7uipgSasVV4w0/ea4OBJUKVPgOIpQa71w5hiBxYC/n67S11+Tthg07Es1njh+4eIavfqG46LgB7Ze1wDAZTHA3Trst0vTnqhE5qvzybtKAWgeAFE7M0nGxBFQTZ6F7JDxyg9vv+QRzEmu96u+INXDn6iqB6nY9rA==", "Gi94McWZ28QUvgqBcZCaChYVacwk6FaLJrpens16h5HdIxnsQkSQJoT416N+kEFbcG7+WiK3dRrIhOqEH9ikRA==", new DateTime(2022, 3, 13, 8, 42, 22, 753, DateTimeKind.Utc).AddTicks(8161) });
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
                values: new object[] { new DateTime(2022, 3, 8, 18, 58, 14, 157, DateTimeKind.Utc).AddTicks(8915), new DateTime(2022, 3, 8, 18, 58, 14, 157, DateTimeKind.Utc).AddTicks(8909) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("654412a3-578b-446b-9406-bd7077bdce01"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 8, 18, 58, 14, 157, DateTimeKind.Utc).AddTicks(8922), new DateTime(2022, 3, 8, 18, 58, 14, 157, DateTimeKind.Utc).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 8, 18, 58, 14, 157, DateTimeKind.Utc).AddTicks(8906), new DateTime(2022, 3, 8, 18, 58, 14, 157, DateTimeKind.Utc).AddTicks(8903) });

            migrationBuilder.UpdateData(
                table: "UserCompanies",
                keyColumns: new[] { "CompanyId", "UserId" },
                keyValues: new object[] { new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"), new Guid("d5ccad5b-6cbc-4993-96e3-e8cd7c76d8b9") },
                column: "Joined",
                value: new DateTime(2022, 3, 8, 18, 58, 14, 157, DateTimeKind.Utc).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5ccad5b-6cbc-4993-96e3-e8cd7c76d8b9"),
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 8, 18, 58, 14, 157, DateTimeKind.Utc).AddTicks(8874), "OntNV7WL9lhYeZ5LXVxX84XlcBv+d4mC8TpEUTZyD+xwbaLGwWJwcidKq7C3nXEasKrU+e09Pi7wu9BNgqDVBdFtogHMTcegtNzinL6gesSPsICv9XRiQo0nw60E8TmH/2yLJFcOTauDNMHiRFz6d+1dKVNhV92kHGrCIF7ODmuOk0yv2X2jzBgF6Dx4AdMxYZHS54po9dXwdUh/39ss3+JEqDyWtiQNDxK2vL6qXs85laKgtiOcUrE7wvEkfkwc1meyo0aZEzyukpQybCXinMQ2eCnOTYE5rVFWMxdSkRBunW/wqtWUUfaaPQ9I/zBHE+p4+nEa7cVggdEVIlqknA==", "sp66BJ8qsud3AkG2uSmiUD/b3BgX2UWwbBIJuFcYHvBsn75oxcy/m/AfoaTEQyirfzRygH0VIS6uxmRshZ9/8A==", new DateTime(2022, 3, 8, 18, 58, 14, 157, DateTimeKind.Utc).AddTicks(8847) });
        }
    }
}
