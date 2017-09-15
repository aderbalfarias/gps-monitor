using GpsMonitor.Application.Interfaces;
using GpsMonitor.Domain.Entities;
using GpsMonitor.Domain.Interfaces.Services;

namespace GpsMonitor.Application.App
{
    public class PerfilApp : AppBase<Perfil>, IPerfilApp
    {
        #region Fields

        private readonly IPerfilService _perfilService;

        #endregion
        
        #region Constructors

        public PerfilApp(IPerfilService perfilService)
            : base(perfilService)
        {
            _perfilService = perfilService;
        }

        #endregion

        #region Methods

        #endregion
    }
}
