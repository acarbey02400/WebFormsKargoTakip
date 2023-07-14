using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using WebFormsKargoTakip.Model.Common;

namespace WebFormsKargoTakip.DataAccess.Repositories
{
    public class RepositoryBase<TContext, TEntity> : IRepository<TEntity>
        where TEntity : BaseEntity,new()
        where TContext : DbContext,new()
    {
        public TEntity Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
                return entity;
            }
        }

        public bool Delete(int id)
        {
            using (TContext context = new TContext())
            {
                var entity =context.Set<TEntity>().SingleOrDefault(p=>p.Id==id);
                var deletedEntity=context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
                return true;
            }
            
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                var entity = context.Set<TEntity>().SingleOrDefault(filter);
                return entity;
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter==null? context.Set<TEntity>().ToList(): context.Set<TEntity>().Where(filter).ToList();
               
            }
        }

        public TEntity Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Modified;
                context.SaveChanges();
                return entity;
            }
        }
    }
}