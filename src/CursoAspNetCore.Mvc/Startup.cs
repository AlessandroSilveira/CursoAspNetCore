using AutoMapper;
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
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SimpleInjector;
using SimpleInjector.Integration.AspNetCore;
using SimpleInjector.Integration.AspNetCore.Mvc;
using SimpleInjector.Lifestyles;


namespace CursoAspNetCore.Mvc {
    
    public class Startup {
       private Container container = new Container ();
        public Startup (IConfiguration configuration) {
             
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices (IServiceCollection services) {
            services.AddMvc ();

            services.AddAutoMapper ();

            services.AddSingleton<IControllerActivator> (
                new SimpleInjectorControllerActivator (container));
            services.AddSingleton<IViewComponentActivator> (
                new SimpleInjectorViewComponentActivator (container));

            services.UseSimpleInjectorAspNetRequestScoping (container);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure (IApplicationBuilder app, IHostingEnvironment env) {
            InitializeContainer (app);

            //container.Register<CustomMiddleware1>();
            //container.Register<CustomMiddleware2>();

            container.Verify ();

            if (env.IsDevelopment ()) {
                app.UseDeveloperExceptionPage ();
            } else {
                app.UseExceptionHandler ("/Home/Error");
            }

            app.UseStaticFiles ();

            app.UseMvc (routes => {
                routes.MapRoute (
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
        private void InitializeContainer (IApplicationBuilder app) {

            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle ();

            // Add application presentation components:
            container.RegisterMvcControllers (app);
            container.RegisterMvcViewComponents (app);

            // Add application services. For instance:
            // container.Register<IUserRepository, SqlUserRepository>(Lifestyle.Scoped);

            //App
            container.Register<IClienteAppService, ClienteAppService> (Lifestyle.Scoped);
            container.Register<IEnderecoAppService, EnderecoAppService> (Lifestyle.Scoped);

            //Domain
            //container.Register(typeof(IServiceBase<>), typeof(ServiceBase<>));
            container.Register<IClienteService, ClienteService> (Lifestyle.Scoped);
            container.Register<IEnderecoService, EnderecoService> (Lifestyle.Scoped);

            //Infra Dados
            container.Register (typeof (IRepository<>), typeof (RepositoryBase<>));
            container.Register<IClienteRepository, ClienteRepository> (Lifestyle.Scoped);
            container.Register<IEnderecoRepository, EnderecoRepository> (Lifestyle.Scoped);
            container.Register<IUnitOfWork, UnitOfWork> (Lifestyle.Scoped);

            //container.Register<DbContextOptionsBuilder<CursoAspNetCoreContext>> (.LifestyleScoped);
            container.Register(typeof(DbContextOptionsBuilder<>));

            container.Register<DbContextOptionsBuilder>(() => new DbContextOptionsBuilder<CursoAspNetCoreContext>());
          
            
        }
    }
}