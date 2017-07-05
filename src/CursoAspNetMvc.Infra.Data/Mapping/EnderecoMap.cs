using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CursoAspNetCore.Domain.Models;
using CursoAspNetCore.Infra.Data.Extensions;


namespace CursoAspNetCore.Infra.Data.Mappings
{
	public class EnderecoMap : EntityTypeConfiguration<Endereco>
	{
		public override void Map(EntityTypeBuilder<Endereco> builder)
		{
			builder.Property(c => c.EnderecoId)
				.HasColumnName("EnderecoId");

			builder.Property(c => c.Logradouro)
				.HasColumnType("varchar(100)")
				.HasMaxLength(100)
				.IsRequired();

			builder.Property(c => c.Complemento)
				.HasColumnType("varchar(100)")
				.HasMaxLength(11)
				.IsRequired();

			builder.Property(c => c.Numero)
				.HasColumnType("varchar(100)")
				.HasMaxLength(100)
				.IsRequired();

			builder.Property(c => c.Bairro)
				.HasColumnType("varchar(100)")
				.HasMaxLength(100)
				.IsRequired();

			builder.Property(c => c.CEP)
				.HasColumnType("varchar(10)")
				.HasMaxLength(10)
				.IsRequired();

			builder.Property(c => c.Cidade)
				.HasColumnType("varchar(100)")
				.HasMaxLength(100)
				.IsRequired();

			builder.Property(c => c.Estado)
				.HasColumnType("varchar(2)")
				.HasMaxLength(2)
				.IsRequired();		

			builder.Property(c => c.Ativo)
				.IsRequired();
		}
	}
}