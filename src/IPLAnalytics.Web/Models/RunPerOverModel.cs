// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RunPerOverModel.cs" company="">
//   
// </copyright>
// <summary>
//   The run per over model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace IPLAnalytics.Web.Models
{
    /// <summary>
    /// The run per over model.
    /// </summary>
    public class RunPerOverModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RunPerOverModel"/> class.
        /// </summary>
        /// <param name="over">
        /// The over.
        /// </param>
        /// <param name="run">
        /// The run.
        /// </param>
        public RunPerOverModel(int over, int run)
        {
            this.Over = over;
            this.Run = run;
        }

        /// <summary>
        /// Gets or sets the over.
        /// </summary>
        public int Over { get; set; }

        /// <summary>
        /// Gets or sets the run.
        /// </summary>
        public int Run { get; set; }
    }
}                                                       