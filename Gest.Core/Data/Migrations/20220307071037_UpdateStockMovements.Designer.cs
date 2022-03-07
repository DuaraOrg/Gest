﻿// <auto-generated />
using System;
using Gest.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Gest.Core.Data.Migrations
{
    [DbContext(typeof(GestDbContext))]
    [Migration("20220307071037_UpdateStockMovements")]
    partial class UpdateStockMovements
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.2");

            modelBuilder.Entity("Gest.Core.Entities.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("BranchId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UnitOfMeasure")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("Gest.Core.Entities.Branch", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("FCToDollarRate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Branches");

                    b.HasData(
                        new
                        {
                            Id = new Guid("453412a3-578b-446b-9406-bd7077bdce01"),
                            CompanyId = new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"),
                            CreatedAt = new DateTime(2022, 3, 7, 7, 10, 35, 293, DateTimeKind.Utc).AddTicks(7269),
                            FCToDollarRate = 2000m,
                            Name = "Default",
                            UpdatedAt = new DateTime(2022, 3, 7, 7, 10, 35, 293, DateTimeKind.Utc).AddTicks(7266)
                        });
                });

            modelBuilder.Entity("Gest.Core.Entities.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Names")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("WalletId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("WalletId");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = new Guid("654412a3-578b-446b-9406-bd7077bdce01"),
                            CompanyId = new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"),
                            CreatedAt = new DateTime(2022, 3, 7, 7, 10, 35, 293, DateTimeKind.Utc).AddTicks(7275),
                            Email = "clientanonyme@swala.com",
                            Names = "Client Anonyme",
                            UpdatedAt = new DateTime(2022, 3, 7, 7, 10, 35, 293, DateTimeKind.Utc).AddTicks(7271)
                        });
                });

            modelBuilder.Entity("Gest.Core.Entities.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Adress")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("FCToDollarRate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("WalletId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("WalletId");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"),
                            Adress = "Bunia",
                            CreatedAt = new DateTime(2022, 3, 7, 7, 10, 35, 293, DateTimeKind.Utc).AddTicks(7263),
                            FCToDollarRate = 2000m,
                            Name = "Ets TUUNGANE",
                            UpdatedAt = new DateTime(2022, 3, 7, 7, 10, 35, 293, DateTimeKind.Utc).AddTicks(7260)
                        });
                });

            modelBuilder.Entity("Gest.Core.Entities.Payment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("AccountType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Amount")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("ClientId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("SaleId")
                        .HasColumnType("TEXT");

                    b.Property<string>("TransType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("SaleId");

                    b.HasIndex("UserId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Gest.Core.Entities.Sale", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("AmountPaid")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("ArticleId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("BranchId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("DeliverStatus")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PayStatus")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.HasIndex("BranchId");

                    b.HasIndex("ClientId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("UserId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("Gest.Core.Entities.StockMouvement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ArticleId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("NewBuyingPrice")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("NewSellingPrice")
                        .HasColumnType("TEXT");

                    b.Property<double>("NewStock")
                        .HasColumnType("REAL");

                    b.Property<decimal>("PrevBuyingPrice")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("PrevSellingPrice")
                        .HasColumnType("TEXT");

                    b.Property<double>("PrevStock")
                        .HasColumnType("REAL");

                    b.Property<double>("Qty")
                        .HasColumnType("REAL");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.ToTable("StockMouvements");
                });

            modelBuilder.Entity("Gest.Core.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProfileUrl")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d5ccad5b-6cbc-4993-96e3-e8cd7c76d8b9"),
                            CreatedAt = new DateTime(2022, 3, 7, 7, 10, 35, 293, DateTimeKind.Utc).AddTicks(7245),
                            Email = "admin@swala.com",
                            FirstName = "Admin",
                            LastName = "Swala",
                            PasswordHash = "ljP12Z0iDP16WdWoBlamyEjBqvnPJlZikcbBHa6B9kreFc1WQHI1ZacbEdLVNumqaPQcqZ5TzilUziYNvC3BrKXrnSGx53w//jr2b9g7kXBB3bgpu/FDE39kU3X4CbFW4P43i8MCX5pfdlkGDN3oCYlUQdOm8m2PjMhZVrqbLEjs0+KAkpQjauQUmXxFgeXRFYDIiZU2bsLTqWQPagD6BYF8EZA2eaMLKBP7nIBPjoOIQ8ztlx/RwsrFcBA6Kr7t3F5bWSsum+HRt68okMEshVI8ZZD4f4M2nUR7cgO5MHQA1KRJBL+UXVDEE7oazvY87buxYbgX2gvvULZxteFNMw==",
                            PasswordSalt = "SZD8vt7x1bQHGH1yn+hHdc3UKd9t/RXBjWdaszLe2h/HHh4UAjHS17khhijTZ/TJ7vlTFWvjtcomqsmmhVL4Gw==",
                            UpdatedAt = new DateTime(2022, 3, 7, 7, 10, 35, 293, DateTimeKind.Utc).AddTicks(7212)
                        });
                });

            modelBuilder.Entity("Gest.Core.Entities.UserCompany", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Joined")
                        .HasColumnType("TEXT");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "CompanyId");

                    b.HasIndex("CompanyId");

                    b.ToTable("UserCompanies");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("d5ccad5b-6cbc-4993-96e3-e8cd7c76d8b9"),
                            CompanyId = new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"),
                            Joined = new DateTime(2022, 3, 7, 7, 10, 35, 293, DateTimeKind.Utc).AddTicks(7251),
                            Role = "Propriétaire",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Gest.Core.Entities.Wallet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Wallets");
                });

            modelBuilder.Entity("Gest.Core.Entities.WalletMovement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Amount")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("FromAccountType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("FromWalletId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ToAccountType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ToWalletId")
                        .HasColumnType("TEXT");

                    b.Property<string>("TransType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ToWalletId");

                    b.ToTable("WalletMovement");
                });

            modelBuilder.Entity("Gest.Core.Entities.Article", b =>
                {
                    b.HasOne("Gest.Core.Entities.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gest.Core.Entities.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("Gest.Core.Entities.Conditionnement", "Conditionnement", b1 =>
                        {
                            b1.Property<Guid>("ArticleId")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<double>("QtyPerUnitOfMeasure")
                                .HasColumnType("REAL");

                            b1.HasKey("ArticleId");

                            b1.ToTable("Articles");

                            b1.WithOwner()
                                .HasForeignKey("ArticleId");
                        });

                    b.OwnsOne("Gest.Core.Entities.Pricing", "Price", b1 =>
                        {
                            b1.Property<Guid>("ArticleId")
                                .HasColumnType("TEXT");

                            b1.Property<decimal?>("BuyingPricePerConditionnement")
                                .HasColumnType("TEXT");

                            b1.Property<decimal>("BuyingPricePerUnitOfMeasure")
                                .HasColumnType("TEXT");

                            b1.Property<decimal?>("SellingPricePerConditionnement")
                                .HasColumnType("TEXT");

                            b1.Property<decimal>("SellingPricePerUnitOfMeasure")
                                .HasColumnType("TEXT");

                            b1.HasKey("ArticleId");

                            b1.ToTable("Articles");

                            b1.WithOwner()
                                .HasForeignKey("ArticleId");
                        });

                    b.OwnsOne("Gest.Core.Entities.Stock", "Stock", b1 =>
                        {
                            b1.Property<Guid>("ArticleId")
                                .HasColumnType("TEXT");

                            b1.Property<double?>("Maximum")
                                .HasColumnType("REAL");

                            b1.Property<double>("Minimum")
                                .HasColumnType("REAL");

                            b1.Property<double>("Qty")
                                .HasColumnType("REAL");

                            b1.HasKey("ArticleId");

                            b1.ToTable("Articles");

                            b1.WithOwner()
                                .HasForeignKey("ArticleId");
                        });

                    b.Navigation("Branch");

                    b.Navigation("Company");

                    b.Navigation("Conditionnement");

                    b.Navigation("Price")
                        .IsRequired();

                    b.Navigation("Stock")
                        .IsRequired();
                });

            modelBuilder.Entity("Gest.Core.Entities.Branch", b =>
                {
                    b.HasOne("Gest.Core.Entities.Company", "Company")
                        .WithMany("Branches")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Gest.Core.Entities.Client", b =>
                {
                    b.HasOne("Gest.Core.Entities.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gest.Core.Entities.Wallet", "Wallet")
                        .WithMany()
                        .HasForeignKey("WalletId");

                    b.Navigation("Company");

                    b.Navigation("Wallet");
                });

            modelBuilder.Entity("Gest.Core.Entities.Company", b =>
                {
                    b.HasOne("Gest.Core.Entities.Wallet", "Wallet")
                        .WithMany()
                        .HasForeignKey("WalletId");

                    b.Navigation("Wallet");
                });

            modelBuilder.Entity("Gest.Core.Entities.Payment", b =>
                {
                    b.HasOne("Gest.Core.Entities.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId");

                    b.HasOne("Gest.Core.Entities.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gest.Core.Entities.Sale", "Sale")
                        .WithMany("Payments")
                        .HasForeignKey("SaleId");

                    b.HasOne("Gest.Core.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Company");

                    b.Navigation("Sale");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Gest.Core.Entities.Sale", b =>
                {
                    b.HasOne("Gest.Core.Entities.Article", null)
                        .WithMany("Sales")
                        .HasForeignKey("ArticleId");

                    b.HasOne("Gest.Core.Entities.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gest.Core.Entities.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gest.Core.Entities.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gest.Core.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsMany("Gest.Core.Entities.SaleItem", "Items", b1 =>
                        {
                            b1.Property<Guid>("SaleId")
                                .HasColumnType("TEXT");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("INTEGER");

                            b1.Property<Guid>("ArticleId")
                                .HasColumnType("TEXT");

                            b1.Property<double>("QtyDelivered")
                                .HasColumnType("REAL");

                            b1.Property<double>("QtyInUnitOfMeasure")
                                .HasColumnType("REAL");

                            b1.Property<decimal>("UnitPricePerUnitOfMeasure")
                                .HasColumnType("TEXT");

                            b1.HasKey("SaleId", "Id");

                            b1.HasIndex("ArticleId");

                            b1.ToTable("SaleItem");

                            b1.HasOne("Gest.Core.Entities.Article", "Article")
                                .WithMany()
                                .HasForeignKey("ArticleId")
                                .OnDelete(DeleteBehavior.Cascade)
                                .IsRequired();

                            b1.WithOwner()
                                .HasForeignKey("SaleId");

                            b1.Navigation("Article");
                        });

                    b.Navigation("Branch");

                    b.Navigation("Client");

                    b.Navigation("Company");

                    b.Navigation("Items");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Gest.Core.Entities.StockMouvement", b =>
                {
                    b.HasOne("Gest.Core.Entities.Article", "Article")
                        .WithMany("Mouvements")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");
                });

            modelBuilder.Entity("Gest.Core.Entities.UserCompany", b =>
                {
                    b.HasOne("Gest.Core.Entities.Company", "Company")
                        .WithMany("Users")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gest.Core.Entities.User", "User")
                        .WithMany("Companies")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Gest.Core.Entities.Wallet", b =>
                {
                    b.OwnsOne("Gest.Core.Entities.Bank", "Bank", b1 =>
                        {
                            b1.Property<Guid>("WalletId")
                                .HasColumnType("TEXT");

                            b1.Property<string>("AccountNumber")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<decimal>("Amount")
                                .HasColumnType("TEXT");

                            b1.Property<DateTime>("LastUpdated")
                                .HasColumnType("TEXT");

                            b1.HasKey("WalletId");

                            b1.ToTable("Wallets");

                            b1.WithOwner()
                                .HasForeignKey("WalletId");
                        });

                    b.OwnsOne("Gest.Core.Entities.Cash", "Cash", b1 =>
                        {
                            b1.Property<Guid>("WalletId")
                                .HasColumnType("TEXT");

                            b1.Property<decimal>("Amount")
                                .HasColumnType("TEXT");

                            b1.Property<DateTime>("LastUpdated")
                                .HasColumnType("TEXT");

                            b1.HasKey("WalletId");

                            b1.ToTable("Wallets");

                            b1.WithOwner()
                                .HasForeignKey("WalletId");
                        });

                    b.OwnsOne("Gest.Core.Entities.Credit", "Credit", b1 =>
                        {
                            b1.Property<Guid>("WalletId")
                                .HasColumnType("TEXT");

                            b1.Property<decimal>("Amount")
                                .HasColumnType("TEXT");

                            b1.Property<DateTime>("LastUpdated")
                                .HasColumnType("TEXT");

                            b1.HasKey("WalletId");

                            b1.ToTable("Wallets");

                            b1.WithOwner()
                                .HasForeignKey("WalletId");
                        });

                    b.Navigation("Bank")
                        .IsRequired();

                    b.Navigation("Cash")
                        .IsRequired();

                    b.Navigation("Credit")
                        .IsRequired();
                });

            modelBuilder.Entity("Gest.Core.Entities.WalletMovement", b =>
                {
                    b.HasOne("Gest.Core.Entities.Wallet", "ToWallet")
                        .WithMany("WalletHistory")
                        .HasForeignKey("ToWalletId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ToWallet");
                });

            modelBuilder.Entity("Gest.Core.Entities.Article", b =>
                {
                    b.Navigation("Mouvements");

                    b.Navigation("Sales");
                });

            modelBuilder.Entity("Gest.Core.Entities.Company", b =>
                {
                    b.Navigation("Branches");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Gest.Core.Entities.Sale", b =>
                {
                    b.Navigation("Payments");
                });

            modelBuilder.Entity("Gest.Core.Entities.User", b =>
                {
                    b.Navigation("Companies");
                });

            modelBuilder.Entity("Gest.Core.Entities.Wallet", b =>
                {
                    b.Navigation("WalletHistory");
                });
#pragma warning restore 612, 618
        }
    }
}
