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
    }
}
