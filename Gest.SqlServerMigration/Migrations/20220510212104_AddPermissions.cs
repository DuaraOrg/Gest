using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gest.SqlServerMigration.Migrations
{
    public partial class AddPermissions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Permissions",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: new Guid("453412a3-578b-446b-9406-bd7077bdce01"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 21, 3, 999, DateTimeKind.Utc).AddTicks(5231), new DateTime(2022, 5, 10, 21, 21, 3, 999, DateTimeKind.Utc).AddTicks(5228) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("654412a3-578b-446b-9406-bd7077bdce01"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 21, 3, 999, DateTimeKind.Utc).AddTicks(5236), new DateTime(2022, 5, 10, 21, 21, 3, 999, DateTimeKind.Utc).AddTicks(5234) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 21, 3, 999, DateTimeKind.Utc).AddTicks(5226), new DateTime(2022, 5, 10, 21, 21, 3, 999, DateTimeKind.Utc).AddTicks(5223) });

            migrationBuilder.UpdateData(
                table: "UserCompanies",
                keyColumns: new[] { "CompanyId", "UserId" },
                keyValues: new object[] { new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"), new Guid("d5ccad5b-6cbc-4993-96e3-e8cd7c76d8b9") },
                column: "Joined",
                value: new DateTime(2022, 5, 10, 21, 21, 3, 999, DateTimeKind.Utc).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5ccad5b-6cbc-4993-96e3-e8cd7c76d8b9"),
                columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt", "Permissions", "Role", "UpdatedAt" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 21, 3, 999, DateTimeKind.Utc).AddTicks(5109), "URtlu7uoF+xdNT/TS2XkYnaeAj9pygM/eiAg1nfUbQI+hg1Jrb8ebRoWnBmJ/RlcNp0xnl/eMEfze6vQsDAiHMxN7u0+X5fAFRh9AfDN8L15PDyhLGnwIErVRcv9BAw1cH5oVRWaIJIDCPAAwETq+DR2dvLhU62u6QNqqLfI31/nVXEq5Gh2QTTlES492/4GaWbgpsy8orWbYUUPzekChgCuwnV7ApGEWU0AAGjRGrVW7z7fSLTiaypRnbL39a4U4jt2gQDOymVnKS2c3dPl71OfaPLwPmSov6lIaU2iHSf8q6OiRporO05NwchKh6FVNqeHqH9XbBHVuASDYXZyVw==", "g2KIi7hfBsP4z5gu8om1ft/+4b44OOv1Tx4LXFfyvxuGrNA6olRY3u+jpucyoq6tHvzcH0oqNIHk2vyKJHpd0w==", "Ventes:Lire,Créer,Mettre à jour,Supprimer;Caisse:Lire,Créer,Mettre à jour,Supprimer;Stock:Lire,Créer,Mettre à jour,Supprimer;Clients:Lire,Créer,Mettre à jour,Supprimer;Rapports:Lire,Créer,Mettre à jour,Supprimer", "Superadmin", new DateTime(2022, 5, 10, 21, 21, 3, 999, DateTimeKind.Utc).AddTicks(5085) });
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
    }
}
