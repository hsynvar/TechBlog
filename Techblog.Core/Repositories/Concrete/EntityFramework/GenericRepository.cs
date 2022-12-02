using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Techblog.Core.Entities;
using Techblog.Core.Entities.Interfaces;
using Techblog.Core.Repositories.Abstract;

namespace Techblog.Core.Repositories.Concrete.EntityFramework
{
    public class GenericRepository<TEntity, TContext> : IGenericRepository<TEntity> where
    TEntity : BaseEntity, IEntity where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using TContext context = new();
            EntityEntry<TEntity> entityEntry = context.Entry(entity);
            entityEntry.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
          using TContext context = new();
            EntityEntry<TEntity> entityEntry = context.Entry(entity);
            entityEntry.State = EntityState.Deleted;
            context.SaveChanges();

        }

        public IEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using TContext context = new();
            return context.Set<TEntity>().FirstOrDefault(filter);

        
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null)
        {
            using TContext context= new();
            var entity= context.Set<TEntity>();
            return filter is not null ? entity.Where(filter).ToList() : entity.ToList();
        }

        public void Update(TEntity entity)
        {
             using TContext context = new();
            EntityEntry<TEntity> entityEntry = context.Entry(entity);
            entityEntry.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}