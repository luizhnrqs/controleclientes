using ControleClientes.Data.Contextos.Interfaces;
using ControleClientes.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientes.Data.Contextos.Repositorios
{
    public class ContaRepositorio : RepositorioBase<Conta>, IContaRepositorio
    {
        private readonly IUnitOfWork _unit;

        public ContaRepositorio(IUnitOfWork unit)
            : base(unit)
        {
            _unit = unit;
        }

        public Conta BuscarPorNumeroConta(int numeroConta)
        {
            return _unit.Contexto.Set<Conta>().Where(x => x.NumeroConta == numeroConta).FirstOrDefault();
        }

        public bool possuiSaldoSuficiente(int numContaOrigem, double valor)
        {
            Conta _conta = _unit.Contexto.Set<Conta>().Where(x => x.NumeroConta == numContaOrigem).FirstOrDefault();

            return _conta.Saldo > valor;
        }

        public void Transferir(int numContaOrigem, int numContaDestino, double valor)
        {
            Conta _contaOrigem = _unit.Contexto.Set<Conta>().Where(x => x.NumeroConta == numContaOrigem).FirstOrDefault();
            Conta _contaDestino = _unit.Contexto.Set<Conta>().Where(x => x.NumeroConta == numContaDestino).FirstOrDefault();

            CreditarSaldo(_contaDestino, valor);
            DebitarSaldo(_contaOrigem, valor);
        }

        private void CreditarSaldo(Conta conta, double valor)
        {
            Conta _conta = _unit.Contexto.Set<Conta>().Where(x => x.NumeroConta == conta.NumeroConta).FirstOrDefault();
            _conta.Saldo += valor;

            _unit.Save();
        }

        private void DebitarSaldo(Conta conta, double valor)
        {
            Conta _conta = _unit.Contexto.Set<Conta>().Where(x => x.NumeroConta == conta.NumeroConta).FirstOrDefault();
            _conta.Saldo -= valor;

            _unit.Save();
        }
    }
}
