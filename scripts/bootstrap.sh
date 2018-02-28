#!/usr/bin/env bash

function condo-init()
{
    local CONDO_PATH="$HOME/.am/condo"
}

function condo-bootstrap()
{
    # condo branch
    local CONDO_VERSION="develop"
    local CONDO_RESET=0

    # continue testing for arguments
    while [[ $# > 0 ]]; do
        case $1 in
            -v|--version)
                shift
                CONDO_VERSION=$1
                ;;
            -r|--reset)
                CONDO_RESET=1
                ;;
            --)
                shift
                break
                ;;
            *)
                break
                ;;
        esac
        shift
    done

    local CURL_OPT='-s'
    if [ ! -z "${GH_TOKEN:-}" ]; then
        CURL_OPT='$CURL_OPT -H "Authorization: token $GH_TOKEN"'
    fi

    local CONDO_PATH="$HOME/.am/condo"
    local SHA_URI="https://api.github.com/repos/automotivemastermind/condo/commits/$CONDO_VERSION"
    local CONDO_SHA=$(curl $CURL_OPT $SHA_URI | grep sha | head -n 1 | sed 's#.*\:.*"\(.*\).*",#\1#')
    local SHA_PATH="$CONDO_PATH/$CONDO_SHA"

    if [ -f $SHA_PATH ]; then
        echo "condo: latest version already installed: $CONDO_SHA"

        if [ "${CONDO_RESET}" = "0" ]; then
            exit 0
        fi
    fi

    if [ -d "$CONDO_PATH" ]; then
        echo "condo: removing existing condo path: $CONDO_PATH"
        rm -rf $CONDO_PATH 1>/dev/null
    fi

    local INSTALL_URI="https://github.com/automotivemastermind/condo/tarball/$CONDO_VERSION"
    local INSTALL_TEMP=$(mktemp -d -t am_condo)
    local CONDO_EXTRACT="$CONDO_TEMP/extract"
    local CONDO_SOURCE="$CONDO_EXTRACT"

    pushd $INSTALL_TEMP 1>/dev/null
    curl -skL $INSTALL_URI | tar zx --strip-components 1
    ./scripts/install.sh --source .
    popd 1>/dev/null

    rm -rf $INSTALL_TEMP 1>/dev/null
}

condo-bootstrap $@
