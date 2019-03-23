using System;
using System.Collections.Generic;
using System.Text;

namespace Web.DAL.Base.Interfaces
{
    public interface IGenericRepository<TEntity> : IDisposable where TEntity : class
    {
        TEntity Find(Guid id);
        void Create(TEntity entity);
        int Complete();
    }
}