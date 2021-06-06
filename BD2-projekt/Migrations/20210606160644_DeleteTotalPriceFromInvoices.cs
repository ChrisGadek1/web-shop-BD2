using Microsoft.EntityFrameworkCore.Migrations;

namespace BD2_projekt.Migrations
{
    public partial class DeleteTotalPriceFromInvoices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "totalPrice",
                table: "Invoices");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "totalPrice",
                table: "Invoices",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
