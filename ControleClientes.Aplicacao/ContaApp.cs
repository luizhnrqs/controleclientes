using ControleClientes.Aplicacao.Interfaces;
using ControleClientes.Data.Contextos.Interfaces;
using ControleClientes.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientes.Aplicacao
{
    public class ContaApp : BaseApp<Conta>, IContaApp
    {
        private readonly IContaRepositorio _repositorio;

        public ContaApp(IUnitOfWork unit, IContaRepositorio repositorio)
            : base(repositorio, unit)
        {
            _repositorio = repositorio;
        }

        public Conta BuscarPorNumeroConta(int numeroConta)
        {
            return _repositorio.BuscarPorNumeroConta(numeroConta);
        }

        public void Transferir(string numContaOrigem, string numContaDestino, double valor)
        {
            if(valor > 0)
            {
                if (_repositorio.possuiSaldoSuficiente(Convert.ToInt32(numContaOrigem), valor))
                {
                    _repositorio.Transferir(Convert.ToInt32(numContaOrigem), Convert.ToInt32(numContaDestino), valor);
                }

                else
                {
                    throw new Exception($"Conta {numContaOrigem} não possui saldo para realizar transferência.");
                }
            }

            else
            {
                throw new Exception($"Não é possível realizar transferência de valor negativo.");
            }
        }
    }
}
