using CursoAspNetCore.Domain.Entities;

namespace CursoAspNetMvc.Infra.Data.EntityConfig
{
    public class EnderecoConfiguration : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfiguration()
        {
            HasKey(p => p.EnderecoId);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.Logradouro)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.Complemento)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.Numero)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.Bairro)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.Complemento)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.CEP)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.Cidade)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.Estado)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.Ativo)
                .IsRequired();


            ToTable("Endereco");
        }
    }
}
