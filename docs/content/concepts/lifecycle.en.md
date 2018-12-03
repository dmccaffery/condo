---
title: Understanding the Life-cycle
menuTitle: Life-cycle
---

> Condo's life-cycle is comprised of a series of targets that get executed sequentially, given success of the previous
target. When the first target is called, the dependencies are checked. The life-cycle is not implemented by default,
but rather implemented by Condo's [goals][goals].

## Default targets

The default targets of the condo life-cycle include:

1. Clean
2. Bootstrap
3. Initialize
4. Version
5. Prepare
6. Compile
7. Test
8. Package
9. Verify
10. Document
11. Publish

Target       | Description                                                               | Depends on
-------------|---------------------------------------------------------------------------|----------------------------
Clean        | Default target for clean (removes artifacts and intermediate artifacts)   | N/A
Bootstrap    | Developer bootstrapping                                                   | N/A
Initialize   | Initializes dynamic properties                                            | Clean
Version      | Semantic versioning                                                       | Initialize
Prepare      | Prepare for compilation: usually for executing restore operations <br>or executing target runners | Version
Compile      | Compile the project                                                       | Prepare
Test         | Execute tests for the project                                             | Compile
Package      | Perform post test packaging of the project                                | Test
Verify       | Verify build output and test results                                      | Package
Document     | Generate documentation from build output                                  | Version
Publish      | Publish final build artifacts                                             | Verify, Document

## Build lifecycle

When you call `condo` on your condo project, you will run the configurable `condo.build` file. If you are
running the default build, as specified in `lifecycle.targets`, the first target that gets called is the `Build`
target, which in turn depends on the `Package` target.

An execution stack of sorts is created, and can be represented as such:

|Stack Position | Target            | Dependency Target |
|:-------------:|-------------------|-------------------|
|1              |Build              | Package           |

The `Package` target's dependencies are checked next. `Package` depends on `Test`, and that dependency is
consequently pushed onto the stack.

The stack can be represented as such:

|Stack Position | Target            | Dependency Target |
|:-------------:|-------------------|-------------------|
|2              |Package            | Test              |
|1              |Build              | Package           |

`Test` in turn depends on `Compile`, which depends on `Prepare`, which depends on `Version`, which
depends on `Initialize`, which depends on `Clean`.

The resulting stack can be represented as such:

|Stack Position | Target            | Dependency Target |
|:-------------:|-------------------|-------------------|
|8              |Clean              | N/A               |
|7              |Initialize         | Clean             |
|6              |Version            | Initialize        |
|5              |Prepare            | Version           |
|4              |Compile            | Prepare           |
|3              |Test               | Compile           |
|2              |Package            | Test              |
|1              |Build              | Package           |

Given LIFO, the stack unravels as each target is completed successfully. `Clean` is called, followed by
`Initialize`, followed by `Version`, followed by `Prepare`, followed by `Compile`, followed by
`Test`, followed by `Package`, followed by `Build`.

## Publish lifecycle
The `Publish` lifecycle closely follows the `Build` lifecycle. `Publish` first depends on `Verify` and
`Document`. `Verify` depends on `Package`, and `Document` depends on `Version`.

The resulting stack can be represented as such:

|Stack Position | Target            | Dependency Target |
|:-------------:|-------------------|-------------------|
|10             |Clean              | N/A               |
|9              |Initialize         | Clean             |
|8              |Version            | Initialize        |
|7              |Prepare            | Version           |
|6              |Compile            | Prepare           |
|5              |Test               | Compile           |
|4              |Package            | Test              |
|3              |Verify             | Package           |
|2              |Document           | Version           |
|1              |Publish            | Verify, Document  |

The publish lifecycle stack unravels in kind. `Clean` is called, followed by `Initialize`, followed by
`Version`, followed by `Prepare`, followed by `Compile`, followed by `Test`, followed by `Package`,
followed by `Verify`. All of the dependencies of `Document` have also been resolved, so `Document` is also
successfully completed. `Publish` is executed last to complete the publish lifecycle.

[goals]: {{< relref "/concepts/goals" >}}
