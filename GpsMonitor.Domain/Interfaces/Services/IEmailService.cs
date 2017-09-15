using GpsMonitor.Domain.Entities;

namespace GpsMonitor.Domain.Interfaces.Services
{
    public interface IEmailService
    {
        void SendEmail(Email entity);
    }
}
