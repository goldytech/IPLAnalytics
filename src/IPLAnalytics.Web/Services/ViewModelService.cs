namespace IPLAnalytics.Web.Services
{
    using IPLAnalytics.Web.ViewModels;
    using Microsoft.AspNet.Mvc;

    public class ViewModelService : IViewModelService
    {
        private readonly IDataService dataService;

        private readonly IUrlHelper urlHelper;

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModelService"/> class.
        /// </summary>
        /// <param name="dataService">
        /// The data service.
        /// </param>
        /// <param name="urlHelper">
        /// The url helper.
        /// </param>
        public ViewModelService(IDataService dataService, IUrlHelper urlHelper)
        {
            this.dataService = dataService;
            this.urlHelper = urlHelper;
        }

        /// <summary>
        /// The get dashboard view model.
        /// </summary>
        /// <returns>
        /// The <see cref="DashboardViewModel"/>.
        /// </returns>
        public DashboardViewModel GetDashboardViewModel()
        {
            return new DashboardViewModel
                       {
                           DelhiDareDevils = new TileViewModel
                                   {
                                       AverageRunPerOver = this.dataService.GetAverageRunPerOver(),
                                       ColorCssClass = "panel-primary",
                                       TeamName = "Delhi Dare Devils",
                                       Url = this.urlHelper.Action("GetDelhiDareDevilsChart", "History"),
                                       IconCssClass = "fa-sliders"
                                   },
                           KolkotaKnightRiders = new TileViewModel
                                   {
                                       AverageRunPerOver = this.dataService.GetAverageRunPerOver(),
                                       ColorCssClass = "panel-yellow",
                                       TeamName = "Kolkota Knight Riders",
                                       Url = this.urlHelper.Action("GetKolkotaKnightRidersChart",  "History"),
                                       IconCssClass = "fa-car"
                                   },
                           MumbaiIndians = new TileViewModel
                                   {
                                       AverageRunPerOver = this.dataService.GetAverageRunPerOver(),
                                       ColorCssClass = "panel-red",
                                       TeamName = "Mumbai Indians",
                                       Url = this.urlHelper.Action("GetMumbaiIndiansChart", "History"),
                                       IconCssClass = "fa-sliders"
                                   }
                       };
        }
    }
}