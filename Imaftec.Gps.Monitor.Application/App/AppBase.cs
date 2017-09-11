using System;
using System.Collections.Generic;
using Imaftec.Gps.Monitor.Application.Interfaces;
using Imaftec.Gps.Monitor.Domain.Interfaces.Services;

namespace Imaftec.Gps.Monitor.Application.App
{
    public class AppBase<TEntity> : IDisposable, IAppBase<TEntity> where TEntity : class
    {
        #region Fields

        private readonly IServiceBase<TEntity> _serviceBase;

        #endregion

        #region Constructors

        public AppBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        #endregion

        #region Methods

        public void Add(TEntity objModel)
        {
            _serviceBase.Add(objModel);
        }

        public TEntity GetId(int id)
        {
            return _serviceBase.GetId(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _serviceBase.GetAll();
        }

        public void Update(TEntity objModel)
        {
            _serviceBase.Update(objModel);
        }

        public void Remove(TEntity objModel)
        {
            _serviceBase.Remove(objModel);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }

        #endregion
    }
}
