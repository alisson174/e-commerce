using ECommerce.Application;
using ECommerce.Application.Interfaces;
using ECommerce.Data.Repositories;
using ECommerce.Data.Repositories.Interfaces;
using ECommerce.Service;
using ECommerce.Service.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.IoC
{
    public static class DependencyResolver
    {
        public static void AddInjectionContainer(this IServiceCollection services)
        {
            AddApplicationContainer(services);
            AddServiceContainer(services);
            AddRepositoryContainer(services);
        }

        private static void AddApplicationContainer(IServiceCollection services)
        {
            services.AddTransient<IUsuarioApplication, UsuarioApplication>();
            services.AddTransient<IEquipeApplication, EquipeApplication>();
            services.AddTransient<IProdutoApplication, ProdutoApplication>();
            services.AddTransient<IPedidoApplication, PedidoApplication>();
        }
        private static void AddServiceContainer(IServiceCollection services)
        {
            services.AddTransient<IEquipeService, EquipeService>();
            services.AddTransient<ITokenService, TokenService>();
            services.AddTransient<IUsuarioService, UsuarioService>();
            services.AddTransient<IProdutoService, ProdutoService>();
            services.AddTransient<IPedidoService, PedidoService>();
            services.AddTransient<IPedidoProdutoService, PedidoProdutoService>();
        }

        private static void AddRepositoryContainer(IServiceCollection services)
        {
            services.AddTransient<IEquipeRepository, EquipeRepository>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            services.AddTransient<IProdutoRepository, ProdutoRepository>();
            services.AddTransient<IPedidoRepository, PedidoRepository>();
            services.AddTransient<IPedidoProdutoRepository, PedidoProdutoRepository>();
        }
    }
}