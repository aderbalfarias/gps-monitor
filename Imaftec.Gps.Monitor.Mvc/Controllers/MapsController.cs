using System.Web.Mvc;
using Imaftec.Gps.Monitor.Mvc.Controllers.Shared;

namespace Imaftec.Gps.Monitor.Mvc.Controllers
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