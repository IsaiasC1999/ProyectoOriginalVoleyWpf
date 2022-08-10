using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoVoleyWpf.Migrations
{
    public partial class Monto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Monto",
                table: "Cuotas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Monto",
                table: "Cuotas");
        }
    }
}
