using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPLAnalytics.Web.ViewComponents
{
    using Microsoft.AspNet.Mvc;
    using Microsoft.Extensions.OptionsModel;

    using Options;

    using Services;

    /// <summary>
    /// The alert view component.
    /// </summary>
    public class AlertViewComponent :ViewComponent
    {
        private readonly IDataService dataService;

        private readonly ThresholdOptions thresholdOptions;

        public AlertViewComponent(IDataService dataService,IOptions<ThresholdOptions> thresholdOptions )
        {
            this.dataService = dataService;
            this.thresholdOptions = thresholdOptions.Value;
        }

        public IViewComponentResult Invoke()
        {
            var viewModel = new List<string>();
            if (this.dataService.GetAverageRunPerOver() > this.thresholdOptions.AverageRunPerOver)
            {
                viewModel.Add("Great performance !!!");
            }

            return View(viewModel);
        }
    }
}
