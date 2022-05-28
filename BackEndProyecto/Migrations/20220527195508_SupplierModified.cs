using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackEndProyecto.Migrations
{
    public partial class SupplierModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Servicio",
                table: "Supplier",
                newName: "Service");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Service",
                table: "Supplier",
                newName: "Servicio");
        }
    }
}
