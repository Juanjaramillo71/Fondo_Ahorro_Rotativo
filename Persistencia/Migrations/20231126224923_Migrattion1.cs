using Microsoft.EntityFrameworkCore.Migrations;

namespace TallerMecanica.Persistencia.Migrations
{
    public partial class Migrattion1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cuentas",
                columns: table => new
                {
                    CuentaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AhorroAcumulado = table.Column<int>(type: "int", nullable: false),
                    InteresesAbonados = table.Column<int>(type: "int", nullable: false),
                    SaldoTotal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cuentas", x => x.CuentaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cuentas");
        }
    }
}
