using ControleClientes.Aplicacao.Interfaces;
using ControleClientes.Data.Contextos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientes.Aplicacao
{
    public abstract class BaseApp<TEntity> : IBaseApp<TEntity> where TEntity : class
    {
        readonly IUnitOfWork _unit;
        readonly IRepositorioBase<TEntity> _repositorio;

        protected BaseApp(IRepositorioBase<TEntity> repositorio, IUnitOfWork unit)
        {
            _unit = unit;
            _repositorio = repositorio;
        }

        public void Add(TEntity obj)
        {
            _repositorio.Add(obj);
            _unit.Save();
        }

        public TEntity Find(int id)
        {
            return _repositorio.Find(id);
        }

        public IEnumerable<TEntity> List()
        {
            return _repositorio.List();
        }

        public void Remove(TEntity obj)
        {
            _repositorio.Remove(obj);
            _unit.Save();
        }

        public void Update(TEntity obj)
        {
            _repositorio.Update(obj);
            _unit.Save();
        }
    }
}
