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
        Conta BuscarPorNumeroConta(int numeroConta);
        bool possuiSaldoSuficiente(int numContaOrigem, double valor);
        void Transferir(int numContaOrigem, int numContaDestino, double valor);
    }
}
