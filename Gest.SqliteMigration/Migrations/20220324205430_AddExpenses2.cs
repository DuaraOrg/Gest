using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gest.SqliteMigration.Migrations
{
    public partial class AddExpenses2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Payments",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: new Guid("453412a3-578b-446b-9406-bd7077bdce01"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 24, 20, 54, 29, 476, DateTimeKind.Utc).AddTicks(8559), new DateTime(2022, 3, 24, 20, 54, 29, 476, DateTimeKind.Utc).AddTicks(8518) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("654412a3-578b-446b-9406-bd7077bdce01"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 24, 20, 54, 29, 476, DateTimeKind.Utc).AddTicks(8565), new DateTime(2022, 3, 24, 20, 54, 29, 476, DateTimeKind.Utc).AddTicks(8561) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 24, 20, 54, 29, 476, DateTimeKind.Utc).AddTicks(8516), new DateTime(2022, 3, 24, 20, 54, 29, 476, DateTimeKind.Utc).AddTicks(8494) });

            migrationBuilder.UpdateData(
                table: "UserCompanies",
                keyColumns: new[] { "CompanyId", "UserId" },
                keyValues: new object[] { new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"), new Guid("d5ccad5b-6cbc-4993-96e3-e8cd7c76d8b9") },
                column: "Joined",
                value: new DateTime(2022, 3, 24, 20, 54, 29, 476, DateTimeKind.Utc).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5ccad5b-6cbc-4993-96e3-e8cd7c76d8b9"),
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 24, 20, 54, 29, 476, DateTimeKind.Utc).AddTicks(8461), "2Dl7GJm/3Ac+gO80U5dnz6NudwYhNpVdiMRLVt0q9fBDF34cgL0aQd9Z4FM6asuMoxiTHCxYNJnYBaQENOeIeoH4Q/UuaLKtdRf6BD/+laoPsk0rEWjoTyrH1rmefE+3OosuO0Dcb1F4FuIHSoersvooTQo9QEgqjtel90/6mD9V/qJs3W2HzwgOltb0Rrg2NguTYXwuNFOq5dA2iJtWCazONvwHl49W6Ah12WH1bdjI7DTTJ+MzsP2kG8uATSXRzC4cOLgRa8oSIF5Z1Jv/qq3cpHK6jYxAzRSdMxS7mUMCwaGQ7Vgq+v7JNywcpd6LhnGBsleCggWmIEKwtL63Vw==", "JAT2wIhdInuJ8YjhFtb+xCKJ7uoq/dNzlWvCvdOlb84ogd716GixkOjvS1ud6h9pe0uFLbCd+woBjklfShBKEg==", new DateTime(2022, 3, 24, 20, 54, 29, 476, DateTimeKind.Utc).AddTicks(8436) });
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
    }
}
