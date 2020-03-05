using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class dbchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemLookupCode = table.Column<string>(maxLength: 30, nullable: true),
                    Description = table.Column<string>(maxLength: 30, nullable: true),
                    ExtendedDescription = table.Column<string>(maxLength: 90, nullable: true),
                    Manufacturer = table.Column<string>(maxLength: 30, nullable: true),
                    SupplierID = table.Column<int>(nullable: false),
                    Model = table.Column<string>(maxLength: 30, nullable: true),
                    RetailPrice = table.Column<decimal>(nullable: false),
                    SupplierCost = table.Column<decimal>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    DepartmentID = table.Column<int>(nullable: false),
                    CategoryGroupID = table.Column<int>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false),
                    UnitOfMeasure = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SupplierLists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierID = table.Column<string>(nullable: true),
                    ReorderNumber = table.Column<string>(nullable: true),
                    MinimumOrder = table.Column<double>(nullable: false),
                    MasterPackQuantity = table.Column<double>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierLists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Currency = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "SupplierLists");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
