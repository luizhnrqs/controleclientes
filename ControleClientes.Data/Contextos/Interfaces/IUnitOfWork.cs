using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientes.Data.Contextos.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ControleClienteContexto Contexto { get; }
        void Save();
    }
}
