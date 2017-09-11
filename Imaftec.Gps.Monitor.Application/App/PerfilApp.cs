using Imaftec.Gps.Monitor.Application.Interfaces;
using Imaftec.Gps.Monitor.Domain.Entities;
using Imaftec.Gps.Monitor.Domain.Interfaces.Services;

namespace Imaftec.Gps.Monitor.Application.App
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
