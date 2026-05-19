#!/usr/bin/env bash
set -euo pipefail

if ! command -v dotnet >/dev/null 2>&1; then
  echo "Error: dotnet is not installed or not in PATH." >&2
  exit 1
fi

rm -rf 1-new_project
dotnet new console -o 1-new_project
dotnet build 1-new_project/