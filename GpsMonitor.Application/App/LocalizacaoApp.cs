using GpsMonitor.Application.Interfaces;
using GpsMonitor.Domain.Entities;
using GpsMonitor.Domain.Interfaces.Services;

namespace GpsMonitor.Application.App
{
    public class LocalizacaoApp : AppBase<Localizacao>, ILocalizacaoApp
    {
        #region Fields

        private readonly ILocalizacaoService _localizacaoService;

        #endregion
        
        #region Constructors

        public LocalizacaoApp(ILocalizacaoService localizacaoService)
            : base(localizacaoService)
        {
            _localizacaoService = localizacaoService;
        }

        #endregion

        #region Methods

        #endregion
    }
}
