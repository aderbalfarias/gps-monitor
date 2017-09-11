using Imaftec.Gps.Monitor.Domain.Entities;
using Imaftec.Gps.Monitor.Domain.Interfaces.Repositories;
using Imaftec.Gps.Monitor.Domain.Interfaces.Services;

namespace Imaftec.Gps.Monitor.Domain.Services
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