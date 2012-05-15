using System.Web.Mvc;

namespace PopApps.Monitor.Controllers
{
    public class HomeController : BaseController
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }

    }
}
