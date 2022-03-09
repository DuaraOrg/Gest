using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gest.SqlServerMigration.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfileUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordSalt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wallets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Cash_Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Cash_LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Credit_Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Credit_LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Bank_AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bank_Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Bank_LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wallets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FCToDollarRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    WalletId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companies_Wallets_WalletId",
                        column: x => x.WalletId,
                        principalTable: "Wallets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WalletMovement",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FromWalletId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FromAccountType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToWalletId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ToAccountType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WalletMovement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WalletMovement_Wallets_ToWalletId",
                        column: x => x.ToWalletId,
                        principalTable: "Wallets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FCToDollarRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Names = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WalletId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clients_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clients_Wallets_WalletId",
                        column: x => x.WalletId,
                        principalTable: "Wallets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserCompanies",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Joined = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UnitOfMeasure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stock_Minimum = table.Column<double>(type: "float", nullable: false),
                    Stock_Maximum = table.Column<double>(type: "float", nullable: true),
                    Stock_Qty = table.Column<double>(type: "float", nullable: false),
                    Conditionnement_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Conditionnement_QtyPerUnitOfMeasure = table.Column<double>(type: "float", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price_BuyingPricePerUnitOfMeasure = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Price_BuyingPricePerConditionnement = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Price_SellingPricePerUnitOfMeasure = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Price_SellingPricePerConditionnement = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Articles_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PayStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeliverStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountPaid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SellerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sales_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Sales_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Sales_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Sales_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Sales_Users_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StockMouvements",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Qty = table.Column<double>(type: "float", nullable: false),
                    PrevStock = table.Column<double>(type: "float", nullable: false),
                    NewStock = table.Column<double>(type: "float", nullable: false),
                    NewBuyingPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NewSellingPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrevBuyingPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrevSellingPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockMouvements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockMouvements_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AccountType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SaleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Payments_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_Sales_SaleId",
                        column: x => x.SaleId,
                        principalTable: "Sales",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Payments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SaleItem",
                columns: table => new
                {
                    SaleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QtyInUnitOfMeasure = table.Column<double>(type: "float", nullable: false),
                    QtyDelivered = table.Column<double>(type: "float", nullable: false),
                    UnitPricePerUnitOfMeasure = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleItem", x => new { x.SaleId, x.Id });
                    table.ForeignKey(
                        name: "FK_SaleItem_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SaleItem_Sales_SaleId",
                        column: x => x.SaleId,
                        principalTable: "Sales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Adress", "CreatedAt", "FCToDollarRate", "Name", "UpdatedAt", "WalletId" },
                values: new object[] { new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"), "Bunia", new DateTime(2022, 3, 8, 18, 58, 14, 157, DateTimeKind.Utc).AddTicks(8906), 2000m, "Ets TUUNGANE", new DateTime(2022, 3, 8, 18, 58, 14, 157, DateTimeKind.Utc).AddTicks(8903), null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "PhoneNumber", "ProfileUrl", "UpdatedAt" },
                values: new object[] { new Guid("d5ccad5b-6cbc-4993-96e3-e8cd7c76d8b9"), new DateTime(2022, 3, 8, 18, 58, 14, 157, DateTimeKind.Utc).AddTicks(8874), "admin@swala.com", "Admin", "Swala", "OntNV7WL9lhYeZ5LXVxX84XlcBv+d4mC8TpEUTZyD+xwbaLGwWJwcidKq7C3nXEasKrU+e09Pi7wu9BNgqDVBdFtogHMTcegtNzinL6gesSPsICv9XRiQo0nw60E8TmH/2yLJFcOTauDNMHiRFz6d+1dKVNhV92kHGrCIF7ODmuOk0yv2X2jzBgF6Dx4AdMxYZHS54po9dXwdUh/39ss3+JEqDyWtiQNDxK2vL6qXs85laKgtiOcUrE7wvEkfkwc1meyo0aZEzyukpQybCXinMQ2eCnOTYE5rVFWMxdSkRBunW/wqtWUUfaaPQ9I/zBHE+p4+nEa7cVggdEVIlqknA==", "sp66BJ8qsud3AkG2uSmiUD/b3BgX2UWwbBIJuFcYHvBsn75oxcy/m/AfoaTEQyirfzRygH0VIS6uxmRshZ9/8A==", null, null, new DateTime(2022, 3, 8, 18, 58, 14, 157, DateTimeKind.Utc).AddTicks(8847) });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "CompanyId", "CreatedAt", "FCToDollarRate", "Name", "UpdatedAt" },
                values: new object[] { new Guid("453412a3-578b-446b-9406-bd7077bdce01"), new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"), new DateTime(2022, 3, 8, 18, 58, 14, 157, DateTimeKind.Utc).AddTicks(8915), 2000m, "Default", new DateTime(2022, 3, 8, 18, 58, 14, 157, DateTimeKind.Utc).AddTicks(8909) });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "CompanyId", "CreatedAt", "Email", "Names", "Phone", "Type", "UpdatedAt", "WalletId" },
                values: new object[] { new Guid("654412a3-578b-446b-9406-bd7077bdce01"), new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"), new DateTime(2022, 3, 8, 18, 58, 14, 157, DateTimeKind.Utc).AddTicks(8922), "clientanonyme@swala.com", "Client Anonyme", null, null, new DateTime(2022, 3, 8, 18, 58, 14, 157, DateTimeKind.Utc).AddTicks(8919), null });

            migrationBuilder.InsertData(
                table: "UserCompanies",
                columns: new[] { "CompanyId", "UserId", "Joined", "Role", "UpdatedAt" },
                values: new object[] { new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"), new Guid("d5ccad5b-6cbc-4993-96e3-e8cd7c76d8b9"), new DateTime(2022, 3, 8, 18, 58, 14, 157, DateTimeKind.Utc).AddTicks(8883), "Propriétaire", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_BranchId",
                table: "Articles",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CompanyId",
                table: "Articles",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_Name",
                table: "Articles",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Branches_CompanyId",
                table: "Branches",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_CompanyId",
                table: "Clients",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_WalletId",
                table: "Clients",
                column: "WalletId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_WalletId",
                table: "Companies",
                column: "WalletId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_ClientId",
                table: "Payments",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_CompanyId",
                table: "Payments",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_SaleId",
                table: "Payments",
                column: "SaleId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_UserId",
                table: "Payments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleItem_ArticleId",
                table: "SaleItem",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_ArticleId",
                table: "Sales",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_BranchId",
                table: "Sales",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_ClientId",
                table: "Sales",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_CompanyId",
                table: "Sales",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_SellerId",
                table: "Sales",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_StockMouvements_ArticleId",
                table: "StockMouvements",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCompanies_CompanyId",
                table: "UserCompanies",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WalletMovement_ToWalletId",
                table: "WalletMovement",
                column: "ToWalletId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "SaleItem");

            migrationBuilder.DropTable(
                name: "StockMouvements");

            migrationBuilder.DropTable(
                name: "UserCompanies");

            migrationBuilder.DropTable(
                name: "WalletMovement");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Wallets");
        }
    }
}
