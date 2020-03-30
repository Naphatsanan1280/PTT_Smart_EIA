using System.Web.Mvc;
namespace PTT_Smart_EIA.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Homepage()
        {
            return View();
        }

        public ActionResult MenuProject()
        {
            return View();
        }
        public ActionResult EnvironmentalRegulartory()
        {
            return View();
        }

        public ActionResult EnvironmentalSmartImap()
        {
            return View();
        }
        public ActionResult Gis()
        {
            return View();
        }

        public ActionResult PipelineTransportation()
        {

            return View();
        }

        public ActionResult LargeBuildings()
        {

            return View();
        }

        public ActionResult Hospital()
        {
            return View();
        }

        public ActionResult Hotel()
        {
            return View();
        }

        public ActionResult ResidentialBuildings()
        {
            return View();
        }
        public ActionResult Industrialestate()
        {
            return View();
        }
       public ActionResult Wasteadjustment()
        {
            return View();
        }
        public ActionResult Landallocation()
        {
            return View();
        }
    }
}