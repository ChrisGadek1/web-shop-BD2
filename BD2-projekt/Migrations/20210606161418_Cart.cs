using Microsoft.EntityFrameworkCore.Migrations;

namespace BD2_projekt.Migrations
{
    public partial class Cart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    CartID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UsersID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.CartID);
                    table.ForeignKey(
                        name: "FK_Cart_Users_UsersID",
                        column: x => x.UsersID,
                        principalTable: "Users",
                        principalColumn: "UsersID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CartElements",
                columns: table => new
                {
                    CartElementID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductsID = table.Column<int>(type: "INTEGER", nullable: true),
                    NumberOfProducts = table.Column<int>(type: "INTEGER", nullable: false),
                    CartID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartElements", x => x.CartElementID);
                    table.ForeignKey(
                        name: "FK_CartElements_Cart_CartID",
                        column: x => x.CartID,
                        principalTable: "Cart",
                        principalColumn: "CartID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CartElements_Products_ProductsID",
                        column: x => x.ProductsID,
                        principalTable: "Products",
                        principalColumn: "ProductsID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cart_UsersID",
                table: "Cart",
                column: "UsersID");

            migrationBuilder.CreateIndex(
                name: "IX_CartElements_CartID",
                table: "CartElements",
                column: "CartID");

            migrationBuilder.CreateIndex(
                name: "IX_CartElements_ProductsID",
                table: "CartElements",
                column: "ProductsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartElements");

            migrationBuilder.DropTable(
                name: "Cart");
        }
    }
}
