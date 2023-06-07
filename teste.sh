#!/bin/bash
proj_name="DMA"
proj_tests="${proj_name}.Tests"
cd "$proj_tests"
dotnet test
cd ..