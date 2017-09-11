using Imaftec.Gps.Monitor.Application.Interfaces;
using Imaftec.Gps.Monitor.Domain.Entities;
using Imaftec.Gps.Monitor.Domain.Interfaces.Services;

namespace Imaftec.Gps.Monitor.Application.App
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
