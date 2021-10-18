using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.Data.Migrations
{
    public partial class Alteraçõesfinaisparapublicação : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PedidoProduto_Pedidos_PedidoId",
                table: "PedidoProduto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PedidoProduto",
                table: "PedidoProduto");

            migrationBuilder.RenameTable(
                name: "PedidoProduto",
                newName: "PedidoProdutos");

            migrationBuilder.RenameIndex(
                name: "IX_PedidoProduto_PedidoId",
                table: "PedidoProdutos",
                newName: "IX_PedidoProdutos_PedidoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PedidoProdutos",
                table: "PedidoProdutos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoProdutos_Pedidos_PedidoId",
                table: "PedidoProdutos",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PedidoProdutos_Pedidos_PedidoId",
                table: "PedidoProdutos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PedidoProdutos",
                table: "PedidoProdutos");

            migrationBuilder.RenameTable(
                name: "PedidoProdutos",
                newName: "PedidoProduto");

            migrationBuilder.RenameIndex(
                name: "IX_PedidoProdutos_PedidoId",
                table: "PedidoProduto",
                newName: "IX_PedidoProduto_PedidoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PedidoProduto",
                table: "PedidoProduto",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoProduto_Pedidos_PedidoId",
                table: "PedidoProduto",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
