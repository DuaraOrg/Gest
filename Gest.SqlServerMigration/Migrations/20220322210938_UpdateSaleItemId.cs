using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gest.SqlServerMigration.Migrations
{
    public partial class UpdateSaleItemId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SaleItem",
                table: "SaleItem");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SaleItem",
                table: "SaleItem",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: new Guid("453412a3-578b-446b-9406-bd7077bdce01"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 22, 21, 9, 37, 828, DateTimeKind.Utc).AddTicks(2804), new DateTime(2022, 3, 22, 21, 9, 37, 828, DateTimeKind.Utc).AddTicks(2800) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("654412a3-578b-446b-9406-bd7077bdce01"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 22, 21, 9, 37, 828, DateTimeKind.Utc).AddTicks(2811), new DateTime(2022, 3, 22, 21, 9, 37, 828, DateTimeKind.Utc).AddTicks(2807) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 22, 21, 9, 37, 828, DateTimeKind.Utc).AddTicks(2798), new DateTime(2022, 3, 22, 21, 9, 37, 828, DateTimeKind.Utc).AddTicks(2792) });

            migrationBuilder.UpdateData(
                table: "UserCompanies",
                keyColumns: new[] { "CompanyId", "UserId" },
                keyValues: new object[] { new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"), new Guid("d5ccad5b-6cbc-4993-96e3-e8cd7c76d8b9") },
                column: "Joined",
                value: new DateTime(2022, 3, 22, 21, 9, 37, 828, DateTimeKind.Utc).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5ccad5b-6cbc-4993-96e3-e8cd7c76d8b9"),
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 22, 21, 9, 37, 828, DateTimeKind.Utc).AddTicks(2771), "5+/0MoJ1mup9FR+xhIPpCX7Y6oLHGLbfUQuYoiGtf6I4ti4ti77ldZXyS6VbgRAPNgDh9HscXGx/vsHFGC1m3R5MNtydhVbQfWPn4/VE1KdpyFNbHJSVYnlcGbfOCnjGNtnm0Dv0wnO/D1Jng5/qQqe0GLrXuwJOUZbWIX1BOnk+GOuzHpsQvR0phpXijIKVC3BhIRCMq9l4hYAw8AWJwzw5iPOP0BRBhbHybTflLc0/X0DN+/SUANDtasjbTExbTIj6xoB8rVmEtAbZ3hlHRjwuXg5ubMTWyIKa+oRAxB51B4yzOWsoNKnZhdysfMDgVXnFgWjxT/rv1iR0AhNfFw==", "u9w/IBLCwNweSFLxltYPjBj8hRZ77DshLwKttpixHgqgVtDao24XTroPYuNp8uG+qKnjVitAIJgNpR/BfouP4w==", new DateTime(2022, 3, 22, 21, 9, 37, 828, DateTimeKind.Utc).AddTicks(2747) });

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_SaleItem",
                table: "SaleItem",
                columns: new[] { "SaleId", "Id" });

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
    }
}
