using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientes.Dominio.Entidades
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public string Nome { get => $"{PrimeiroNome.Trim()} {SobreNome.Trim()}"; }
        public string PrimeiroNome { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public string CPF { get; set; }
        public virtual ICollection<Conta> Contas { get; set; }
    }
}
