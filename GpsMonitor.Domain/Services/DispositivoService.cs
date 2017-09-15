using GpsMonitor.Domain.Entities;
using GpsMonitor.Domain.Interfaces.Repositories;
using GpsMonitor.Domain.Interfaces.Services;

namespace GpsMonitor.Domain.Services
{
    public class DispositivoService : ServiceBase<Dispositivo>, IDispositivoService
    {
        #region Fields

        private readonly IDispositivoRepository _dispositivoRepository;

        #endregion

        #region Constructors

        public DispositivoService(IDispositivoRepository disDipositivoRepository)
            : base(disDipositivoRepository)
        {
            _dispositivoRepository = disDipositivoRepository;

            #endregion

            #region Methods

            #endregion
        }
    }

}