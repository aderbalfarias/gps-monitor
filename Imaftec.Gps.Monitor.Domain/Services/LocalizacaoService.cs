using Imaftec.Gps.Monitor.Domain.Entities;
using Imaftec.Gps.Monitor.Domain.Interfaces.Repositories;
using Imaftec.Gps.Monitor.Domain.Interfaces.Services;

namespace Imaftec.Gps.Monitor.Domain.Services
{
    public class LocalizacaoService : ServiceBase<Localizacao>, ILocalizacaoService
    {
        #region Fields

        private readonly ILocalizacaoRepository _localizacaoRepository;

        #endregion
        
        #region Constructors

        public LocalizacaoService(ILocalizacaoRepository localizacaoRepository)
            : base(localizacaoRepository)
        {
            _localizacaoRepository = localizacaoRepository;
        }

        #endregion

        #region Methods

        #endregion
    }
}