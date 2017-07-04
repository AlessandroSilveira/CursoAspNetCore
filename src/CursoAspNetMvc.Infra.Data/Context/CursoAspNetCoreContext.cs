using CursoAspNetCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace CursoAspNetMvc.Infra.Data.Context
{
    public class CursoAspNetCoreContext : DbContext
    {

		public IConfigurationRoot Configurtion { get; set; }

        public CursoAspNetCoreContext(DbContextOptions<CursoAspNetCoreContext> option)
            : base(option)
        {
			Database.EnsureCreated();
        }

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Endereco> Endereco { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
		{
			if (!optionBuilder.IsConfigured)
				optionBuilder.UseSqlServer(RetornaUrlConnection());
		}

		public string RetornaUrlConnection()
		{
			var builder = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory());

			Configurtion = builder.Build();

			string connection = Configurtion.GetConnectionString("DefaultConnection");

			return connection;
		}
    }
}
