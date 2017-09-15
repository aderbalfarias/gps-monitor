using System.Collections.Generic;

namespace GpsMonitor.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity objModel);
        TEntity GetId(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity objModel);
        void Remove(TEntity objModel);
        void Dispose(); 
    }
}
