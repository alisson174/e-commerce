using ECommerce.Application.Interfaces;
using ECommerce.Domain.Models;
using ECommerce.Service.Interfaces;
using System.Collections.Generic;
using System.Transactions;

namespace ECommerce.Application
{
    public class PedidoApplication : BaseApplication<Pedido>, IPedidoApplication
    {
        private readonly IPedidoService _service;
        private readonly IPedidoProdutoService _pedidoProdutoService;
        public PedidoApplication(IPedidoService service, IPedidoProdutoService pedidoProdutoService) : base(service)
        {
            _service = service;
            _pedidoProdutoService = pedidoProdutoService;
        }

        public IList<Pedido> ListarPorDataCriacao(int quantidade) => _service.ListarPorDataCriacao(quantidade);

        public override void AddOrUpdate(Pedido pedido)
        {
            // Fazer backup dos itens do pedido
            var itens = pedido.PedidoProdutos;

            pedido.PedidoProdutos = null;

            using (var scope = new TransactionScope())
            {
                long id;

                if (pedido.Id == 0)
                    id = _service.Salvar(pedido);
                else
                {
                    _service.Update(pedido);

                    id = pedido.Id;
                }


                foreach (var item in itens)
                {
                    item.PedidoId = id;
                    _pedidoProdutoService.Add(item);
                }
            }
        }
    }
}