using ControleClientes.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ControleClientes.Data.Contextos
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            HasKey(x => x.IdCliente);

            Property(x => x.PrimeiroNome)
                .IsRequired()
                .HasMaxLength(150);

            Property(x => x.SobreNome)
                .IsRequired()
                .HasMaxLength(150);

            Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(150);

            Property(x => x.Ativo)
                .IsRequired();

            Property(x => x.CPF)
                .IsRequired();
        }
    }
}