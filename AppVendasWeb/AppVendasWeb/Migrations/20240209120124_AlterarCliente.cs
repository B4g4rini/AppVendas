using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppVendasWeb.Migrations
{
    /// <inheritdoc />
    public partial class AlterarCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Cliente_ClienteId",
                table: "Venda");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Venda");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClienteId",
                table: "Venda",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Cliente_ClienteId",
                table: "Venda",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Cliente_ClienteId",
                table: "Venda");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClienteId",
                table: "Venda",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId",
                table: "Venda",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Cliente_ClienteId",
                table: "Venda",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "ClienteId");
        }
    }
}
