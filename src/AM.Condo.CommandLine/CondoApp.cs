// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CondoApp.cs" company="automotiveMastermind and contributors">
//   © automotiveMastermind and contributors. Licensed under MIT. See LICENSE and CREDITS for details.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace AM.Condo.CommandLine
{
    using System;
    using System.Reflection;
    using Microsoft.Extensions.CommandLineUtils;

    /// <summary>
    /// Represents the command line tool for condo.
    /// </summary>
    public class CondoApp : CommandLineApplication
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CondoApp"/> class.
        /// </summary>
        public CondoApp()
        {
            // configure the application
            InitializeApp(this);
        }

        private static void InitializeApp(CommandLineApplication app)
        {
            // setup the name and full name
            app.Name = "condo";
            app.FullName = "Condo Build System";

            SetHelpOption(app);
            SetVerbosityOption(app);
        }

        private static void SetVersionOption(CommandLineApplication app)
        {
            // get the short version
            Func<string> shortVersion = () =>
            {
                var version = Assembly.GetAssembly(typeof(CondoApp)).GetName().Version;

                return $"{version.Major}.{version.Minor}.{version.Revision}";
            };

            // get the long version
            Func<string> longVersion = () => Assembly.GetAssembly(typeof(CondoApp))
                .GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                .InformationalVersion;

            // setup the option
            app.VersionOption("--version", shortVersion, longVersion);
        }

        private static void SetHelpOption(CommandLineApplication app)
        {
            app.HelpOption(Constants.HelpOption);
        }

        private static void SetVerbosityOption(CommandLineApplication app)
        {
            app.Option
            (
                Constants.VerbosityOption,
                "Display this amount of information in the event log. The available verbosity levels are: quiet, "
                    + "minimal, normal, detailed, and diagnostic",
                CommandOptionType.SingleValue
            );
        }
    }
}
