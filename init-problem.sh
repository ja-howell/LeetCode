#!/bin/bash

if [[ $# -ne "1" ]]; then
    echo "Usage: $0 <directory>"
    exit 1
fi

newdir="$1"

dotnet new console --output "$newdir"
cp templates/* "$newdir"
mv "$newdir/TEMPLATENAME.csproj" "$newdir/$newdir.csproj"
sed -i -e "s/TEMPLATENAME/$newdir/" "$newdir/$newdir.csproj"
