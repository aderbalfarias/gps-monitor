using GpsMonitor.Domain.Entities;
using GpsMonitor.Domain.Interfaces.Repositories;
using GpsMonitor.Domain.Interfaces.Services;

namespace GpsMonitor.Domain.Services
{
    public class PerfilService : ServiceBase<Perfil>, IPerfilService
    {
        #region Fields

        private readonly IPerfilRepository _perfilRepository;

        #endregion
        
        #region Constructors

        public PerfilService(IPerfilRepository perfilRepository)
            : base(perfilRepository)
        {
            _perfilRepository = perfilRepository;
        }

        #endregion

        #region Methods

        #endregion
    }
}