using System.Web.Mvc;
using GpsMonitor.Mvc.Controllers.Shared;

namespace GpsMonitor.Mvc.Controllers
{
    public class MapsController : CustomController
    {
        // GET: Maps
        public ActionResult Index()
        {
            return View();
        }
    }
}