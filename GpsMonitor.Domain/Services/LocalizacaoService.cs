using GpsMonitor.Domain.Entities;
using GpsMonitor.Domain.Interfaces.Repositories;
using GpsMonitor.Domain.Interfaces.Services;

namespace GpsMonitor.Domain.Services
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