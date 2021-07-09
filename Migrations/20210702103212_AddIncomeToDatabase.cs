using Microsoft.EntityFrameworkCore.Migrations;

namespace FinanceManage.Migrations
{
    public partial class AddIncomeToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ExpenseName",
                table: "Expenses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Incomes",
                columns: table => new
                {
                    incomeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IncomeDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sales = table.Column<double>(type: "float", nullable: false),
                    other = table.Column<double>(type: "float", nullable: false),
                    total = table.Column<double>(type: "float", nullable: false),
                    netSales = table.Column<double>(type: "float", nullable: false),
                    vat = table.Column<double>(type: "float", nullable: false),
                    grossSales = table.Column<double>(type: "float", nullable: false),
                    cash = table.Column<double>(type: "float", nullable: false),
                    card = table.Column<double>(type: "float", nullable: false),
                    credit = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incomes", x => x.incomeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Incomes");

            migrationBuilder.AlterColumn<string>(
                name: "ExpenseName",
                table: "Expenses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
