/*using CursoAspNetCore.Domain.Entities;

namespace CursoAspNetMvc.Infra.Data.EntityConfig
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            HasKey(p => p.ClienteId);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.Sobrenome)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.DataCadastro)
                .IsRequired();

            Property(p => p.DataNascimento)
                .IsRequired();

            Property(p => p.Ativo)
                .IsRequired();


            ToTable("Cliente");
        }
    }
}*/
