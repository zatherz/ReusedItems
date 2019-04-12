#!/usr/bin/bash

rm -rf mod
mkdir mod
cp mod.yml mod
cp -r resources mod

if [ "$1" = "release" ]; then
  echo release build
  cp bin/Release/ReusedItems.dll mod
else
  echo debug build
  cp bin/Debug/ReusedItems.dll mod
fi
