using GpsMonitor.Domain.Entities;

namespace GpsMonitor.Application.Interfaces
{
    public interface IEmailApp
    {
        void SendEmail(Email entity);
    }
}
