using Microsoft.EntityFrameworkCore.Migrations;

namespace BD2_projekt.Migrations
{
    public partial class OrderUnits2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InvoicesProducts");

            migrationBuilder.AddColumn<int>(
                name: "InvoicesID",
                table: "OrderUnits",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductsID",
                table: "Invoices",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderUnits_InvoicesID",
                table: "OrderUnits",
                column: "InvoicesID");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_ProductsID",
                table: "Invoices",
                column: "ProductsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Products_ProductsID",
                table: "Invoices",
                column: "ProductsID",
                principalTable: "Products",
                principalColumn: "ProductsID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderUnits_Invoices_InvoicesID",
                table: "OrderUnits",
                column: "InvoicesID",
                principalTable: "Invoices",
                principalColumn: "InvoicesID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Products_ProductsID",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderUnits_Invoices_InvoicesID",
                table: "OrderUnits");

            migrationBuilder.DropIndex(
                name: "IX_OrderUnits_InvoicesID",
                table: "OrderUnits");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_ProductsID",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "InvoicesID",
                table: "OrderUnits");

            migrationBuilder.DropColumn(
                name: "ProductsID",
                table: "Invoices");

            migrationBuilder.CreateTable(
                name: "InvoicesProducts",
                columns: table => new
                {
                    InvoicesID = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductsID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoicesProducts", x => new { x.InvoicesID, x.ProductsID });
                    table.ForeignKey(
                        name: "FK_InvoicesProducts_Invoices_InvoicesID",
                        column: x => x.InvoicesID,
                        principalTable: "Invoices",
                        principalColumn: "InvoicesID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvoicesProducts_Products_ProductsID",
                        column: x => x.ProductsID,
                        principalTable: "Products",
                        principalColumn: "ProductsID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InvoicesProducts_ProductsID",
                table: "InvoicesProducts",
                column: "ProductsID");
        }
    }
}
