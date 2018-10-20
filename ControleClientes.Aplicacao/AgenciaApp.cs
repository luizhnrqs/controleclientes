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
    public class AgenciaApp : BaseApp<Agencia>, IAgenciaApp
    {
        private readonly IAgenciaRepositorio _repositorio;

        public AgenciaApp(IUnitOfWork unit, IAgenciaRepositorio repositorio)
            : base(repositorio, unit)
        {
            _repositorio = repositorio;
        }
    }
}
