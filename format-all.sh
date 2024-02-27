#!/bin/bash

dirs=$(find . -maxdepth 1 -type d)

for dir in $dirs; do
  (
    cd $dir
    dotnet format
  )
done