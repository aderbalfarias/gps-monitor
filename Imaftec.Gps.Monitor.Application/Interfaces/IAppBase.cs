using System.Collections.Generic;

namespace Imaftec.Gps.Monitor.Application.Interfaces
{
    public interface IAppBase<TEntity> where TEntity : class
    {
        void Add(TEntity objModel);
        TEntity GetId(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity objModel);
        void Remove(TEntity objModel);
        void Dispose();
    }
}
