using Imaftec.Gps.Monitor.Domain.Entities;
using Imaftec.Gps.Monitor.Domain.Interfaces.Repositories;
using Imaftec.Gps.Monitor.Domain.Interfaces.Services;

namespace Imaftec.Gps.Monitor.Domain.Services
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