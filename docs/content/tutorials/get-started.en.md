---
title: Getting Started
---

> In order to utilize Condo, first follow these steps:

1. Get the necessary files:

    Copy the four files in the [`template`][template] folder and add them to the root folder of your project.

    ```condo.build
    condo.cmd
    condo.ps1
    condo.sh
    ```

    `condo.build` imports the targets to be executed.
    `condo.sh` and `condo.cmd` will set path variables and run the build and execute the condo shell with developer
    specified arguments. Depending on specified parameters (outlined and set in `condo.ps1`), condo will execute the
    target task.

    If the target is not specified, condo [goals] will execute the default implementation of the [lifecycle].

2. Edit the `condo.build` config file:

    Configure some stuff here. Learn more about condo's default targets outlined in the
    [goals] and [lifecycle docs][lifecycle].

3. Specify any condo flags:

    Condo supports customization via flags that can be specified upon running condo. Possible flags are specified as
    follows:

    Flag                  | Description                                                               | Target
    ----------------------|---------------------------------------------------------------------------|-----------------
    CONDO_DEBUG           |                                                                           | Clean
    CONDO_WAIT            |                                                                           | Clean
    SKIP_CLEAN            |                                                                           | Clean
    GIT_AUTHOR_NAME       |                                                                           | Initialize
    GIT_AUTHOR_EMAIL      |                                                                           | Initialize
    SET_VERSION_VARIABLES |                                                                           | Version
    CONDO_BUILD_QUALITY   |                                                                           | Version
    CONDO_CREATE_RELEASE  |                                                                           | Version
    DOTNET_PACK_PROPS     |                                                                           | Package

4. Run the build (without flags):
	OS X / Linux:

	```bash
	./condo.sh
	```

	Windows (CLI):

	```cmd
	condo
	```

	Windows (PoSH):
	```posh
	./condo.ps1
	```

    If you have specified flags, a sample command might look like:

    OS X / Linux:

	```bash
	./condo.sh
	```

## Versioning

Condo follows [semantic versioning].

Given a version number `MAJOR.MINOR.PATCH`, increment the:

1. MAJOR version when you make incompatible API changes,
2. MINOR version when you add functionality in a backwards-compatible manner, and
3. PATCH version when you make backwards-compatible bug fixes. Additional labels for pre-release and build metadata are
    available as extensions to the MAJOR.MINOR.PATCH format.

## Changelog Generation

From commit messages, condo will parse the < TYPE > of commit, and look for message bodies denoting breaking changes.
Condo looks for commits following these commit message conventions:

```
    <TYPE>(<SCOPE>): <SUBJECT> <blank line>
    <BODY> <blank line>
    < FOOTER >
```

To trigger an increment to your project's PATCH version, specify `fix` as the < TYPE > in your commit.
A sample commit intending to denote a bugfix to increment the PATCH version might read:
```
    fix(repo): add index on dealership id
```

To trigger an increment to your project's MINOR version, specify `feat` as the < TYPE > in your commit.
A sample commit intending to denote a backwards-compatible new feature to increment the MINOR version might read:
```
    feat(api): add route to retrieve some resource or other
```

To trigger an increment to your project's MAJOR version, specify `BREAKING CHANGE:` in the < FOOTER > of your commit.
Any < TYPE > can be specified as long as the commit's < FOOTER > includes `BREAKING CHANGE:` (with letters all
capitalized, ending with a colon and a space or two new lines). A sample commit intendending to denote a
non-backwards-compatible breaking change to increment the MAJOR version might read:
```
    feat(api): remove route to retrieve some resource or other

    BREAKING CHANGE: This route is in violation of some agreement or other. Services relying on this route should
    no longer use this route but instead do something else.
```

[template]: (../../template)
[lifecycle]: (../concepts/lifecycle.md)
[goals]: (../concepts/goals.md)
[semantic versioning]: https://semver.org/
