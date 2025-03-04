﻿// <auto-generated />
using System;
using Gest.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Gest.SqlServerMigration.Migrations
{
    [DbContext(typeof(GestDbContext))]
    [Migration("20220327082046_AddTitleToPayment")]
    partial class AddTitleToPayment
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Gest.Core.Entities.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BranchId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UnitOfMeasure")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("Gest.Core.Entities.Branch", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("FCToDollarRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Branches");

                    b.HasData(
                        new
                        {
                            Id = new Guid("453412a3-578b-446b-9406-bd7077bdce01"),
                            CompanyId = new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"),
                            CreatedAt = new DateTime(2022, 3, 27, 8, 20, 45, 194, DateTimeKind.Utc).AddTicks(2701),
                            FCToDollarRate = 2000m,
                            Name = "Default",
                            UpdatedAt = new DateTime(2022, 3, 27, 8, 20, 45, 194, DateTimeKind.Utc).AddTicks(2694)
                        });
                });

            modelBuilder.Entity("Gest.Core.Entities.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Names")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("WalletId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("WalletId");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = new Guid("654412a3-578b-446b-9406-bd7077bdce01"),
                            CompanyId = new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"),
                            CreatedAt = new DateTime(2022, 3, 27, 8, 20, 45, 194, DateTimeKind.Utc).AddTicks(2711),
                            Email = "clientanonyme@swala.com",
                            Names = "Client Anonyme",
                            UpdatedAt = new DateTime(2022, 3, 27, 8, 20, 45, 194, DateTimeKind.Utc).AddTicks(2705)
                        });
                });

            modelBuilder.Entity("Gest.Core.Entities.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("FCToDollarRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("WalletId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("WalletId");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"),
                            Adress = "Bunia",
                            CreatedAt = new DateTime(2022, 3, 27, 8, 20, 45, 194, DateTimeKind.Utc).AddTicks(2690),
                            FCToDollarRate = 2000m,
                            Name = "Ets TUUNGANE",
                            UpdatedAt = new DateTime(2022, 3, 27, 8, 20, 45, 194, DateTimeKind.Utc).AddTicks(2687)
                        });
                });

            modelBuilder.Entity("Gest.Core.Entities.Payment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AccountType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ClientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ClientNames")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PayementId")
                        .HasColumnType("int");

                    b.Property<Guid?>("SaleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

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
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("AmountPaid")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("ArticleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BranchId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeliverStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PayStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SaleId")
                        .HasColumnType("int");

                    b.Property<Guid>("SellerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.HasIndex("BranchId");

                    b.HasIndex("ClientId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("SellerId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("Gest.Core.Entities.StockMouvement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ArticleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("NewBuyingPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NewSellingPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<double>("NewStock")
                        .HasColumnType("float");

                    b.Property<decimal>("PrevBuyingPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PrevSellingPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<double>("PrevStock")
                        .HasColumnType("float");

                    b.Property<double>("Qty")
                        .HasColumnType("float");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.ToTable("StockMouvements");
                });

            modelBuilder.Entity("Gest.Core.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d5ccad5b-6cbc-4993-96e3-e8cd7c76d8b9"),
                            CreatedAt = new DateTime(2022, 3, 27, 8, 20, 45, 194, DateTimeKind.Utc).AddTicks(2659),
                            Email = "admin@swala.com",
                            FirstName = "Admin",
                            LastName = "Swala",
                            PasswordHash = "dzghSLPKG3GTVdAAO7ooJAN5ym3UDXXyWbDhFjS5O/GPzJFe0bCL6ALdGW1Quqw7LcM04Uz54+/b4FWYfW/KIcjUgBE4ywWyH6qIGhylwTTwQMcT4rlUz2gYQ8UzbpMoxdgEHV9qT0rM5qat/CvwTYDdHoLnGJejp8rZr6x/wfqq8xdhAI1MUihxonU+5BV/JKBISf6t3GiXMiaHmxriOui2n1+8g2A2OoAi8PkXmvRc071h1eAuk/y6LPtzpG5N2HDe2XiPmagkJ0chXMkNWGLKRE1Rk530f+J8En+XMyaqLb8xaeYqzHprcqGQI46C4hBf81cPdDjzg5vzvld23w==",
                            PasswordSalt = "0O7nEzCAAegTYiOT0eK/8NT6mdzZEC5nDqakkYRpiwIo9FWQ63lQXqpY6a44PEtbmMwXLsG/+fbuIYwPcSx9Hw==",
                            UpdatedAt = new DateTime(2022, 3, 27, 8, 20, 45, 194, DateTimeKind.Utc).AddTicks(2624)
                        });
                });

            modelBuilder.Entity("Gest.Core.Entities.UserCompany", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Joined")
                        .HasColumnType("datetime2");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("UserId", "CompanyId");

                    b.HasIndex("CompanyId");

                    b.ToTable("UserCompanies");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("d5ccad5b-6cbc-4993-96e3-e8cd7c76d8b9"),
                            CompanyId = new Guid("afdc3370-adb1-4de9-ad12-7678145b4485"),
                            Joined = new DateTime(2022, 3, 27, 8, 20, 45, 194, DateTimeKind.Utc).AddTicks(2670),
                            Role = "Propriétaire",
                            UpdatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Gest.Core.Entities.Wallet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Wallets");
                });

            modelBuilder.Entity("Gest.Core.Entities.WalletMovement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("FromAccountType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("FromWalletId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ToAccountType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ToWalletId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TransType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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
                        .WithMany("Articles")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.OwnsOne("Gest.Core.Entities.Conditionnement", "Conditionnement", b1 =>
                        {
                            b1.Property<Guid>("ArticleId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<double>("QtyPerUnitOfMeasure")
                                .HasColumnType("float");

                            b1.HasKey("ArticleId");

                            b1.ToTable("Articles");

                            b1.WithOwner()
                                .HasForeignKey("ArticleId");
                        });

                    b.OwnsOne("Gest.Core.Entities.Pricing", "Price", b1 =>
                        {
                            b1.Property<Guid>("ArticleId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<decimal?>("BuyingPricePerConditionnement")
                                .HasColumnType("decimal(18,2)");

                            b1.Property<decimal>("BuyingPricePerUnitOfMeasure")
                                .HasColumnType("decimal(18,2)");

                            b1.Property<decimal?>("SellingPricePerConditionnement")
                                .HasColumnType("decimal(18,2)");

                            b1.Property<decimal>("SellingPricePerUnitOfMeasure")
                                .HasColumnType("decimal(18,2)");

                            b1.HasKey("ArticleId");

                            b1.ToTable("Articles");

                            b1.WithOwner()
                                .HasForeignKey("ArticleId");
                        });

                    b.OwnsOne("Gest.Core.Entities.Stock", "Stock", b1 =>
                        {
                            b1.Property<Guid>("ArticleId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<double?>("Maximum")
                                .HasColumnType("float");

                            b1.Property<double>("Minimum")
                                .HasColumnType("float");

                            b1.Property<double>("Qty")
                                .HasColumnType("float");

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
                        .WithMany("Sales")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Gest.Core.Entities.Client", "Client")
                        .WithMany("Sales")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Gest.Core.Entities.Company", "Company")
                        .WithMany("Sales")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Gest.Core.Entities.User", "Seller")
                        .WithMany("Sales")
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.OwnsMany("Gest.Core.Entities.SaleItem", "Items", b1 =>
                        {
                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b1.Property<int>("Id"), 1L, 1);

                            b1.Property<Guid>("ArticleId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<decimal>("BuyingUnitPricePerUnitOfMeasure")
                                .HasColumnType("decimal(18,2)");

                            b1.Property<double>("QtyDelivered")
                                .HasColumnType("float");

                            b1.Property<double>("QtyInUnitOfMeasure")
                                .HasColumnType("float");

                            b1.Property<Guid>("SaleId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<decimal>("UnitPricePerUnitOfMeasure")
                                .HasColumnType("decimal(18,2)");

                            b1.HasKey("Id");

                            b1.HasIndex("ArticleId");

                            b1.HasIndex("SaleId");

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

                    b.Navigation("Seller");
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
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("AccountNumber")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<decimal>("Amount")
                                .HasColumnType("decimal(18,2)");

                            b1.Property<DateTime>("LastUpdated")
                                .HasColumnType("datetime2");

                            b1.HasKey("WalletId");

                            b1.ToTable("Wallets");

                            b1.WithOwner()
                                .HasForeignKey("WalletId");
                        });

                    b.OwnsOne("Gest.Core.Entities.Cash", "Cash", b1 =>
                        {
                            b1.Property<Guid>("WalletId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<decimal>("Amount")
                                .HasColumnType("decimal(18,2)");

                            b1.Property<DateTime>("LastUpdated")
                                .HasColumnType("datetime2");

                            b1.HasKey("WalletId");

                            b1.ToTable("Wallets");

                            b1.WithOwner()
                                .HasForeignKey("WalletId");
                        });

                    b.OwnsOne("Gest.Core.Entities.Credit", "Credit", b1 =>
                        {
                            b1.Property<Guid>("WalletId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<decimal>("Amount")
                                .HasColumnType("decimal(18,2)");

                            b1.Property<DateTime>("LastUpdated")
                                .HasColumnType("datetime2");

                            b1.HasKey("WalletId");

                            b1.ToTable("Wallets");

                            b1.WithOwner()
                                .HasForeignKey("WalletId");
                        });

                    b.OwnsOne("Gest.Core.Entities.Expense", "Expense", b1 =>
                        {
                            b1.Property<Guid>("WalletId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<decimal>("Amount")
                                .HasColumnType("decimal(18,2)");

                            b1.Property<DateTime>("LastUpdated")
                                .HasColumnType("datetime2");

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

                    b.Navigation("Expense")
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

            modelBuilder.Entity("Gest.Core.Entities.Branch", b =>
                {
                    b.Navigation("Sales");
                });

            modelBuilder.Entity("Gest.Core.Entities.Client", b =>
                {
                    b.Navigation("Sales");
                });

            modelBuilder.Entity("Gest.Core.Entities.Company", b =>
                {
                    b.Navigation("Articles");

                    b.Navigation("Branches");

                    b.Navigation("Sales");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Gest.Core.Entities.Sale", b =>
                {
                    b.Navigation("Payments");
                });

            modelBuilder.Entity("Gest.Core.Entities.User", b =>
                {
                    b.Navigation("Companies");

                    b.Navigation("Sales");
                });

            modelBuilder.Entity("Gest.Core.Entities.Wallet", b =>
                {
                    b.Navigation("WalletHistory");
                });
#pragma warning restore 612, 618
        }
    }
}
