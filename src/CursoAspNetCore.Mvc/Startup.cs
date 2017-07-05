using CursoAspNetCore.Application.Interface;
using CursoAspNetCore.Application.Interface.Repository;
using CursoAspNetCore.Domain.Interfaces.Repository;
using CursoAspNetCore.Domain.Services;
using CursoAspNetMvc.Infra.Data.Context;
using CursoAspNetMvc.Infra.Data.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;

namespace CursoAspNetCore.Mvc
{

	public class Startup
	{
		private Container container = new Container();

		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc();

			services.AddTransient<IClienteRepository, ClienteRepository>();
			services.AddTransient<IEnderecoRepository, EnderecoRepository>();

			services.AddTransient<IEnderecoAppService, EnderecoAppService>();
			services.AddTransient<IClienteAppService, ClienteAppService>();

			services.AddTransient<IClienteService, ClienteService>();
			services.AddTransient<IClienteService, ClienteService>();

			services.AddTransient<CursoAspNetCoreContext>();
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