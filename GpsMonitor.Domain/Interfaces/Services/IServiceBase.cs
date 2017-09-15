using System.Collections.Generic;

namespace GpsMonitor.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity objModel);
        TEntity GetId(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity objModel);
        void Remove(TEntity objModel);
        void Dispose(); 
    }
}
