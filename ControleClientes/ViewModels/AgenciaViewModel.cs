using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleClientes.ViewModels
{
    public class AgenciaViewModel
    {
        [Key]
        public int IdAgencia { get; set; }
        [DisplayName("Nome da Agência")]
        public string NomeAgencia { get; set; }
        [DisplayName("Endereço da Agência")]
        public string Endereco { get; set; }
    }
}