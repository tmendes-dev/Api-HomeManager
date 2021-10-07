using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class ShopListAndProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShopList",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Owner = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    IdealValue = table.Column<decimal>(type: "DECIMAL(10,2)", nullable: false),
                    MaxValue = table.Column<decimal>(type: "DECIMAL(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopList", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "DECIMAL(10,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ShopListID = table.Column<int>(type: "int", nullable: false),
                    IsChecked = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Product_ShopList_ShopListID",
                        column: x => x.ShopListID,
                        principalTable: "ShopList",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_ShopListID",
                table: "Product",
                column: "ShopListID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "ShopList");
        }
    }
}
