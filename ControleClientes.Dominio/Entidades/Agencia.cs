using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientes.Dominio.Entidades
{
    public class Agencia
    {
        [Key]
        public int IdAgencia { get; set; }
        public string NomeAgencia { get; set; }
    }
}
