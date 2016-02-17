// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace IPLAnalytics.Web.Controllers
{
    using IPLAnalytics.Web.Services;

    using Microsoft.AspNet.Mvc;

    public class HomeController : Controller
    {
        private readonly IViewModelService viewModelService;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController"/> class.
        /// </summary>
        /// <param name="viewModelService">
        /// The view model service.
        /// </param>
        public HomeController(IViewModelService viewModelService)
        {
            this.viewModelService = viewModelService;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "IPL Analytics App2";
            return View(this.viewModelService.GetDashboardViewModel());
        }
    }
}
