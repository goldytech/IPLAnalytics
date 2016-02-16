namespace IPLAnalytics.Web.Services
{
    using System.Security.Cryptography.X509Certificates;

    using IPLAnalytics.Web.ViewModels;

    /// <summary>
    /// The ViewModelService <see langword="interface"/>.
    /// </summary>
    public interface IViewModelService
    {
        /// <summary>
        /// The get dashboard view model.
        /// </summary>
        /// <returns>
        /// The <see cref="DashboardViewModel"/>.
        /// </returns>
        DashboardViewModel GetDashboardViewModel();
    }
}