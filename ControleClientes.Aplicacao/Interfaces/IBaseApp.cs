using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientes.Aplicacao.Interfaces
{
    public interface IBaseApp<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        TEntity Find(int id);
        IEnumerable<TEntity> List();
        void Update(TEntity obj);
        void Remove(TEntity obj);
    }
}
