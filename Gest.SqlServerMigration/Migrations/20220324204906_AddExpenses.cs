using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gest.SqlServerMigration.Migrations
{
    public partial class AddExpenses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClientNames",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientNames",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Payments");

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
        }
    }
}
