using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gest.Core.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Adress = table.Column<string>(type: "TEXT", nullable: true),
                    FCToDollarRate = table.Column<decimal>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    ProfileUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: false),
                    PasswordSalt = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    FCToDollarRate = table.Column<decimal>(type: "TEXT", nullable: false),
                    CompanyId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Branches_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserCompanies",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CompanyId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Role = table.Column<string>(type: "TEXT", nullable: false),
                    Joined = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCompanies", x => new { x.UserId, x.CompanyId });
                    table.ForeignKey(
                        name: "FK_UserCompanies_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCompanies_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Adress", "CreatedAt", "FCToDollarRate", "Name", "UpdatedAt" },
                values: new object[] { new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"), "Bunia", new DateTime(2022, 3, 2, 11, 23, 23, 14, DateTimeKind.Utc).AddTicks(6710), 2000m, "Ets TUUNGANE", new DateTime(2022, 3, 2, 11, 23, 23, 14, DateTimeKind.Utc).AddTicks(6706) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfileUrl", "UpdatedAt" },
                values: new object[] { new Guid("d5ccad5b-6cbc-4993-96e3-e8cd7c76d8b9"), new DateTime(2022, 3, 2, 11, 23, 23, 14, DateTimeKind.Utc).AddTicks(6681), "admin@swala.com", "Admin", "Swala", "gVO+geip618dEdoz47JEKqVlgOQs9hCH4SB1v+jP1bQDgoKjUAVC0QVz3BcFNCylkR7V2TDQyu+dB5GyVACconzpm3j4xS+F8mPUQcTeQvgI3+SgrqDSX1jx7tw3JZDt6XfZFBbwIOdZACBeUKyMfODRKgvuJ5icPwJJhd5wlEMnjH7IUiBFBeSfWiUVSz+NQlf1lvrPa4la/+Hgm1qXCl5tpzi1/gDH5OOh4E/PLp7XQardleOLM31vHF2ngv8OP0wWrsXHGbORYSFdxIVcLqQBha7j76kRIqVpR30r71oDV69lpoSU5lFEOuKhf9VRS0ErHC3xattaIqwMYxUKBw==", "/5Zo2sYD6LHii+LRoxUJ2NJFHDP8N4x5Vz3JiWbMgvYM0Io88zdDPCM7byNlb6rKr2t6qEYlvlT/RQ0HG5dUmQ==", null, null, new DateTime(2022, 3, 2, 11, 23, 23, 14, DateTimeKind.Utc).AddTicks(6630) });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "CompanyId", "CreatedAt", "FCToDollarRate", "Name", "UpdatedAt" },
                values: new object[] { new Guid("453412a3-578b-446b-9406-bd7077bdce01"), new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"), new DateTime(2022, 3, 2, 11, 23, 23, 14, DateTimeKind.Utc).AddTicks(6718), 2000m, "Default", new DateTime(2022, 3, 2, 11, 23, 23, 14, DateTimeKind.Utc).AddTicks(6712) });

            migrationBuilder.InsertData(
                table: "UserCompanies",
                columns: new[] { "CompanyId", "UserId", "Joined", "Role", "UpdatedAt" },
                values: new object[] { new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"), new Guid("d5ccad5b-6cbc-4993-96e3-e8cd7c76d8b9"), new DateTime(2022, 3, 2, 11, 23, 23, 14, DateTimeKind.Utc).AddTicks(6692), "Propriétaire", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_Branches_CompanyId",
                table: "Branches",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCompanies_CompanyId",
                table: "UserCompanies",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "UserCompanies");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
