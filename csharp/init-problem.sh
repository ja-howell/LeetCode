#!/bin/bash

if [[ $# -ne "1" ]]; then
    echo "Usage: $0 <directory>"
    exit 1
fi

problem_name="$1"

dotnet new console --output "$problem_name"
cp templates/* "$problem_name"
mv "$problem_name/TEMPLATENAME.csproj" "$problem_name/$problem_name.csproj"
sed -i -e "s/TEMPLATENAME/$problem_name/" "$problem_name/$problem_name.csproj"
