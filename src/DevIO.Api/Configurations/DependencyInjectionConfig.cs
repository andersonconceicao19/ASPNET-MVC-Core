using DevIO.Business.Intefaces;
using DevIO.Business.Notificacoes;
using DevIO.Business.Services;
using DevIO.Data.Context;
using DevIO.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace DevIO.Api.Configurations
{
    public static class DependencyInjectionConfig
    {
        /**Usando a classe para deixar organizar a injeção de dependencia*/
        public static IServiceCollection ResolveDependencies(this IServiceCollection services) //se nao passar o THIS, não funciona!
        {
            services.AddScoped<MeuDbContext>();
           // services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();

            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<IFornecedorService, FornecedorService>();
            // services.AddScoped<IProdutoService, ProdutoService>();


            return services;
        }
    }
}
