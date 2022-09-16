using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistencia.Migrations
{
    public partial class Unique_PatrocinadorDeleteCascade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Patrocinadores_PatrocinadorId",
                table: "Equipos");

            migrationBuilder.AlterColumn<string>(
                name: "Deporte",
                table: "Patrocinadores",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Eps",
                table: "Deportistas",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Nit",
                table: "ColegiosInstrucciones",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.CreateIndex(
                name: "IX_Municipios_Nombre",
                table: "Municipios",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ColegiosInstrucciones_Nit",
                table: "ColegiosInstrucciones",
                column: "Nit",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Arbitros_Documento",
                table: "Arbitros",
                column: "Documento",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Patrocinadores_PatrocinadorId",
                table: "Equipos",
                column: "PatrocinadorId",
                principalTable: "Patrocinadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Patrocinadores_PatrocinadorId",
                table: "Equipos");

            migrationBuilder.DropIndex(
                name: "IX_Municipios_Nombre",
                table: "Municipios");

            migrationBuilder.DropIndex(
                name: "IX_ColegiosInstrucciones_Nit",
                table: "ColegiosInstrucciones");

            migrationBuilder.DropIndex(
                name: "IX_Arbitros_Documento",
                table: "Arbitros");

            migrationBuilder.AlterColumn<string>(
                name: "Deporte",
                table: "Patrocinadores",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Eps",
                table: "Deportistas",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nit",
                table: "ColegiosInstrucciones",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Patrocinadores_PatrocinadorId",
                table: "Equipos",
                column: "PatrocinadorId",
                principalTable: "Patrocinadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
