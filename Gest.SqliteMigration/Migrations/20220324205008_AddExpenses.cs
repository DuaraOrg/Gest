using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gest.SqliteMigration.Migrations
{
    public partial class AddExpenses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClientNames",
                table: "Payments",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Payments",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: new Guid("453412a3-578b-446b-9406-bd7077bdce01"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 24, 20, 50, 7, 916, DateTimeKind.Utc).AddTicks(9463), new DateTime(2022, 3, 24, 20, 50, 7, 916, DateTimeKind.Utc).AddTicks(9461) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("654412a3-578b-446b-9406-bd7077bdce01"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 24, 20, 50, 7, 916, DateTimeKind.Utc).AddTicks(9467), new DateTime(2022, 3, 24, 20, 50, 7, 916, DateTimeKind.Utc).AddTicks(9465) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 24, 20, 50, 7, 916, DateTimeKind.Utc).AddTicks(9460), new DateTime(2022, 3, 24, 20, 50, 7, 916, DateTimeKind.Utc).AddTicks(9458) });

            migrationBuilder.UpdateData(
                table: "UserCompanies",
                keyColumns: new[] { "CompanyId", "UserId" },
                keyValues: new object[] { new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"), new Guid("d5ccad5b-6cbc-4993-96e3-e8cd7c76d8b9") },
                column: "Joined",
                value: new DateTime(2022, 3, 24, 20, 50, 7, 916, DateTimeKind.Utc).AddTicks(9448));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5ccad5b-6cbc-4993-96e3-e8cd7c76d8b9"),
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 24, 20, 50, 7, 916, DateTimeKind.Utc).AddTicks(9438), "uBu5PbNtTRhaSIsGKg+tUY9Xgkgz3B2tg5KkzLHSBI2byBRQWpGQuBCzwXjXL56XsXAbHpBaLknqtk76a6HJwJ/QxQYjFP/yw1lJPtfy5tgrFpR/MOPzi60YUbMODO/sOx8oBsb9DACHirbuFSWMG0Be+Lqy5YMQ5JlDfZoCR8JdtU8L8GY30xnXzls8tz745kt5t+CAwMNM2n2onPfzYvKE4+Xwwd5buXgD17/VIeD2LVNp2/3ZJM/iZL3rv/qQf7qBCF3xkrD3auu/5INiCWzsigzypZ3SJUotNGL3YjVL0euzQusjRx7D7dYOl6x0Zexr+UuyEXvtK92zs8agcg==", "4PK83ckdchjBdJzR/7soFJTkEnChBtiEoTPavqZ2au2losiEerud21wHXBlqKtmrp4D83aHyyks0kKaMovwi3Q==", new DateTime(2022, 3, 24, 20, 50, 7, 916, DateTimeKind.Utc).AddTicks(9412) });
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
        }
    }
}
