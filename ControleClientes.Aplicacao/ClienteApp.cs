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
    public class ClienteApp : BaseApp<Cliente>, IClienteApp
    {
        private readonly IClienteRepositorio _repositorio;

        public ClienteApp(IUnitOfWork unit, IClienteRepositorio repositorio)
            : base(repositorio, unit)
        {
            _repositorio = repositorio;
        }
    }
}
