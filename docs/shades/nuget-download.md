---
layout: docs
title: nuget-download
group: shades
---

@{/*

nuget-download
    Downloads nuget if it is not already installed either locally or globally.

nuget_download_path='$(base_path)/.nuget'
    The path in which to install nuget.

nuget_version='3.2.0'
    The minimum version of nuget that must be installed.

base_path='$(CurrentDirectory)'
    The base path in which to install nuget.

*/}

use namespace = 'System'
use namespace = 'System.IO'
use namespace = 'System.Net'

use import = 'Condo.Build'

default base_path               = '${ Directory.GetCurrentDirectory() }'

default nuget_download_path     = '${ Path.Combine(base_path, ".nuget") }'
default nuget_version           = '3.2.0'

@{
    Build.Log.Header("nuget-download");

    var nuget_exe       = "nuget.exe";
    var nuget_dist      = "https://dist.nuget.org/win-x86-commandline/latest/";
    var nuget_url       = nuget_dist + "/" + nuget_exe;
    var nuget_download  = Path.Combine(nuget_download_path, nuget_exe);

    Build.Log.Argument("path", nuget_download);
    Build.Log.Argument("version (minimum)", nuget_version);

    Version minimum;

    if (!Version.TryParse(nuget_version, out minimum))
    {
        throw new ArgumentException("nuget-download: the specified minimum version is missing or invalid.", nuget_version);
    }

    if (File.Exists(nuget_download))
    {
        var nuget_download_version = FileVersionInfo.GetVersionInfo(nuget_download);

        Version nuget_download_current;

        if (nuget_download_version == null || nuget_download_version.ProductVersion == null || !Version.TryParse(nuget_download_version.ProductVersion, out nuget_download_current))
        {
            nuget_download_current = new Version(0, 0);
        }

        if (nuget_download_current < minimum)
        {
            File.Delete(nuget_download);
        }
    }

    if (!File.Exists(nuget_download))
    {
        Build.MakeDirectory(Path.GetDirectoryName(nuget_download));

        Log.Verbose("nuget-download: downloading the latest version of nuget.exe");

        var client = new WebClient();

        client.DownloadFile(nuget_url, nuget_download);
    }

    nuget_version = FileVersionInfo.GetVersionInfo(nuget_download).ProductVersion.ToString();

    Build.Log.Argument("version (actual)", nuget_version);
    Build.Log.Header();
}