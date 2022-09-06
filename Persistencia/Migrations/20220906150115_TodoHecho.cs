using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistencia.Migrations
{
    public partial class TodoHecho : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arbitros_Torneos_TorneoId",
                table: "Arbitros");

            migrationBuilder.DropForeignKey(
                name: "FK_Torneos_Patrocinadores_PatrocinadorId",
                table: "Torneos");

            migrationBuilder.DropForeignKey(
                name: "FK_UnidadesDeportivas_Torneos_TorneoId",
                table: "UnidadesDeportivas");

            migrationBuilder.AlterColumn<int>(
                name: "TorneoId",
                table: "UnidadesDeportivas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PatrocinadorId",
                table: "Torneos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TorneoId",
                table: "Arbitros",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Arbitros_Torneos_TorneoId",
                table: "Arbitros",
                column: "TorneoId",
                principalTable: "Torneos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Torneos_Patrocinadores_PatrocinadorId",
                table: "Torneos",
                column: "PatrocinadorId",
                principalTable: "Patrocinadores",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UnidadesDeportivas_Torneos_TorneoId",
                table: "UnidadesDeportivas",
                column: "TorneoId",
                principalTable: "Torneos",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arbitros_Torneos_TorneoId",
                table: "Arbitros");

            migrationBuilder.DropForeignKey(
                name: "FK_Torneos_Patrocinadores_PatrocinadorId",
                table: "Torneos");

            migrationBuilder.DropForeignKey(
                name: "FK_UnidadesDeportivas_Torneos_TorneoId",
                table: "UnidadesDeportivas");

            migrationBuilder.AlterColumn<int>(
                name: "TorneoId",
                table: "UnidadesDeportivas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PatrocinadorId",
                table: "Torneos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TorneoId",
                table: "Arbitros",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Arbitros_Torneos_TorneoId",
                table: "Arbitros",
                column: "TorneoId",
                principalTable: "Torneos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Torneos_Patrocinadores_PatrocinadorId",
                table: "Torneos",
                column: "PatrocinadorId",
                principalTable: "Patrocinadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UnidadesDeportivas_Torneos_TorneoId",
                table: "UnidadesDeportivas",
                column: "TorneoId",
                principalTable: "Torneos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
