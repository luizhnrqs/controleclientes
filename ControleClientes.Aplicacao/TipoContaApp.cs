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
    public class TipoContaApp : BaseApp<TipoConta>, ITipoContaApp
    {
        private readonly ITipoContaRepositorio _repositorio;

        public TipoContaApp(IUnitOfWork unit, ITipoContaRepositorio repositorio)
            : base(repositorio, unit)
        {
            _repositorio = repositorio;
        }
    }
}
