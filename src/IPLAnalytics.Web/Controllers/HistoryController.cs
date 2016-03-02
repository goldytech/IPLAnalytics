using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace IPLAnalytics.Web.Controllers
{
    using IPLAnalytics.Web.ViewModels;

    public class HistoryController : Controller
    {
        // GET: /<controller>/
        public IActionResult GetDelhiDareDevilsChart()
        {
            return View("Chart",new ChartViewModel {Title = "Delhi Dare Devils Runs Per Over",DataUrl = "/api/chartdata"});
        }

        public IActionResult GetKolkotaKnightRidersChart()
        {
            return View("Chart", new ChartViewModel { Title = "Kolkota Knight Riders Runs Per Over", DataUrl = "/api/chartdata" });
        }

        public IActionResult GetMumbaiIndiansChart()
        {
            return View("Chart", new ChartViewModel { Title = "Mumbai Indians Runs Per Over", DataUrl = "/api/chartdata" });
        }
    }
}
