using Imaftec.Gps.Monitor.Application.Interfaces;
using Imaftec.Gps.Monitor.Domain.Entities;
using Imaftec.Gps.Monitor.Domain.Interfaces.Services;

namespace Imaftec.Gps.Monitor.Application.App
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
