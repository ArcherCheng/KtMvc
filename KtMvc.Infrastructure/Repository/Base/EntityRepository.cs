using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KtMvc.Domain.Repository;
using KtMvc.Domain.Models;
using System.Data.Entity;
using KtMvc.Infrastructure.Context;

namespace KtMvc.Infrastructure.Repository
{
    public class EntityRepository<TEntity> : IRepository<TEntity>, IUnitOfWorkRepository
        where TEntity : class
    {
        internal KtMvcModel1 _db;
        internal DbSet<TEntity> _dbSet;

        public DbContext context
        {
            set
            {
                _db = (KtMvcModel1)value;
                _dbSet = _db.Set<TEntity>();
            }
        }

        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public IEnumerable<TEntity> FindAll()
        {
            return _dbSet;
        }

        public TEntity FindById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Update(TEntity entity)
        {
            var entry = _db.Entry(entity);
            _dbSet.Attach(entity);
            entry.State = EntityState.Modified;

        }
    }
}
