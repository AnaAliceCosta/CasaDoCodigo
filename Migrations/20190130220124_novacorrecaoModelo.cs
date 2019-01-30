using Microsoft.EntityFrameworkCore.Migrations;

namespace CasaDoCodigo.Migrations
{
    public partial class novacorrecaoModelo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Cadastro_CadastroId",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_CadastroId",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "CadastroId",
                table: "Pedido");

            migrationBuilder.AddColumn<int>(
                name: "PedidoId",
                table: "Cadastro",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cadastro_PedidoId",
                table: "Cadastro",
                column: "PedidoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cadastro_Pedido_PedidoId",
                table: "Cadastro",
                column: "PedidoId",
                principalTable: "Pedido",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cadastro_Pedido_PedidoId",
                table: "Cadastro");

            migrationBuilder.DropIndex(
                name: "IX_Cadastro_PedidoId",
                table: "Cadastro");

            migrationBuilder.DropColumn(
                name: "PedidoId",
                table: "Cadastro");

            migrationBuilder.AddColumn<int>(
                name: "CadastroId",
                table: "Pedido",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_CadastroId",
                table: "Pedido",
                column: "CadastroId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Cadastro_CadastroId",
                table: "Pedido",
                column: "CadastroId",
                principalTable: "Cadastro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
