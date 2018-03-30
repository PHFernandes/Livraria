using Livraria.Entities;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Transactions;

namespace Livraria.Repository
{
    public abstract class BaseRepository<T> where T : class, IEntity
    {
        public LivrariaContext _ctx;

        public BaseRepository()
        {
            _ctx = new LivrariaContext();
        }

        public IQueryable<T> Query()
        {
            return _ctx.Set<T>().AsQueryable();
        }

        public int Salvar(T e)
        {
            _ctx.Set<T>().AddOrUpdate(e);
            _ctx.SaveChanges();

            return e.Id;
        }

        public T Obter(int id)
        {
            return _ctx.Set<T>().Find(id);
        }

        public List<T> Listar()
        {
            return _ctx.Set<T>().ToList();
        }

        public void Excluir(int id)
        {
            using (var scope = new TransactionScope(TransactionScopeOption.Required,
                new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
            {
                var e = Obter(id);

                var entry = _ctx.Set<T>();
                entry.Remove(e);
                _ctx.SaveChanges();

                scope.Complete();
            }
        }
    }
}