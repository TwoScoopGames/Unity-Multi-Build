#!/bin/bash

unity="/path/to/unity"

platform="$1"
project="${2%/}"
gamename="${project##*/}"
date=`date '+%Y-%m-%d-%H-%M-%S'`
filename="$gamename-$date"

"$unity" "$filename" -quit -batchmode -logFile /dev/stdout -projectPath "$project"  -executeMethod MultiBuild."$platform"
