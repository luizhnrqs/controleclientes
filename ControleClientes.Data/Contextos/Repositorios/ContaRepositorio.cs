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
    }
}
