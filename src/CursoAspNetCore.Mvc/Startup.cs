using CursoAspNetCore.Application.Interface;
using CursoAspNetCore.Application.Interface.Repository;
using CursoAspNetCore.Domain.Interfaces.Repository;
using CursoAspNetCore.Domain.Services;
using CursoAspNetCore.Infra.Data.Repository;
using CursoAspNetMvc.Infra.Data.Context;
using CursoAspNetMvc.Infra.Data.Repository;
using CursoAspNetMvc.Infra.Data.UoW;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CursoAspNetCore.Mvc
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            
             //App
            services.AddSingleton<IClienteAppService, ClienteAppService>();
            services.AddSingleton<IEnderecoAppService, EnderecoAppService>();     

            //Domain           
            services.AddSingleton<IClienteService, ClienteService>();
            services.AddSingleton<IEnderecoService, EnderecoService>();
            services.AddSingleton<IUnitOfWork, UnitOfWork>();
            
            //Infra Dados
            services.AddSingleton(typeof(IRepository<>), typeof(RepositoryBase<>));
            services.AddSingleton<IClienteRepository, ClienteRepository>();
            services.AddSingleton<IEnderecoRepository, EnderecoRepository>();

            //Context
             services.AddSingleton<CursoAspNetCoreContext>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
