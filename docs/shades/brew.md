---
layout: docs
title: brew
group: shades
---

Executes the brew package manager on OS X.

## Contents

* Will be replaced with the table of contents
{:toc}

## Supported Operating Systems

{% icon fa-apple fa-3x %}

## Arguments

The following arguments are available within brew.

<div class="table-responsive">
    <table class="table table-bordered table-striped">
    <thead>
        <tr>
            <th style="width:100px;">Name</th>
            <th style="width:50px;">Type</th>
            <th style="width:50px;">Default</th>
            <th style="width:25px;">Required</th>
            <th>Description</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>brew_args</td>
            <td>string</td>
            <td><code>null</code></td>
            <td><strong>Yes</strong></td>
            <td>The arguments used to execute brew.</td>
        </tr>
        <tr>
            <td>brew_options</td>
            <td>string</td>
            <td><code>${env:BREW_OPTIONS}</code></td>
            <td>No</td>
            <td>Additional options to use when executing brew.</td>
        </tr>
        <tr>
            <td>brew_path</td>
            <td>string</td>
            <td><code>${global:working_path}</code></td>
            <td>No</td>
            <td>The path in which to execute brew.</td>
        </tr>
        <tr>
            <td>brew_wait</td>
            <td>boolean</td>
            <td><code>true</code></td>
            <td>No</td>
            <td>A value indicating whether or not to wait for exit.</td>
        </tr>
        <tr>
            <td>brew_quiet</td>
            <td>boolean</td>
            <td><code>${global:quiet}</code></td>
            <td>No</td>
            <td>A value indicating whether or not to avoid printing output.</td>
        </tr>
    </tbody>
    </table>
</div>

## Global Arguments

The following global arguments are used by brew:

<div class="table-responsive">
    <table class="table table-bordered table-striped">
    <thead>
        <tr>
            <th style="width:100px;">Name</th>
            <th style="width:50px;">Type</th>
            <th style="width:50px;">Default</th>
            <th>Description</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>base_path</td>
            <td>string</td>
            <td><code>$PWD</code></td>
            <td>The base path in which condo was executed.</td>
        </tr>
        <tr>
            <td>working_path</td>
            <td>string</td>
            <td><code>${global:base_path}</code></td>
            <td>The working path in which condo should execute shell commands.</td>
        </tr>
    </tbody>
    </table>
</div>

## Examples

## See Also