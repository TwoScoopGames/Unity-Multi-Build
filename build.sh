#!/bin/bash

unity="/path/to/unity"

project="$2"
platform="$1"
gamename="${project##*/}"
date=`date '+%Y-%m-%d-%H-%M-%S'`
filename="$gamename-$date"

"$unity" "$filename" -quit -batchmode -logFile /dev/stdout -projectPath "$project"  -executeMethod MultiBuild."$platform"
