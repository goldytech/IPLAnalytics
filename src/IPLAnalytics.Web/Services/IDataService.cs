namespace IPLAnalytics.Web.Services
{
    using System.Collections.Generic;

    using Models;

    /// <summary>
    /// The DataService <see langword="interface"/>.
    /// </summary>
    public interface IDataService
    {
        /// <summary>
        /// The get run per over.
        /// </summary>
        /// <returns>
        /// The collection of RunPerOverModel/>.
        /// </returns>
        IEnumerable<RunPerOverModel> GetRunsInTwentyOvers();

        /// <summary>
        /// The get average run per over.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        int GetAverageRunPerOver();
    }
}