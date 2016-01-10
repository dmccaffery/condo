---
layout: docs
title: tsd-download
group: shades
---

@{/*

tsd-download
    Downloads and installs tsd if it is not already installed.

tsd_download_path='$(base_path)'
    The path in which to download tsd.

base_path='$(CurrentDirectory)'
    The base path in which to download tsd.

*/}

use import = 'Condo.Build'

default base_path           = '${ Directory.GetCurrentDirectory() }'

default tsd_download_path   = '${ base_path }'

@{
    Build.Log.Header("tsd-download");

    var tsd_install             = Path.Combine(tsd_download_path, "node_modules", "tsd", "build", "cli.js");

    var tsd_locally_installed   = File.Exists(tsd_install);
    var tsd_version             = string.Empty;
    var tsd_globally_installed  = !tsd_locally_installed && Build.TryExecute("tsd", out tsd_version, "--version --config.interactive=false");
    var tsd_installed           = tsd_locally_installed || tsd_globally_installed;

    tsd_install = tsd_globally_installed ? "tsd" : tsd_install;

    Build.Log.Argument("path", tsd_install);

    if (tsd_globally_installed)
    {
        Build.Log.Argument("version", tsd_version);
    }

    Build.Log.Header();
}

npm-install npm_install_id='tsd' npm_install_prefix='${ tsd_download_path }' if='!tsd_installed'

- Build.SetPath("tsd", tsd_install, tsd_globally_installed);