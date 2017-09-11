using System.Web.Mvc;
using Imaftec.Gps.Monitor.Application.Interfaces;
using Imaftec.Gps.Monitor.Domain.Entities;
using Imaftec.Gps.Monitor.Mvc.Controllers.Shared;

namespace Imaftec.Gps.Monitor.Mvc.Controllers
{
    public class HomeController : CustomController
    {
        private readonly ILocalizacaoApp _localizacao;

        public ActionResult Index()
        {
            return View();
        }

        public HomeController(ILocalizacaoApp localizacao)
        {
            _localizacao = localizacao;
        }

        public void Receive(string dispositivoId, string latitude, string longitude)
        {
            _localizacao.Add(new Localizacao {DispositivoId = dispositivoId, Latitude = latitude, Longitude = longitude});

        }
    }
}