---
layout: docs
title: info-collect
group: shades
---

@{/*

info-collect
    Collects assembly information used to update assembly info files prior to compilation.

base_path='$(CurrentDirectory)'
    The base path in which to locate assembly information (such as from git).

working_path='$(base_path)'
    The working path in which to locate assembly information (such as from git).

*/}

use namespace = 'System'

use import = 'Condo.AssemblyInfo'
use import = 'Condo.Build'

default base_path               = '${ Directory.GetCurrentDirectory() }'
default working_path            = '${ base_path }'

default version                 = ''
default product                 = ''
default company                 = ''
default copyright               = ''
default license                 = ''
default licenseUri              = ''

@{
    Build.Log.Header("info-collect");

    if (!string.IsNullOrEmpty(Build.Get("SYSTEM_TEAMFOUNDATIONCOLLECTIONURI")))
    {
        AssemblyInfo.AssemblyVersion    = Build.Get("BUILD_VERSION");
        AssemblyInfo.Branch             = Build.Get("BUILD_SOURCEBRANCH");
        AssemblyInfo.CommitId           = Build.Get("BUILD_SOURCEVERSION");
        AssemblyInfo.BuildId            = Build.Get("BUILD_BUILDID");

        if (AssemblyInfo.Branch.StartsWith("refs/pull/"))
        {
            var segments = AssemblyInfo.Branch.Split("/"[0]);

            AssemblyInfo.PullRequestId = segments[2];
        }

        AssemblyInfo.BuiltBy            = Build.Get("BUILD_REQUESTEDFOR");
        AssemblyInfo.BuiltOn            = Build.Get("AGENT_NAME");

        AssemblyInfo.RepositoryProvider = Build.Get("BUILD_REPOSITORY_PROVIDER");
        AssemblyInfo.TeamUri            = Build.Get("SYSTEM_TEAMFOUNDATIONCOLLECTIONURI");
        AssemblyInfo.RepositoryUri      = Build.Get("BUILD_REPOSITORY_URI");
        AssemblyInfo.BuildUri           = Build.Get("BUILD_BUILDURI");
    }

    else if (!string.IsNullOrEmpty(Build.Get("APPVEYOR")))
    {
        AssemblyInfo.Branch             = Build.Get("APPVEYOR_REPO_BRANCH");
        AssemblyInfo.CommitId           = Build.Get("APPVEYOR_REPO_COMMIT");
        AssemblyInfo.BuildId            = Build.Get("APPVEYOR_BUILD_NUMBER");
        AssemblyInfo.PullRequestId      = Build.Get("APPVEYOR_PULL_REQUEST_NUMBER");

        AssemblyInfo.BuiltBy            = Build.Get("APPVEYOR_REPO_COMMIT_AUTHOR");
        AssemblyInfo.BuiltOn            = "AppVeyor";

        AssemblyInfo.RepositoryProvider = Build.Get("APPVEYOR_REPO_PROVIDER");
        AssemblyInfo.TeamUri            = Build.Get("APPVEYOR_REPO_NAME");
        AssemblyInfo.RepositoryUri      = Build.Get("APPVEYOR_REPO_NAME");
        AssemblyInfo.BuildUri           = "https://ci.appveyor.com/project/" + Build.Get("APPVEYOR_ACCOUNT_NAME") + "/" + Build.Get("APPVEYOR_PROJECT_SLUG");

        if (AssemblyInfo.RepositoryProvider.Equals("GitHub", StringComparison.OrdinalIgnoreCase))
        {
            AssemblyInfo.RepositoryUri = "https://github.com/" + AssemblyInfo.RepositoryUri;
            AssemblyInfo.TeamUri = AssemblyInfo.RepositoryUri;
        }
    }

    else if (!string.IsNullOrEmpty(Build.Get("TRAVIS")))
    {
        AssemblyInfo.Branch             = Build.Get("TRAVIS_BRANCH");
        AssemblyInfo.CommitId           = Build.Get("TRAVIS_COMMIT");
        AssemblyInfo.BuildId            = Build.Get("TRAVIS_BUILD_NUMBER");
        AssemblyInfo.PullRequestId      = Build.Get("TRAVIS_PULL_REQUEST");

        if (AssemblyInfo.PullRequestId.Contains("false"))
        {
            AssemblyInfo.PullRequestId = string.Empty;
        }

        AssemblyInfo.BuiltBy            = Build.Get("USER");
        AssemblyInfo.BuiltOn            = "Travis-CI";

        AssemblyInfo.RepositoryProvider = "GitHub";
        AssemblyInfo.TeamUri            = "https://github.com/" + Build.Get("TRAVIS_REPO_SLUG");
        AssemblyInfo.RepositoryUri      = "https://github.com/" + Build.Get("TRAVIS_REPO_SLUG");
        AssemblyInfo.BuildUri           = "https://travis-ci.org/" + Build.Get("TRAVIS_REPO_SLUG");
    }

    AssemblyInfo.Product          = product;
    AssemblyInfo.Company          = company;
    AssemblyInfo.Copyright        = copyright;
    AssemblyInfo.License          = license;
    AssemblyInfo.LicenseUri       = licenseUri;

    AssemblyInfo.LoadGitMetadata(working_path);

    var commit = AssemblyInfo.DateTimeUtc.ToString("HHmm");
    var build = AssemblyInfo.DateTimeUtc.ToString("yyddMM");

    if (string.IsNullOrEmpty(AssemblyInfo.AssemblyVersion))
    {
        AssemblyInfo.AssemblyVersion = string.IsNullOrEmpty(version) ? "1.0.0" : version;
    }

    if (string.IsNullOrEmpty(AssemblyInfo.CommitId))
    {
        AssemblyInfo.CommitId = commit;
    }

    if (string.IsNullOrEmpty(AssemblyInfo.BuildId))
    {
        AssemblyInfo.BuildId = build;
    }

    AssemblyInfo.FileVersion = string.Format("{0}.{1}.{2}.{3}", AssemblyInfo.Version.Major, AssemblyInfo.Version.Minor, AssemblyInfo.BuildId, commit);

    if (string.IsNullOrEmpty(AssemblyInfo.Branch))
    {
        AssemblyInfo.Branch = "<unknown>";
    }

    if (string.IsNullOrEmpty(AssemblyInfo.InformationalVersion))
    {
        AssemblyInfo.InformationalVersion = AssemblyInfo.AssemblyVersion;
    }

    if (string.IsNullOrEmpty(AssemblyInfo.PrereleaseTag))
    {
        var prerelease = "alpha";

        if (AssemblyInfo.Branch.Contains(@"/dev"))
        {
            prerelease = "beta";
        }
        else if (AssemblyInfo.Branch.Contains(@"/release"))
        {
            prerelease = "rc";
        }
        else if (AssemblyInfo.Branch.Contains(@"/master"))
        {
            prerelease = null;
        }

        AssemblyInfo.PrereleaseTag = prerelease;
    }

    if (!string.IsNullOrEmpty(AssemblyInfo.PrereleaseTag))
    {
        AssemblyInfo.PrereleaseTag += "-" + AssemblyInfo.BuildId.PadLeft(5, "0"[0]);
    }

    if (string.IsNullOrEmpty(Build.Get("BUILD_BUILDNUMBER")) && string.IsNullOrEmpty(Build.Get("BUILD_SERVER")))
    {
        AssemblyInfo.PrereleaseTag += "-" + commit.PadLeft(4, "0"[0]);
    }

    if (string.IsNullOrEmpty(AssemblyInfo.BuiltOn))
    {
        AssemblyInfo.BuiltOn = Environment.MachineName;
    }

    if (string.IsNullOrEmpty(AssemblyInfo.BuiltBy))
    {
        string user;

        if (Build.TryExecute("git", out user, "config user.email"))
        {
            AssemblyInfo.BuiltBy = user;
        }
        else if (Build.TryExecute("git", out user, "config user.name"))
        {
            AssemblyInfo.BuiltBy = user;
        }
        else
        {
            AssemblyInfo.BuiltBy = Environment.UserName;
        }
    }

    Build.Set("BUILD_BUILDNUMBER", AssemblyInfo.InformationalVersion);

    Build.Log.Argument("product", AssemblyInfo.Product);
    Build.Log.Argument("company", AssemblyInfo.Company);
    Build.Log.Argument("copyright", AssemblyInfo.Copyright);
    Build.Log.Argument("version", AssemblyInfo.AssemblyVersion);
    Build.Log.Argument("file version", AssemblyInfo.FileVersion);
    Build.Log.Argument("prerelease tag", AssemblyInfo.PrereleaseTag);
    Build.Log.Argument("semantic version", AssemblyInfo.InformationalVersion);
    Build.Log.Argument("build id", AssemblyInfo.BuildId);
    Build.Log.Argument("commit id", AssemblyInfo.CommitId);
    Build.Log.Argument("pull request id", AssemblyInfo.PullRequestId);
    Build.Log.Argument("branch", AssemblyInfo.Branch);
    Build.Log.Argument("repository uri", AssemblyInfo.RepositoryUri);
    Build.Log.Argument("team uri", AssemblyInfo.TeamUri);
    Build.Log.Argument("build uri", AssemblyInfo.BuildUri);
    Build.Log.Argument("built by", AssemblyInfo.BuiltBy);
    Build.Log.Argument("built on", AssemblyInfo.BuiltOn);
    Build.Log.Argument("build date (utc)", AssemblyInfo.BuildDateUtc);
    Build.Log.Argument("license", AssemblyInfo.License);
    Build.Log.Argument("license uri", AssemblyInfo.LicenseUri);
    Build.Log.Header();
}