using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientes.Data.Contextos.Interfaces
{
    public interface IRepositorioBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        TEntity Find(int id);
        IEnumerable<TEntity> List();
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();
    }
}
