using System.Linq.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Techblog.Core.Entities;
using Techblog.Core.Entities.Interfaces;

namespace Techblog.Core.Repositories.Abstract
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity, IEntity
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null );
        IEntity Get(Expression<Func<TEntity, bool>> filter);

    }
}