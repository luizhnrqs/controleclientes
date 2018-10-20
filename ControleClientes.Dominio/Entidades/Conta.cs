using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientes.Dominio.Entidades
{
    public class Conta
    {
        [Key]
        public int IdConta { get; set; }
        public int IdAgencia { get; set; }
        public int IdCliente { get; set; }
        public int IdTipoConta { get; set; }
        public int NumeroConta { get; set; }
        public double Saldo { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Agencia Agencia { get; set; }
        public virtual TipoConta TipoConta { get; set; }
    }
}
