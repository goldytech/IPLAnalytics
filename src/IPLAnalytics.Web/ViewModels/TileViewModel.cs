namespace IPLAnalytics.Web.ViewModels
{
    /// <summary>
    /// The tile view model.
    /// </summary>
    public class TileViewModel
    {
        /// <summary>
        /// Gets or sets the team name.
        /// </summary>
        public string TeamName { get; set; }

        /// <summary>
        /// Gets or sets the average run per over.
        /// </summary>
        public int AverageRunPerOver { get; set; }

        /// <summary>
        /// Gets or sets the url.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the icon css class.
        /// </summary>
        public string IconCssClass { get; set; }

        /// <summary>
        /// Gets or sets the color css class.
        /// </summary>
        public string ColorCssClass { get; set; }
    }
}