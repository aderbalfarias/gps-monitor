using GpsMonitor.Application.Interfaces;
using GpsMonitor.Domain.Entities;
using GpsMonitor.Domain.Interfaces.Services;

namespace GpsMonitor.Application.App
{
    public class DispositivoApp : AppBase<Dispositivo>, IDispositivoApp
    {
        #region Fields

        private readonly IDispositivoService _dispositivoService;

        #endregion
        
        #region Constructors

        public DispositivoApp(IDispositivoService dispositivoService)
            : base(dispositivoService)
        {
            _dispositivoService = dispositivoService;
        }

        #endregion

        #region Methods

        #endregion
    }
}
