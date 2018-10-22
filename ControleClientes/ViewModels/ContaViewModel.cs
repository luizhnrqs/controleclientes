using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleClientes.ViewModels
{
    public class ContaViewModel
    {
        [Key]
        public int IdConta { get; set; }
        [DisplayName("Número da Conta")]
        public int NumeroConta { get; set; }
        [DisplayName("Nome do Cliente")]
        public string NomeCliente { get; set; }
        [DisplayName("Tipo da Conta")]
        public string TipoConta { get; set; }
        [DisplayName("Saldo em Conta")]
        public double Saldo { get; set; }
        public string NumeroContaCliente { get => $"{NumeroConta} - {NomeCliente}"; }
    }
}