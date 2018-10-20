using ControleClientes.Data.Contextos.Interfaces;
using ControleClientes.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientes.Data.Contextos.Repositorios
{
    public class AgenciaRepositorio : RepositorioBase<Agencia>, IAgenciaRepositorio
    {
        private readonly IUnitOfWork _unit;

        public AgenciaRepositorio(IUnitOfWork unit)
            : base(unit)
        {
            _unit = unit;
        }
    }
}
