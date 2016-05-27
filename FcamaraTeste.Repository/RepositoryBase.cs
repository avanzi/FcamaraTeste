using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using FcamaraTeste.Domain.Interface;
using FcamaraTeste.Repository.EF;

namespace FcamaraTeste.Repository
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected EF.ProdutoContexto Contexto { get; private set; }


        public RepositoryBase()
        {
            Contexto = new EF.ProdutoContexto();
        }
        public void Add(TEntity entity)
        {
            Contexto.Set<TEntity>().Add(entity);
        }

        public void Remove(TEntity entity)
        {   Contexto.Set<TEntity>().Remove(entity);
        }

        public void Edit(TEntity entity)
        {
            Contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }

        public IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate)
        {
            return Contexto.Set<TEntity>().Where(predicate);
        }

        public IQueryable<TEntity> GetAll()
        {
            return Contexto.Set<TEntity>().AsQueryable();
        }

        public void Save()
        {
            Contexto.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
