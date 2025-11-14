using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudNativoClienteProductoVenta.Migrations
{
    /// <inheritdoc />
    public partial class ActualizarCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Productos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Stock",
                table: "Productos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CorreoElectronico",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DocumentoIdentidad",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "CorreoElectronico",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "DocumentoIdentidad",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "Clientes");
        }
    }
}
