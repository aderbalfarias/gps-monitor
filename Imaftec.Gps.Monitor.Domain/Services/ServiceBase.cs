using System;
using System.Collections.Generic;
using Imaftec.Gps.Monitor.Domain.Interfaces.Repositories;
using Imaftec.Gps.Monitor.Domain.Interfaces.Services;

namespace Imaftec.Gps.Monitor.Domain.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        #region Fields

        private readonly IRepositoryBase<TEntity> _repository;

        #endregion
        
        #region Constructors

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        #endregion

        #region Methods

        public void Add(TEntity objModel)
        {
            _repository.Add(objModel);
        }

        public TEntity GetId(int id)
        {
            return _repository.GetId(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(TEntity objModel)
        {
            _repository.Update(objModel);
        }

        public void Remove(TEntity objModel)
        {
            _repository.Remove(objModel);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

        #endregion
    }
}
