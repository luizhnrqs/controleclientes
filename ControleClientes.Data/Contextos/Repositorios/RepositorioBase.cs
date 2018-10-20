using ControleClientes.Data.Contextos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientes.Data.Contextos.Repositorios
{
    public class RepositorioBase<TEntity> : IDisposable, IRepositorioBase<TEntity> where TEntity : class
    {
        protected readonly IUnitOfWork _unit;

        protected RepositorioBase() { }

        public RepositorioBase(IUnitOfWork unit)
        {
            _unit = unit;
        }

        public void Add(TEntity obj)
        {
            _unit.Contexto.Set<TEntity>().Add(obj);
        }

        public void Dispose()
        {
            _unit.Dispose();
        }

        public IEnumerable<TEntity> List()
        {
            return _unit.Contexto.Set<TEntity>();
        }

        public TEntity Find(int id)
        {
            return _unit.Contexto.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            _unit.Contexto.Set<TEntity>().Remove(obj);
        }

        public void Update(TEntity obj)
        {
            _unit.Contexto.Entry(obj).State = EntityState.Modified;
        }
    }
}
