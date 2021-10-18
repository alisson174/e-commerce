using ECommerce.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Data.Configurations
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(x => x.Id);

            builder.OwnsOne(x => x.Endereco);

            builder.HasOne(x => x.Equipe)
                   .WithMany(x => x.Pedidos)
                   .HasForeignKey(x => x.EquipeId);

            builder.ToTable("Pedidos");
        }
    }
}