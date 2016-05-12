# <img src="https://raw.githubusercontent.com/ramonmeza/AssettoCorsaModManager/master/AssettoCorsaModManager/Resources/ACMM.png" align="center" alt="Assetto Corsa Simple Mod Manager"> Assetto Corsa Simple Mod Manager

## Overview

Assetto Corsa Simple Mod manager is just that; a simple mod manager for Assetto Corsa. It makes installing mods for Assetto Corsa painless and helps keep your Assetto Corsa main directory clean.

![alt text](https://raw.githubusercontent.com/ramonmeza/AssettoCorsaModManager/master/AssettoCorsaModManager/Resources/ScreenCap.PNG "Assetto Corsa Mod Manager")

## Features

* Simple directory stucture to add your mods to
* Tabs for car mods and track mods

## How to Use

[![Video Tutorial](http://img.youtube.com/vi/_ReXox6It080.jpg)](http://www.youtube.com/watch?v=_ReXox6It08)

*I highly suggest watching the video tutorial. It's just easier, in my opinion.*

You can download the zip file containing the program by [clicking here](https://dl.dropboxusercontent.com/u/107623293/ACMM.zip) or you can build it yourself using Visual Studio. 

1. Extract the contents of the zip file wherever you want. I prefer onto my desktop.
2. Inside of the folder you extracted there is an executable and a Mods folder. Place any car mods or track mods into their respective folder inside the Mods folder.
3. Go back to the top level of the Assetto Corsa Mod Manager folder, there should be an executable named "AssettoCorsaModManager". Run that executable.
4. When the program opens, press the "Choose" button. This will open a dialog box where you will choose the folder where your AssettoCorsa.exe file is. *This is usually C:\Program Files (x86)\Steam\steamapps\common\assettocorsa*.
5. Now check off the mods you want to enable by clicking on their checkbox inside of the **Disabled** section. Do this for both cars and tracks.
6. Once you've selected the mods you want to have enabled, press the **Enable Selected** button on the bottom. This will activate the mods you selected.
7. To disable mods, simple check of the mods you want to disable from the **Enabled** section and press the **Disabled Selected** button.

**Note**: Don't delete the settings.sav file. For the love of everything, just don't do it.

## Known Problems

* Saving happens when the program exits. This means if you force the program to terminate, using End Task, the settings wont save. If you enabled a mod and then force exit the program, there's no way of it knowing that mod ever existed. To fix this manually, just go into your Assetto Corsa folder and remove the mod manually.
* Sometimes the Choose button won't open. No idea why, but restarting the program helps, or you can manually change the directory in the setting.sav file.

Please understand, this really is just a glorified file moving program. It literally works by taking the folders you put in the Mods folder and moving them to your Assetto Corsa folder. I made this program to abstract the work away from users, as well as make it easy to fix any problems you might have with modding Assetto Corsa. Please [open an issue](https://github.com/ramonmeza/AssettoCorsaModManager/issues/new) if you have any problems or recognize how I can make this better.

## Contributing

Found a bug or have a feature suggestion? Please [open an issue](https://github.com/ramonmeza/AssettoCorsaModManager/issues/new) to tell me about it!

### License

Assetto Corsa Mod Manager code and documentation are licensed under [The MIT License](https://opensource.org/licenses/MIT).