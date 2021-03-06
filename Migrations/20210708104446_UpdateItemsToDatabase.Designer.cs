// <auto-generated />
using System;
using FinanceManage.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinanceManage.Migrations
{
    [DbContext(typeof(ApplicataionDbContext))]
    [Migration("20210708104446_UpdateItemsToDatabase")]
    partial class UpdateItemsToDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FinanceManage.Models.Expense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("ExpenseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Expenses");
                });

            modelBuilder.Entity("FinanceManage.Models.Income", b =>
                {
                    b.Property<int>("incomeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("IncomeDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("card")
                        .HasColumnType("float");

                    b.Property<double>("cash")
                        .HasColumnType("float");

                    b.Property<double>("credit")
                        .HasColumnType("float");

                    b.Property<double>("grossSales")
                        .HasColumnType("float");

                    b.Property<double>("netSales")
                        .HasColumnType("float");

                    b.Property<double>("other")
                        .HasColumnType("float");

                    b.Property<double>("sales")
                        .HasColumnType("float");

                    b.Property<double>("total")
                        .HasColumnType("float");

                    b.Property<double>("vat")
                        .HasColumnType("float");

                    b.HasKey("incomeId");

                    b.ToTable("Incomes");
                });

            modelBuilder.Entity("FinanceManage.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ItemName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("FinanceManage.Models.Purchase", b =>
                {
                    b.Property<int>("purchaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Amount")
                        .HasColumnType("real");

                    b.Property<string>("InvoiceNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("firstPaidDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("firstPayment")
                        .HasColumnType("real");

                    b.Property<string>("paymentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("puchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("secondPaidDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("secondPayment")
                        .HasColumnType("real");

                    b.Property<float>("total")
                        .HasColumnType("real");

                    b.Property<float>("vat")
                        .HasColumnType("real");

                    b.HasKey("purchaseId");

                    b.ToTable("Purchases");
                });
#pragma warning restore 612, 618
        }
    }
}
