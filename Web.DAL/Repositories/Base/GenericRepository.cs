using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Web.DAL.Base.Interfaces;

namespace Web.DAL.Base
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity :class
    {
        bool disposed = false;

        protected DbContext _dbContext;

        public GenericRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(false);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                _dbContext.Dispose();
            }

            disposed = true;
        }

        public TEntity Find(Guid id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }

        public void Create(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
        }

        public int Complete()
        {
            return _dbContext.SaveChanges();
        }
    }
}
