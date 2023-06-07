#!/bin/bash
proj_name="DMA"
proj_tests="${proj_name}.Tests"
mkdir "$proj_name"
cd "$proj_name"
dotnet new classlib
cd ..
mkdir "$proj_tests"
cd "$proj_tests"
dotnet new nunit
dotnet add reference ../"$proj_name"/"$proj_name".csproj
dotnet test