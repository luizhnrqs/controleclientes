using ControleClientes.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ControleClientes.Data.Contextos
{
    public class TipoContaMap : EntityTypeConfiguration<TipoConta>
    {
        public TipoContaMap()
        {
            HasKey(x => x.IdTipoConta);

            Property(x => x.NomeTipoConta)
                .IsRequired();
        }
    }
}