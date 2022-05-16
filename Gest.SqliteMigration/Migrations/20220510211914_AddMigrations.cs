using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gest.SqliteMigration.Migrations
{
    public partial class AddMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Permissions",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: new Guid("453412a3-578b-446b-9406-bd7077bdce01"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 19, 14, 372, DateTimeKind.Utc).AddTicks(9575), new DateTime(2022, 5, 10, 21, 19, 14, 372, DateTimeKind.Utc).AddTicks(9573) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("654412a3-578b-446b-9406-bd7077bdce01"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 19, 14, 372, DateTimeKind.Utc).AddTicks(9578), new DateTime(2022, 5, 10, 21, 19, 14, 372, DateTimeKind.Utc).AddTicks(9576) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 19, 14, 372, DateTimeKind.Utc).AddTicks(9571), new DateTime(2022, 5, 10, 21, 19, 14, 372, DateTimeKind.Utc).AddTicks(9569) });

            migrationBuilder.UpdateData(
                table: "UserCompanies",
                keyColumns: new[] { "CompanyId", "UserId" },
                keyValues: new object[] { new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"), new Guid("d5ccad5b-6cbc-4993-96e3-e8cd7c76d8b9") },
                column: "Joined",
                value: new DateTime(2022, 5, 10, 21, 19, 14, 372, DateTimeKind.Utc).AddTicks(9558));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5ccad5b-6cbc-4993-96e3-e8cd7c76d8b9"),
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt", "Permissions", "Role", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 19, 14, 372, DateTimeKind.Utc).AddTicks(9478), "DiEg/IZu5FiQ8k1qnggsbW0ZAqGvsZ8T4hjeY+YGPPc5S3ROt5KzIm4W/X+wlMYxsCUet+ECv5JrTktDsd54sNwlVZhQnlyOmz9POLthr/Pk5DcHzwSzowH1Uj6NprnkuLG2r43AvX5aPy0trn1LYDywzRa/iZWgNGjLBL6NpkZDj4OI3i/+vJ4vSghi0JbgWDZT3/eEOIu85sXhIBPqB8mEWg789OgGEMrlJWzRQ9/2ECkefg74svxwpTEmpGexyUF9oDp5mN9CeV0r2dNm2tHRomNImfOy6SSwZadGBSaBBiOmL7rtf8pB+eHW+vPYgyOo6ljO/TRXvMkNGS3tUw==", "PSjr2BQTYZtC6qmA4Rf+j8MFl6ZFOKRmx65h472yPSWNZNMGpoI30ycaaaY39ZV1rSEYUlnCZHmTD7wJ5PEj4w==", "Ventes:Lire,Créer,Mettre à jour,Supprimer;Caisse:Lire,Créer,Mettre à jour,Supprimer;Stock:Lire,Créer,Mettre à jour,Supprimer;Clients:Lire,Créer,Mettre à jour,Supprimer;Rapports:Lire,Créer,Mettre à jour,Supprimer", "Superadmin", new DateTime(2022, 5, 10, 21, 19, 14, 372, DateTimeKind.Utc).AddTicks(9456) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Permissions",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

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
    }
}
