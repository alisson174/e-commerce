using ECommerce.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Data.Configurations
{
    public class PedidoProdutoConfiguration : IEntityTypeConfiguration<PedidoProduto>
    {
        public void Configure(EntityTypeBuilder<PedidoProduto> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Pedido)
                   .WithMany(x => x.PedidoProdutos)
                   .HasForeignKey(x => x.PedidoId);

            builder.ToTable("PedidoProdutos");
        }
    }
}