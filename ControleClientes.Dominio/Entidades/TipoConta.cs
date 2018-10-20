using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientes.Dominio.Entidades
{
    public class TipoConta
    {
        [Key]
        public int IdTipoConta { get; set; }
        public string NomeTipoConta { get; set; }
    }
}
