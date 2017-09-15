using System.Collections.Generic;
using System.Web.Http;
using GpsMonitor.Mvc.Models;

namespace GpsMonitor.Mvc.Controllers
{
    public class ApiMonitorController : ApiController
    {
        // GET: api/ApiMonitor
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ApiMonitor/5
        public string Get(int id)
        {
            return "value";
        }

        [Route("Receive")]
        public string Receive(LocalizacaoModel localizacao)
        {

            //TODO: Gravar no banco de dados


            return "Imei: " + localizacao.Imei + ", latitude: " + localizacao.Latitude + ", longitude" + localizacao.Longitude;
            
        }

        // POST: api/ApiMonitor
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ApiMonitor/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ApiMonitor/5
        public void Delete(int id)
        {
        }
    }
}
