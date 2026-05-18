#!/usr/bin/env bash
set -e

if ! command -v dotnet >/dev/null 2>&1; then
  echo "Error: dotnet is not installed or not in PATH. Install the .NET SDK and try again." >&2
  exit 1
fi

mkdir -p 0-new_project
cd 0-new_project
dotnet new console