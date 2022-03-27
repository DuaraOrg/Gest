using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gest.SqliteMigration.Migrations
{
    public partial class AddTitleToPayment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Expense_Amount",
                table: "Wallets",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "Expense_LastUpdated",
                table: "Wallets",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Payments",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: new Guid("453412a3-578b-446b-9406-bd7077bdce01"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 27, 8, 22, 4, 912, DateTimeKind.Utc).AddTicks(53), new DateTime(2022, 3, 27, 8, 22, 4, 912, DateTimeKind.Utc).AddTicks(48) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("654412a3-578b-446b-9406-bd7077bdce01"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 27, 8, 22, 4, 912, DateTimeKind.Utc).AddTicks(58), new DateTime(2022, 3, 27, 8, 22, 4, 912, DateTimeKind.Utc).AddTicks(55) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 27, 8, 22, 4, 912, DateTimeKind.Utc).AddTicks(45), new DateTime(2022, 3, 27, 8, 22, 4, 912, DateTimeKind.Utc).AddTicks(41) });

            migrationBuilder.UpdateData(
                table: "UserCompanies",
                keyColumns: new[] { "CompanyId", "UserId" },
                keyValues: new object[] { new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"), new Guid("d5ccad5b-6cbc-4993-96e3-e8cd7c76d8b9") },
                column: "Joined",
                value: new DateTime(2022, 3, 27, 8, 22, 4, 912, DateTimeKind.Utc).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5ccad5b-6cbc-4993-96e3-e8cd7c76d8b9"),
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 27, 8, 22, 4, 912, DateTimeKind.Utc).AddTicks(17), "HT4pC3hL/6oIfO8H6TbibOQF9PAhajmzymtuO//m/rFH6uE47kXliYl2TIDef+JCtk8bSSwdydvbcx+5Y0ZVTmNrLnDTztYgmehA0ndJWikggqzRT2S/DI1P7I8xhPwonOYlcvJzegtAKSgYJakZQeMMI0+TlEcY2phP3nDoIL+o9n/NHkNgGZVObn+3cXi2iAN1W+v2I485jxjMUT0Lfvop/xUnK/SDMk+MGIWTP2ZOA27hI+dEY0tyCQTzRmAImolNMWpT/e9ZXWmFtFZiUdtTrU6+1Y0qmGiVt3/4P9v2FQQW4UKIJPLPnWU9Qt6yerkRN8cr20W7Z+pWvcHAhg==", "WCvgYRyfQZnUdYiDUe32QrI4+butQkAROn8XCgV4y1Fqq1pTaGw4KKOsPRLGfEBe4Rd0tOQRSyYxNfOv5ux8zA==", new DateTime(2022, 3, 27, 8, 22, 4, 911, DateTimeKind.Utc).AddTicks(9982) });
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
    }
}
