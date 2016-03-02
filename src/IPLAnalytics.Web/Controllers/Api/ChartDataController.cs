// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace IPLAnalytics.Web.Controllers.Api
{
    using Microsoft.AspNet.Mvc;

    using Services;

    /// <summary>
    /// The chart data controller.
    /// </summary>
    [Route("api/[controller]")]
  public class ChartDataController : Controller
    {
        private readonly IDataService dataService;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartDataController"/> class.
        /// </summary>
        /// <param name="dataService">
        /// The data service.
        /// </param>
        public ChartDataController(IDataService dataService)
        {
            this.dataService = dataService;
        }


        /// <summary>
        /// GET: api/chartdata
        /// </summary>
        /// <returns>
        /// The runs per over collection/>.
        /// </returns>
        [HttpGet]
        public IActionResult Get()
        {
           return this.Ok(this.dataService.GetRunsInTwentyOvers());
        }
    }
}
