# CHANGE LOG

> All notable changes to this project will be documented in this file.
# [2.0.0](git@github.com:dmccaffery/condo.git/compare/1.0.0...2.0.0) (2018-04-06)


### Bug Fixes

* **build:** remove legacy msbuild myget feed (#183) ([4d6f9a2](git@github.com:dmccaffery/condo.git/commits/4d6f9a2)), closes [#183](git@github.com:dmccaffery/condo.git/issues/183)
* **changelog:** resolve issue with tags (#32) ([774651c](git@github.com:dmccaffery/condo.git/commits/774651c)), closes [#32](git@github.com:dmccaffery/condo.git/issues/32)
* **cli:** capture exit after build (#154) ([3bf2d30](git@github.com:dmccaffery/condo.git/commits/3bf2d30)), closes [#154](git@github.com:dmccaffery/condo.git/issues/154)
* **detect-pr:** emit detection of pull requests (#68) ([e791845](git@github.com:dmccaffery/condo.git/commits/e791845)), closes [#68](git@github.com:dmccaffery/condo.git/issues/68)
* **docker:** resolve issue with required build quality (#139) ([9aa0a19](git@github.com:dmccaffery/condo.git/commits/9aa0a19)), closes [#139](git@github.com:dmccaffery/condo.git/issues/139) [#138](git@github.com:dmccaffery/condo.git/issues/138)
* **dotnet:** support projects where dotnet is not present (#24) ([bf55425](git@github.com:dmccaffery/condo.git/commits/bf55425)), closes [#24](git@github.com:dmccaffery/condo.git/issues/24)
* **dotnet:** pin the version of dotnet as dotnet-test is broken in preview3 (#28) ([1e64e33](git@github.com:dmccaffery/condo.git/commits/1e64e33)), closes [#28](git@github.com:dmccaffery/condo.git/issues/28)
* **dotnet:** save assembly info after prepare (#171) ([b3a3ff3](git@github.com:dmccaffery/condo.git/commits/b3a3ff3)), closes [#171](git@github.com:dmccaffery/condo.git/issues/171)
* **dotnet:** download and build on windows (#180) ([f93cdc3](git@github.com:dmccaffery/condo.git/commits/f93cdc3)), closes [#180](git@github.com:dmccaffery/condo.git/issues/180)
* **git:** checkout branch task was missing (#45) ([57462c7](git@github.com:dmccaffery/condo.git/commits/57462c7)), closes [#45](git@github.com:dmccaffery/condo.git/issues/45)
* **install:** fix install on windows (#46) ([98993f1](git@github.com:dmccaffery/condo.git/commits/98993f1)), closes [#46](git@github.com:dmccaffery/condo.git/issues/46)
* **nuget-push:** remove trailing slash on windows (#64) ([2692f5d](git@github.com:dmccaffery/condo.git/commits/2692f5d)), closes [#64](git@github.com:dmccaffery/condo.git/issues/64)
* **prepare:** set docker required properly (#167) ([238ab76](git@github.com:dmccaffery/condo.git/commits/238ab76)), closes [#167](git@github.com:dmccaffery/condo.git/issues/167)
* **project-json:** set prerelease tag when appropriate (#36) ([671843f](git@github.com:dmccaffery/condo.git/commits/671843f)), closes [#36](git@github.com:dmccaffery/condo.git/issues/36)
* **publish:** improve publish target detection (#69) ([42b1c9c](git@github.com:dmccaffery/condo.git/commits/42b1c9c)), closes [#69](git@github.com:dmccaffery/condo.git/issues/69) [#66](git@github.com:dmccaffery/condo.git/issues/66)
* **publish:** issue where publish was always true (#151) ([63d5074](git@github.com:dmccaffery/condo.git/commits/63d5074)), closes [#151](git@github.com:dmccaffery/condo.git/issues/151)
* **publish:** non-netstandard projects should publish (#152) ([9acad0d](git@github.com:dmccaffery/condo.git/commits/9acad0d)), closes [#152](git@github.com:dmccaffery/condo.git/issues/152)
* **release:** set author name/email (#40) ([df032a0](git@github.com:dmccaffery/condo.git/commits/df032a0)), closes [#40](git@github.com:dmccaffery/condo.git/issues/40)
* **release:** checkout branch due to detached head (#41) ([05b4c26](git@github.com:dmccaffery/condo.git/commits/05b4c26)), closes [#41](git@github.com:dmccaffery/condo.git/issues/41)
* **release:** resolve issue with release tags and changelog (#143) ([53694a7](git@github.com:dmccaffery/condo.git/commits/53694a7)), closes [#143](git@github.com:dmccaffery/condo.git/issues/143)
* **release:** do not push assets before tagging (#164) ([e40a095](git@github.com:dmccaffery/condo.git/commits/e40a095)), closes [#164](git@github.com:dmccaffery/condo.git/issues/164)
* **restore:** ignore failed sources on initial restore (#72) ([ff79b2f](git@github.com:dmccaffery/condo.git/commits/ff79b2f)), closes [#72](git@github.com:dmccaffery/condo.git/issues/72)
* **scripts:** remove unnecessary docker daemon parameter (#146) ([afaf452](git@github.com:dmccaffery/condo.git/commits/afaf452)), closes [#146](git@github.com:dmccaffery/condo.git/issues/146)
* **scripts:** skip install of dotnet v1 when host running ubuntu 16.10 or greater (#179) ([e9bb432](git@github.com:dmccaffery/condo.git/commits/e9bb432)), closes [#179](git@github.com:dmccaffery/condo.git/issues/179)
* **test:** add configuration to dotnet-test (#62) ([9c46c5f](git@github.com:dmccaffery/condo.git/commits/9c46c5f)), closes [#62](git@github.com:dmccaffery/condo.git/issues/62)
* **version:** issue with missing branch properties (#33) ([bdf2a74](git@github.com:dmccaffery/condo.git/commits/bdf2a74)), closes [#33](git@github.com:dmccaffery/condo.git/issues/33)
* **version:** fix recommended version for initial builds (#34) ([7820374](git@github.com:dmccaffery/condo.git/commits/7820374)), closes [#34](git@github.com:dmccaffery/condo.git/issues/34)
* **version:** include changelog in gitignore (#147) ([b10ec2c](git@github.com:dmccaffery/condo.git/commits/b10ec2c)), closes [#147](git@github.com:dmccaffery/condo.git/issues/147)
* **vs:** make condo work from vs on windows (#150) ([76613bf](git@github.com:dmccaffery/condo.git/commits/76613bf)), closes [#150](git@github.com:dmccaffery/condo.git/issues/150)
* **windows:** fix bootstrapping on windows (#60) ([b3ce495](git@github.com:dmccaffery/condo.git/commits/b3ce495)), closes [#60](git@github.com:dmccaffery/condo.git/issues/60) [#59](git@github.com:dmccaffery/condo.git/issues/59)
* **windows:** fix condo script on windows (#162) ([feccbdb](git@github.com:dmccaffery/condo.git/commits/feccbdb)), closes [#162](git@github.com:dmccaffery/condo.git/issues/162)
* bug in expand when downloading condo from src (#22) ([0a59505](git@github.com:dmccaffery/condo.git/commits/0a59505)), closes [#22](git@github.com:dmccaffery/condo.git/issues/22)
* resolve issue where build quality could be incorrect ([2341c71](git@github.com:dmccaffery/condo.git/commits/2341c71))
* do not force push tags (#27) ([b53fb7f](git@github.com:dmccaffery/condo.git/commits/b53fb7f)), closes [#27](git@github.com:dmccaffery/condo.git/issues/27)
* ensure master branch always uses next version (#63) ([0777c6b](git@github.com:dmccaffery/condo.git/commits/0777c6b)), closes [#63](git@github.com:dmccaffery/condo.git/issues/63)
* set execution bit of docker.sh (#161) ([73d9d7d](git@github.com:dmccaffery/condo.git/commits/73d9d7d)), closes [#161](git@github.com:dmccaffery/condo.git/issues/161)
* do not run bower/poly when unnecessary (#166) ([9d2109b](git@github.com:dmccaffery/condo.git/commits/9d2109b)), closes [#166](git@github.com:dmccaffery/condo.git/issues/166)
* print dotnet projects (#168) ([24da620](git@github.com:dmccaffery/condo.git/commits/24da620)), closes [#168](git@github.com:dmccaffery/condo.git/issues/168)
* dotnet detection (#169) ([6c20ee8](git@github.com:dmccaffery/condo.git/commits/6c20ee8)), closes [#169](git@github.com:dmccaffery/condo.git/issues/169)
* dotnet project print list (#170) ([b7f59b4](git@github.com:dmccaffery/condo.git/commits/b7f59b4)), closes [#170](git@github.com:dmccaffery/condo.git/issues/170)
* fix poject directory in polymer metadata (#172) ([2c0d43a](git@github.com:dmccaffery/condo.git/commits/2c0d43a)), closes [#172](git@github.com:dmccaffery/condo.git/issues/172)
* msbuildversion should be buildversion in csproj (#181) ([d5cecb3](git@github.com:dmccaffery/condo.git/commits/d5cecb3)), closes [#181](git@github.com:dmccaffery/condo.git/issues/181)


### Features

* **build:** add dind for circle-ci (#158) ([7c86947](git@github.com:dmccaffery/condo.git/commits/7c86947)), closes [#158](git@github.com:dmccaffery/condo.git/issues/158)
* **build:** publish dockerized condo (#160) ([f071df7](git@github.com:dmccaffery/condo.git/commits/f071df7)), closes [#160](git@github.com:dmccaffery/condo.git/issues/160)
* **clean:** allow skip clean (#178) ([71ce39b](git@github.com:dmccaffery/condo.git/commits/71ce39b)), closes [#178](git@github.com:dmccaffery/condo.git/issues/178)
* **cli:** builds can now be done through docker (#153) ([8782781](git@github.com:dmccaffery/condo.git/commits/8782781)), closes [#153](git@github.com:dmccaffery/condo.git/issues/153)
* **docfx:** add support for docfx (#65) ([ae95308](git@github.com:dmccaffery/condo.git/commits/ae95308)), closes [#65](git@github.com:dmccaffery/condo.git/issues/65)
* **docker:** add support for building docker containers (#115) ([ef38da4](git@github.com:dmccaffery/condo.git/commits/ef38da4)), closes [#115](git@github.com:dmccaffery/condo.git/issues/115) [#112](git@github.com:dmccaffery/condo.git/issues/112)
* **docker:** add docker push support (#130) ([bdc6fa6](git@github.com:dmccaffery/condo.git/commits/bdc6fa6)), closes [#130](git@github.com:dmccaffery/condo.git/issues/130)
* **docs:** add support for github pages (#71) ([2863792](git@github.com:dmccaffery/condo.git/commits/2863792)), closes [#71](git@github.com:dmccaffery/condo.git/issues/71) [#82](git@github.com:dmccaffery/condo.git/issues/82)
* **docs:** make docfx great again (#137) ([167373a](git@github.com:dmccaffery/condo.git/commits/167373a)), closes [#137](git@github.com:dmccaffery/condo.git/issues/137) [#136](git@github.com:dmccaffery/condo.git/issues/136)
* **dotnet:** add support for dotnet core 1.1 (#30) ([b74275c](git@github.com:dmccaffery/condo.git/commits/b74275c)), closes [#30](git@github.com:dmccaffery/condo.git/issues/30)
* **dotnet:** update dotnet to latest (#86) ([dce3e99](git@github.com:dmccaffery/condo.git/commits/dce3e99)), closes [#86](git@github.com:dmccaffery/condo.git/issues/86)
* **dotnet:** add support for legacy .net framework (#133) ([d0aea10](git@github.com:dmccaffery/condo.git/commits/d0aea10)), closes [#133](git@github.com:dmccaffery/condo.git/issues/133) [#132](git@github.com:dmccaffery/condo.git/issues/132)
* **dotnet:** use latest sdk for .NET (#135) ([ad4af64](git@github.com:dmccaffery/condo.git/commits/ad4af64)), closes [#135](git@github.com:dmccaffery/condo.git/issues/135) [#134](git@github.com:dmccaffery/condo.git/issues/134)
* **dotnet-cli:** replace dnx support with dotnet-cli using msbuild (#16) ([c97c190](git@github.com:dmccaffery/condo.git/commits/c97c190)), closes [#16](git@github.com:dmccaffery/condo.git/issues/16) [#12](git@github.com:dmccaffery/condo.git/issues/12) [#13](git@github.com:dmccaffery/condo.git/issues/13)
* **git:** add support for auth headers for clones (#145) ([77f18e9](git@github.com:dmccaffery/condo.git/commits/77f18e9)), closes [#145](git@github.com:dmccaffery/condo.git/issues/145)
* **git-tag:** add support for version tagging in git repo (#26) ([2c0abce](git@github.com:dmccaffery/condo.git/commits/2c0abce)), closes [#26](git@github.com:dmccaffery/condo.git/issues/26)
* **log:** add support for conventional changelog (#31) ([8f27d5a](git@github.com:dmccaffery/condo.git/commits/8f27d5a)), closes [#31](git@github.com:dmccaffery/condo.git/issues/31)
* **logging:** add msbuild logging everywhere (#38) ([3fa4633](git@github.com:dmccaffery/condo.git/commits/3fa4633)), closes [#38](git@github.com:dmccaffery/condo.git/issues/38)
* **metadata:** add support for skipping test projects in condo (#114) ([f56ccce](git@github.com:dmccaffery/condo.git/commits/f56ccce)), closes [#114](git@github.com:dmccaffery/condo.git/issues/114)
* **metadata:** support msbuild imports (#149) ([75a6271](git@github.com:dmccaffery/condo.git/commits/75a6271)), closes [#149](git@github.com:dmccaffery/condo.git/issues/149)
* **msbuild:** add support for msbuild project system (#44) ([86c588a](git@github.com:dmccaffery/condo.git/commits/86c588a)), closes [#44](git@github.com:dmccaffery/condo.git/issues/44)
* **msbuild:** add task to clone repo (#141) ([a2bbf39](git@github.com:dmccaffery/condo.git/commits/a2bbf39)), closes [#141](git@github.com:dmccaffery/condo.git/issues/141) [#140](git@github.com:dmccaffery/condo.git/issues/140)
* **node:** add node build/test support (#165) ([d830d25](git@github.com:dmccaffery/condo.git/commits/d830d25)), closes [#165](git@github.com:dmccaffery/condo.git/issues/165)
* **nuget:** add support for nuget push of vsts protected feeds (#18) ([75a7d41](git@github.com:dmccaffery/condo.git/commits/75a7d41)), closes [#18](git@github.com:dmccaffery/condo.git/issues/18)
* **package:** use dotnet nuget in place of custom task (#48) ([0e46525](git@github.com:dmccaffery/condo.git/commits/0e46525)), closes [#48](git@github.com:dmccaffery/condo.git/issues/48) [#50](git@github.com:dmccaffery/condo.git/issues/50) [dotnet/cli/#6123](git@github.com:dmccaffery/condo.git/issues/6123)
* **polymer:** add polymer install and build (#118) ([d8bcbe5](git@github.com:dmccaffery/condo.git/commits/d8bcbe5)), closes [#118](git@github.com:dmccaffery/condo.git/issues/118) [#105](git@github.com:dmccaffery/condo.git/issues/105)
* **project-json:** update semver in project.json (#35) ([d874638](git@github.com:dmccaffery/condo.git/commits/d874638)), closes [#35](git@github.com:dmccaffery/condo.git/issues/35)
* **publish:** do not push during pull request (#157) ([8b33681](git@github.com:dmccaffery/condo.git/commits/8b33681)), closes [#157](git@github.com:dmccaffery/condo.git/issues/157)
* **test:** add filtering by category (#70) ([3b75a8e](git@github.com:dmccaffery/condo.git/commits/3b75a8e)), closes [#70](git@github.com:dmccaffery/condo.git/issues/70)
* **versioning:** add envars for release versions (#111) ([04452c8](git@github.com:dmccaffery/condo.git/commits/04452c8)), closes [#111](git@github.com:dmccaffery/condo.git/issues/111)
* **windows:** add support for building on windows (#17) ([961090d](git@github.com:dmccaffery/condo.git/commits/961090d)), closes [#17](git@github.com:dmccaffery/condo.git/issues/17)
* update dotnet sdk versions (#163) ([9f30070](git@github.com:dmccaffery/condo.git/commits/9f30070)), closes [#163](git@github.com:dmccaffery/condo.git/issues/163)


### Performance Improvements

* **build:** improve build performance (#61) ([693dbb4](git@github.com:dmccaffery/condo.git/commits/693dbb4)), closes [#61](git@github.com:dmccaffery/condo.git/issues/61)
* **dotnet:** opt out of dotnet cli telemetry (#92) ([3822d5f](git@github.com:dmccaffery/condo.git/commits/3822d5f)), closes [#92](git@github.com:dmccaffery/condo.git/issues/92)
* **dotnet:** disable xml generation on nuget restore (#93) ([75e37b9](git@github.com:dmccaffery/condo.git/commits/75e37b9)), closes [#93](git@github.com:dmccaffery/condo.git/issues/93)
* **dotnet:** opt out of dotnet first run experience on build (#97) ([4ca1ca7](git@github.com:dmccaffery/condo.git/commits/4ca1ca7)), closes [#97](git@github.com:dmccaffery/condo.git/issues/97)


### BREAKING CHANGES

* **log:** 
Condo no longer uses the ```<SemanticVersion>``` tag found in `condo.build`. The version is now based on git tags.
* **log:** 
Any existing bootstrap scripts *MUST* be updated due to some changes in how condo itself is retrieved and built. Replace the bootstrap scripts you rely on (`condo.ps1`, `condo.cmd`, and `condo.ps1`) from [here](https://github.com/pulsebridge/condo/tree/develop/template).


# 1.0.0 (2016-07-08)


