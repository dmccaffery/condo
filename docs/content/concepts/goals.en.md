---
title: Understanding Condo Goals
menuTitle: Goals
---

> Condo's goals implements the condo [life-cycle][lifecycle], which is a series of targets that get executed sequentially.

## Default implementation

The default life-cycle targets that are implemented via goals include:

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

[lifecycle]: {{< relref "/concepts/lifecycle" >}}
