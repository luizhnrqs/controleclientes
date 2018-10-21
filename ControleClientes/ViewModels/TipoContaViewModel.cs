using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleClientes.ViewModels
{
    public class TipoContaViewModel
    {
        [Key]
        public int IdTipoConta { get; set; }
        [DisplayName("Nome do tipo da Conta")]
        public string NomeTipoConta { get; set; }
    }
}