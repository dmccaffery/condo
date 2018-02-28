// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="automotiveMastermind and contributors">
//   © automotiveMastermind and contributors. Licensed under MIT. See LICENSE and CREDITS for details.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace AM.Condo.CommandLine
{
    /// <summary>
    /// Represents the main entry point of the condo command line tool.
    /// </summary>
    public class Program
    {
        #region Methods
        /// <summary>
        /// Executes the condo command line tool with the specified <paramref name="args"/>.
        /// </summary>
        /// <param name="args">
        /// The arguments used to execute condo.
        /// </param>
        /// <returns>
        /// A value indicating whether or not the application executed successfully.
        /// </returns>
        public static int Main(string[] args) => new CondoApp().Execute(args);
        #endregion
    }
}
