using Microsoft.EntityFrameworkCore.Migrations;

namespace BD2_projekt.Migrations
{
    public partial class FixedInvoices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Invoices_InvoicesID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_InvoicesID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "InvoicesID",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "ShortDescribtion",
                table: "Products",
                newName: "ShortDescription");

            migrationBuilder.RenameColumn(
                name: "Describtion",
                table: "Products",
                newName: "Description");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InvoicesProducts");

            migrationBuilder.RenameColumn(
                name: "ShortDescription",
                table: "Products",
                newName: "ShortDescribtion");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Products",
                newName: "Describtion");

            migrationBuilder.AddColumn<int>(
                name: "InvoicesID",
                table: "Products",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_InvoicesID",
                table: "Products",
                column: "InvoicesID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Invoices_InvoicesID",
                table: "Products",
                column: "InvoicesID",
                principalTable: "Invoices",
                principalColumn: "InvoicesID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
