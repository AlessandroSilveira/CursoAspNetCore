using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CursoAspNetCore.Domain.Models;
using CursoAspNetCore.Infra.Data.Extensions;


namespace CursoAspNetCore.Infra.Data.Mappings
{
	public class ClienteMap : EntityTypeConfiguration<Cliente>
	{
		public override void Map(EntityTypeBuilder<Cliente> builder)
		{
			builder.Property(c => c.ClienteId)
				.HasColumnName("ClienteId");

			builder.Property(c => c.Nome)
				.HasColumnType("varchar(100)")
				.HasMaxLength(100)
				.IsRequired();

			builder.Property(c => c.Email)
				.HasColumnType("varchar(100)")
				.HasMaxLength(11)
				.IsRequired();

			builder.Property(c => c.Sobrenome)
				.HasColumnType("varchar(100)")
				.HasMaxLength(100)
				.IsRequired();

			builder.Property(c => c.DataCadastro)
				.IsRequired();

			builder.Property(c => c.DataNascimento)
				.IsRequired();

			builder.Property(c => c.Ativo)
				.IsRequired();
		}
	}
}