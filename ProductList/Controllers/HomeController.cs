using System.Web.Mvc;

namespace ProductList.Controllers
    {
    public class HomeController : Controller
        {
        // GET: Home
        public ActionResult Index()
            {
            return View();
            }
        }
    }