using Microsoft.EntityFrameworkCore.Migrations;

namespace FinanceManage.Migrations
{
    public partial class UpdateItemListInPurchaseTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "purchaseId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_purchaseId",
                table: "Items",
                column: "purchaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Purchases_purchaseId",
                table: "Items",
                column: "purchaseId",
                principalTable: "Purchases",
                principalColumn: "purchaseId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Purchases_purchaseId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_purchaseId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "purchaseId",
                table: "Items");
        }
    }
}
