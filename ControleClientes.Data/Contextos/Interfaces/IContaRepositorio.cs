using ControleClientes.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientes.Data.Contextos.Interfaces
{
    public interface IContaRepositorio : IRepositorioBase<Conta>
    {
        Conta BuscarContaPorNumeroConta(int numeroConta);
        void DebitarSaldo(Conta conta, double valor);
        void CreditarSaldo(Conta conta, double valor);
    }
}
