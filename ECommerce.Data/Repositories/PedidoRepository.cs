using ECommerce.Data.Context;
using ECommerce.Data.Repositories.Interfaces;
using ECommerce.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ECommerce.Data.Repositories
{
    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        private readonly DbContextOptions<DataContext> _options;
        public PedidoRepository(DbContextOptions<DataContext> options) : base(options) => _options = options;

        public IList<Pedido> ListarPorDataCriacao(int quantidade)
        {
            using (var ctx = new DataContext(_options))
            {
                var pedidos = ctx.Pedidos
                    .OrderByDescending(x => x.DataCriacao)
                    .Take(quantidade)
                    .ToList();

                foreach (var pedido in pedidos)
                {
                    var produtos = ctx.PedidoProdutos.Where(x => x.PedidoId == pedido.Id).ToList();

                    pedido.PedidoProdutos = produtos;
                }

                return pedidos;
            }
        }

        public long Salvar(Pedido pedido)
        {
            using (var ctx = new DataContext(_options))
            {
                ctx.Set<Pedido>().Add(pedido);
                ctx.SaveChanges();

                return pedido.Id;
            }
        }
    }
}