using System.Web.Mvc;
using GpsMonitor.Application.Interfaces;
using GpsMonitor.Domain.Entities;
using GpsMonitor.Mvc.Controllers.Shared;

namespace GpsMonitor.Mvc.Controllers
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