namespace IPLAnalytics.Web.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using IPLAnalytics.Web.Models;

    /// <summary>
    /// The data service.
    /// </summary>
    public class DataService : IDataService
    {
        #region Declarations
        /// <summary>
        /// For random number generator.
        /// </summary>
        private readonly Random random;
        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="DataService"/> class.
        /// </summary>
        public DataService()
        {
            this.random = new Random();
        }
        #endregion

        /// <summary>
        /// The get runs in twenty overs.
        /// </summary>
        /// <returns>
        /// The <see cref="IEnumerable"/>.
        /// Return the collection of runs scored in 20 overs
        /// </returns>
        public IEnumerable<RunPerOverModel> GetRunsInTwentyOvers()
        {
          var runperoverList = new List<RunPerOverModel>();
            for (var i = 1; i <= 20; i++)
            {
                // min 0 and max 36 runs can be scored in per over
                runperoverList.Add(new RunPerOverModel(i, this.random.Next(0, 36)));     
            }

            return runperoverList;
        }

        /// <summary>
        /// The get average run per over.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public int GetAverageRunPerOver()
        {
            return (int)this.GetRunsInTwentyOvers().Average(x => x.Run);
        }
    }
}