// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InitCommand.cs" company="automotiveMastermind and contributors">
//   © automotiveMastermind and contributors. Licensed under MIT. See LICENSE and CREDITS for details.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace AM.Condo.CommandLine
{
    using System;

    using AM.Condo.Diagnostics;
    using Microsoft.Extensions.CommandLineUtils;

    public static class InitCommand
    {
        public static void Register(CommandLineApplication app, Func<ILogger> getLogger)
        {
            app.Command("initialize", initialize =>
            {
                initialize.HelpOption(Constants.HelpOption);

                initialize.OnExecute
            });
        }
    }
}
