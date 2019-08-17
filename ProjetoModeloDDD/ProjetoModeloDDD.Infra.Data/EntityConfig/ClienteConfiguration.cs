using ProjetoModeloDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    /// <summary>
    /// Fluent API.
    /// Para mapear comportamento da minha entidade de domínio Cliente para ser modelado como uma tabela no banco dados.
    /// </summary>
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            HasKey(c => c.ClienteId);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Sobrenome)
               .IsRequired()
               .HasMaxLength(150);

            Property(c => c.Email)
               .IsRequired();
        }
    }
}