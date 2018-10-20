using ControleClientes.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientes.Data.Contextos
{
    public class ControleClienteContexto : DbContext
    {
        public ControleClienteContexto() 
            : base("ControleCliente")
        {
        }

        public DbSet<Agencia> Agencia { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Conta> Conta { get; set; }
        public DbSet<TipoConta> TipoConta { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new AgenciaMap());
            //modelBuilder.Configurations.Add(new ClienteMap());
            //modelBuilder.Configurations.Add(new ContaMap());
            //modelBuilder.Configurations.Add(new TipoContaMap());
        }
    }
}
