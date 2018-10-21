using ControleClientes.Data.Contextos.Interfaces;
using ControleClientes.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientes.Data.Contextos.Repositorios
{
    public class ClienteRepositorio : RepositorioBase<Cliente>, IClienteRepositorio
    {
        private readonly IUnitOfWork _unit;

        public ClienteRepositorio(IUnitOfWork unit)
            : base(unit)
        {
            _unit = unit;
        }

        public Cliente BuscarClientePorCPF(string CPF)
        {
            return _unit.Contexto.Set<Cliente>().Where(x => x.CPF == CPF && x.Ativo).FirstOrDefault();
        }

        public Cliente BuscarClientePorEmail(string email)
        {
            return _unit.Contexto.Set<Cliente>().Where(x => x.Email == email && x.Ativo).FirstOrDefault();
        }

        public IEnumerable<Cliente> BuscarClientePorNome(string nome)
        {
            return _unit.Contexto.Set<Cliente>().Where(x => x.PrimeiroNome.Contains(nome) || x.SobreNome.Contains(nome) && x.Ativo);
        }
    }
}
