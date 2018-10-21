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

        public void CreditarSaldo(Conta conta, double valor)
        {
            Conta _conta = _unit.Contexto.Set<Conta>().Where(x => x.NumeroConta == conta.NumeroConta).FirstOrDefault();
            _conta.Saldo -= valor;

            _unit.Save();
        }

        public void DebitarSaldo(Conta conta, double valor)
        {
            Conta _conta = _unit.Contexto.Set<Conta>().Where(x => x.NumeroConta == conta.NumeroConta).FirstOrDefault();
            _conta.Saldo += valor;

            _unit.Save();
        }
    }
}
