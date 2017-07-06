namespace RaspberryWebApp.WebAPI.Controllers
{
    using System.Web.Http;

    public class HomeController : ApiController
    {
        [HttpGet]
        [Route("api/home")]
        public bool Home()
        {
            return true;
        }
    }
}
