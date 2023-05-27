#!/bin/bash

ildasm /all /out=StardewValley.il "Stardew Valley.exe"
ilasm /dll /output=StardewValley.dll StardewValley.il

ildasm /all /out=StardewModdingAPI.il StardewModdingAPI.exe
ilasm /dll /output=StardewModdingAPI.dll StardewModdingAPI.il
