using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleClientes.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int IdCliente { get; set; }
        public string Nome { get => $"{PrimeiroNome?.Trim()} {SobreNome?.Trim()}"; }

        [Required(ErrorMessage = "Preencha o campo Primeiro Nome")]
        [MaxLength(150, ErrorMessage ="Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("Primeiro nome")]
        public string PrimeiroNome { get; set; }

        [Required(ErrorMessage = "Preencha o campo SobreNome")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [DisplayName("Sobrenome")]
        public string SobreNome { get; set; }

        [Required(ErrorMessage = "Preencha o campo Email")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Preencha o campo CPF")]
        [MaxLength(11, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string CPF { get; set; }
    }
}