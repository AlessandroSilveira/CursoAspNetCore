using System.IO;
using CursoAspNetCore.Domain.Models;
using CursoAspNetCore.Infra.Data.Mappings;
using CursoAspNetCore.Infra.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using CursoAspNetCore.Domain.Entities;

namespace CursoAspNetCore.Infra.Data.Context
{
	public class EquinoxContext : DbContext
	{
		public DbSet<Cliente> Clientes { get; set; }
		public DbSet<Endereco> Enderecos { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.AddConfiguration(new ClienteMap());
			modelBuilder.AddConfiguration(new EnderecoMap());

			base.OnModelCreating(modelBuilder);
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			// get the configuration from the app settings
			var config = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json")
				.Build();

			// define the database to use
			optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
		}
	}
}
