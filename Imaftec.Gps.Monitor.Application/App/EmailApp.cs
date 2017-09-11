using Imaftec.Gps.Monitor.Application.Interfaces;
using Imaftec.Gps.Monitor.Domain.Entities;
using Imaftec.Gps.Monitor.Domain.Interfaces.Services;

namespace Imaftec.Gps.Monitor.Application.App
{
    public class EmailApp : IEmailApp
    {
        #region Fields

        private readonly IEmailService _emailService;

        #endregion

        #region Constructors

        public EmailApp(IEmailService emailService)
            //: base(emailService)
        {
            _emailService = emailService;
        }

        #endregion

        #region Methods

        public void SendEmail(Email entity)
        {
            _emailService.SendEmail(entity);
        }

        #endregion
    }
}
