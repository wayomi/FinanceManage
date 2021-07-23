using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinanceManage.Migrations
{
    public partial class AddExpenseToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExpenseName",
                table: "Expenses",
                newName: "InvoiceNo");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Expenses",
                newName: "ExpenseId");

            migrationBuilder.AlterColumn<float>(
                name: "Amount",
                table: "Expenses",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Expenses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "expenseDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "firstPaidDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<float>(
                name: "firstPayment",
                table: "Expenses",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "paymentType",
                table: "Expenses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "secondPaidDate",
                table: "Expenses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<float>(
                name: "secondPayment",
                table: "Expenses",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "total",
                table: "Expenses",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "vat",
                table: "Expenses",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "expenseDate",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "firstPaidDate",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "firstPayment",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "paymentType",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "secondPaidDate",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "secondPayment",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "total",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "vat",
                table: "Expenses");

            migrationBuilder.RenameColumn(
                name: "InvoiceNo",
                table: "Expenses",
                newName: "ExpenseName");

            migrationBuilder.RenameColumn(
                name: "ExpenseId",
                table: "Expenses",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "Amount",
                table: "Expenses",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }
    }
}
