using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gest.Core.Data.Migrations
{
    public partial class UpdateStockMovements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Qty",
                table: "StockMouvements",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");

            migrationBuilder.AddColumn<decimal>(
                name: "NewBuyingPrice",
                table: "StockMouvements",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "NewSellingPrice",
                table: "StockMouvements",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<double>(
                name: "NewStock",
                table: "StockMouvements",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<decimal>(
                name: "PrevBuyingPrice",
                table: "StockMouvements",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PrevSellingPrice",
                table: "StockMouvements",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<double>(
                name: "PrevStock",
                table: "StockMouvements",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: new Guid("453412a3-578b-446b-9406-bd7077bdce01"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 7, 7, 10, 35, 293, DateTimeKind.Utc).AddTicks(7269), new DateTime(2022, 3, 7, 7, 10, 35, 293, DateTimeKind.Utc).AddTicks(7266) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("654412a3-578b-446b-9406-bd7077bdce01"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 7, 7, 10, 35, 293, DateTimeKind.Utc).AddTicks(7275), new DateTime(2022, 3, 7, 7, 10, 35, 293, DateTimeKind.Utc).AddTicks(7271) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 7, 7, 10, 35, 293, DateTimeKind.Utc).AddTicks(7263), new DateTime(2022, 3, 7, 7, 10, 35, 293, DateTimeKind.Utc).AddTicks(7260) });

            migrationBuilder.UpdateData(
                table: "UserCompanies",
                keyColumns: new[] { "CompanyId", "UserId" },
                keyValues: new object[] { new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"), new Guid("d5ccad5b-6cbc-4993-96e3-e8cd7c76d8b9") },
                column: "Joined",
                value: new DateTime(2022, 3, 7, 7, 10, 35, 293, DateTimeKind.Utc).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5ccad5b-6cbc-4993-96e3-e8cd7c76d8b9"),
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 7, 7, 10, 35, 293, DateTimeKind.Utc).AddTicks(7245), "ljP12Z0iDP16WdWoBlamyEjBqvnPJlZikcbBHa6B9kreFc1WQHI1ZacbEdLVNumqaPQcqZ5TzilUziYNvC3BrKXrnSGx53w//jr2b9g7kXBB3bgpu/FDE39kU3X4CbFW4P43i8MCX5pfdlkGDN3oCYlUQdOm8m2PjMhZVrqbLEjs0+KAkpQjauQUmXxFgeXRFYDIiZU2bsLTqWQPagD6BYF8EZA2eaMLKBP7nIBPjoOIQ8ztlx/RwsrFcBA6Kr7t3F5bWSsum+HRt68okMEshVI8ZZD4f4M2nUR7cgO5MHQA1KRJBL+UXVDEE7oazvY87buxYbgX2gvvULZxteFNMw==", "SZD8vt7x1bQHGH1yn+hHdc3UKd9t/RXBjWdaszLe2h/HHh4UAjHS17khhijTZ/TJ7vlTFWvjtcomqsmmhVL4Gw==", new DateTime(2022, 3, 7, 7, 10, 35, 293, DateTimeKind.Utc).AddTicks(7212) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NewBuyingPrice",
                table: "StockMouvements");

            migrationBuilder.DropColumn(
                name: "NewSellingPrice",
                table: "StockMouvements");

            migrationBuilder.DropColumn(
                name: "NewStock",
                table: "StockMouvements");

            migrationBuilder.DropColumn(
                name: "PrevBuyingPrice",
                table: "StockMouvements");

            migrationBuilder.DropColumn(
                name: "PrevSellingPrice",
                table: "StockMouvements");

            migrationBuilder.DropColumn(
                name: "PrevStock",
                table: "StockMouvements");

            migrationBuilder.AlterColumn<decimal>(
                name: "Qty",
                table: "StockMouvements",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: new Guid("453412a3-578b-446b-9406-bd7077bdce01"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 4, 8, 49, 36, 578, DateTimeKind.Utc).AddTicks(2551), new DateTime(2022, 3, 4, 8, 49, 36, 578, DateTimeKind.Utc).AddTicks(2546) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("654412a3-578b-446b-9406-bd7077bdce01"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 4, 8, 49, 36, 578, DateTimeKind.Utc).AddTicks(2561), new DateTime(2022, 3, 4, 8, 49, 36, 578, DateTimeKind.Utc).AddTicks(2553) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 4, 8, 49, 36, 578, DateTimeKind.Utc).AddTicks(2543), new DateTime(2022, 3, 4, 8, 49, 36, 578, DateTimeKind.Utc).AddTicks(2538) });

            migrationBuilder.UpdateData(
                table: "UserCompanies",
                keyColumns: new[] { "CompanyId", "UserId" },
                keyValues: new object[] { new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"), new Guid("d5ccad5b-6cbc-4993-96e3-e8cd7c76d8b9") },
                column: "Joined",
                value: new DateTime(2022, 3, 4, 8, 49, 36, 578, DateTimeKind.Utc).AddTicks(2525));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5ccad5b-6cbc-4993-96e3-e8cd7c76d8b9"),
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 3, 4, 8, 49, 36, 578, DateTimeKind.Utc).AddTicks(2515), "SLbUaGMvd4TMQyuw1+v3vbW4uMJXd6PngfnJ0GoICgQVGQuLAxnj5noIaMewqSWR/oPu0UPp9FYAWhQ6lUFYznXeE4KidZwvtUQfuay3Ko21YDHtg3EesiiBOmpPQIp/hcouD6ZqE0veR7bwv5ukkfiMEWwhZxVUFCiFY8Dwd9zwH3IUNZy7TQkDGqKCZ9L1toSAz0dWQeWWtGHf6PnEfS4m1lGFmhwRKG6P29UH3PeWLe4RX+prGWC3HulILaXQXy+LnljoRAFGoLxDcb7BtxaKuiI2nFdD5HoPFYCvsqeIN4g9KftoXSD70gIekPiajeyFVcpqPteGfxmk2T2csg==", "B8Thl3l1wXyf27URJzi2le/UNidO16KlrnLb8kd8B8cFE9bHd/9DYzB9RlhO1aGE0c+XUwONFuxe43fuPax6Yg==", new DateTime(2022, 3, 4, 8, 49, 36, 578, DateTimeKind.Utc).AddTicks(2451) });
        }
    }
}
