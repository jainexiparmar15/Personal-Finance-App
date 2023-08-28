﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Personal_Finance_Manager.Models;

#nullable disable

namespace Personal_Finance_App.Migrations
{
    [DbContext(typeof(PersonaFinanceAppDbContext))]
    [Migration("20230828022437_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Personal_Finance_Manager.Models.Expense", b =>
                {
                    b.Property<int>("ExpenseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExpenseID"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExpenseCategoryID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ExpenseID");

                    b.HasIndex("ExpenseCategoryID");

                    b.HasIndex("UserID");

                    b.ToTable("Expenses");
                });

            modelBuilder.Entity("Personal_Finance_Manager.Models.ExpenseCategory", b =>
                {
                    b.Property<int>("ExpenseCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExpenseCategoryID"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExpenseCategoryID");

                    b.ToTable("ExpenseCategories");
                });

            modelBuilder.Entity("Personal_Finance_Manager.Models.Income", b =>
                {
                    b.Property<int>("IncomeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IncomeID"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("IncomeID");

                    b.HasIndex("UserID");

                    b.ToTable("Incomes");
                });

            modelBuilder.Entity("Personal_Finance_Manager.Models.Investment", b =>
                {
                    b.Property<int>("InvestmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvestmentID"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InvestmentTypeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("InvestmentID");

                    b.HasIndex("InvestmentTypeID");

                    b.HasIndex("UserID");

                    b.ToTable("Investments");
                });

            modelBuilder.Entity("Personal_Finance_Manager.Models.InvestmentType", b =>
                {
                    b.Property<int>("InvestmentTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvestmentTypeID"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InvestmentTypeID");

                    b.ToTable("InvestmentTypes");
                });

            modelBuilder.Entity("Personal_Finance_Manager.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Personal_Finance_Manager.Models.Expense", b =>
                {
                    b.HasOne("Personal_Finance_Manager.Models.ExpenseCategory", "ExpenseCategory")
                        .WithMany("Expenses")
                        .HasForeignKey("ExpenseCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Personal_Finance_Manager.Models.User", "User")
                        .WithMany("Expenses")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExpenseCategory");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Personal_Finance_Manager.Models.Income", b =>
                {
                    b.HasOne("Personal_Finance_Manager.Models.User", "User")
                        .WithMany("Incomes")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Personal_Finance_Manager.Models.Investment", b =>
                {
                    b.HasOne("Personal_Finance_Manager.Models.InvestmentType", "InvestmentType")
                        .WithMany("Investments")
                        .HasForeignKey("InvestmentTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Personal_Finance_Manager.Models.User", "User")
                        .WithMany("Investments")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InvestmentType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Personal_Finance_Manager.Models.ExpenseCategory", b =>
                {
                    b.Navigation("Expenses");
                });

            modelBuilder.Entity("Personal_Finance_Manager.Models.InvestmentType", b =>
                {
                    b.Navigation("Investments");
                });

            modelBuilder.Entity("Personal_Finance_Manager.Models.User", b =>
                {
                    b.Navigation("Expenses");

                    b.Navigation("Incomes");

                    b.Navigation("Investments");
                });
#pragma warning restore 612, 618
        }
    }
}
