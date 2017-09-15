using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using GpsMonitor.Data.EntityConfig;
using GpsMonitor.Domain.Interfaces.Repositories;

namespace GpsMonitor.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        #region Fields

        //ReSharper disable once InconsistentNaming
        protected readonly EntityContext _context = new EntityContext();

        #endregion

        #region Methods

        public void Add(TEntity objModel)
        {
            _context.Set<TEntity>().Add(objModel);
            _context.SaveChanges();
        }

        public TEntity GetId(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public void Update(TEntity objModel)
        {
            _context.Entry(objModel).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Remove(TEntity objModel)
        {
            _context.Set<TEntity>().Remove(objModel);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        #endregion
    }
}
