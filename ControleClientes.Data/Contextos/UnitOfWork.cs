using ControleClientes.Data.Contextos.Interfaces;
using System;
using System.Data.Entity.Validation;

namespace ControleClientes.Data.Contextos
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly ControleClienteContexto _contexto;

        protected UnitOfWork() { }

        public UnitOfWork(ControleClienteContexto contexto)
        {
            _contexto = contexto;
        }

        public ControleClienteContexto Contexto => throw new NotImplementedException();

        public void Dispose()
        {
            if (_contexto != null)
                _contexto.Dispose();

            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            try
            {
                _contexto.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entidade do tipo \"{0}\" no estado \"{1}\" obteve os seguintes erros de validação:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Propriedade: \"{0}\", Erro: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw e;
            }
        }
    }
}
