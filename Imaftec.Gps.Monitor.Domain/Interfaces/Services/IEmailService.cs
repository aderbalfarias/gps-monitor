using Imaftec.Gps.Monitor.Domain.Entities;

namespace Imaftec.Gps.Monitor.Domain.Interfaces.Services
{
    public interface IEmailService
    {
        void SendEmail(Email entity);
    }
}
