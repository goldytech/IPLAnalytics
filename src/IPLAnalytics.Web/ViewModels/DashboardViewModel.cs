namespace IPLAnalytics.Web.ViewModels
{
    /// <summary>
    /// The dashboard view model.
    /// </summary>
    public class DashboardViewModel
    {
        /// <summary>
        /// Gets or sets the KolkotaKnightriders tile.
        /// </summary>
        public TileViewModel KolkotaKnightRiders { get; set; }

        /// <summary>
        /// Gets or sets the DelhiDareDevils Tile.
        /// </summary>
        public TileViewModel DelhiDareDevils { get; set; }

        /// <summary>
        /// Gets or sets the Mumbai Indians tile.
        /// </summary>
        public TileViewModel MumbaiIndians { get; set; }
    }
}