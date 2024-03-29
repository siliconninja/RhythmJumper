# RhythmJumper

A rhythm-based game where you jump over obstacles in time to ~~3~~ 2... rhythmic... songs (still finding a third one).

It includes easter eggs & high score functionality.

This is my final project for a computer science class that teaches Visual Basic .NET.

I decided to play around with MonoDevelop in 2022 to revitalize the project by testing out Linux and C# support (through GTK), because why not?

[View all licensing information](LICENSE)

# Play the Game (How to Run)
Download from the Releases tab.

### Windows
First download `RhythmJumper.exe` in the Releases tab.

Then run it.

### Linux
The (alpha) Linux version must be run through Mono.

First download `RhythmJumperLinux.exe` in the Releases tab.

To install the dependencies, run:

* Fedora 35 (tested): `sudo dnf install mono-complete`
* Ubuntu 22.10 (Kinetic, untested): `sudo apt install mono-complete`

Run `mono RhythmJumperLinux.exe` in a terminal window.

## How to compile from source
### Windows
The Windows version is located in the `RhythmJumper` directory. It uses WinForms and Visual Studio .NET Framework 4.8.

#### Download and Install Dependencies

You will need to download and install Visual Studio 2022 Community edition from here: https://visualstudio.microsoft.com/

Scroll to the purple infinity sign, then click "Download Visual Studio" > "Community 2022".

Choose to install the .NET Developer Tools for version 4.8. Don't check or uncheck any other boxes.

To make it faster to install, allow the installer to install while downloading.

#### Opening and Compiling RhythmJumper

Once Visual Studio has installed, `git clone` this repository and open `RhythmJumper\RhythmJumper.sln` in a file browser.

Visual Studio will now open with the `RhythmJumper` project.

To compile the code, simply click the Play button at the top.

This will allow you to make modifications to the code and then play the game!

You can also debug your code by setting breakpoints inside of Visual Studio.
Because of this, what you're doing in Visual Studio is essentially called compiling in "Debug" mode.

#### Publishing a modified RhythmJumper

To publish a new version of RhythmJumper, you will want to build a release version. (This version has debugging information removed to make it more secure.)

To build a release version, go to the dropdown next to the Play button that says "Debug" and change it to "Release".

Finally, go to `Build > Rebuild All...` and then you should see the release EXE file was built in the following path:

`(wherever you cloned RhythmJumper)\RhythmJumper\RhythmJumper\bin\Release\RhythmJumper.exe`

You can then run that EXE file or share that EXE file with whoever you want.

#### Going back to debugging your code

Note that clicking the Play button on the Release target in Visual Studio is not optimal, as you cannot debug your code.

Go back by clicking the "Release" dropdown near the Play button, and click "Debug".

Then click the Play button to run/debug RhythmJumper in Visual Studio.

### Linux
The (alpha) Linux version is located in the `RhythmJumper-Linux` directory. 

Install the following packages:

Fedora 35: `sudo dnf install -y git monodevelop mono-complete mono-basic` (mono-basic may be optional, but it's what I had installed)

[Make sure you copy the **RhythmJumper-Linux** folder to the same project folder specified under Preferences in MonoDevelop.](https://stackoverflow.com/a/50050601) It uses the Gtk# 2.0 framework.

Then click the Play button on the top-left to run the game!

# Project info

### CURRENT VERSION:
Linux: v0.1 proof-of-concept/alpha (5/26/2022)

**Note: only the main menu screen (and a button -- try to figure it out 😉) works. Exit by clicking the X button on the top-right.**

Windows: v1.0.1 (minor fixes, 5/26/2022)

### TO COLLABORATE:
Pull requests are welcome on this repository.

--------------------

# FAQ

## What is this game?

This is a rhythm-based game where you jump over obstacles in time to 2... rhythmic... songs.

The idea of the game is based off of Geometry Dash.

### Why is it so simple?

It's a final project for a class.

I decided to do something in VB that I have not fully touched upon before (Graphics and painting.)

### Will there be more features?

In the coming days, possibly.

##### Planned for 1.0:
- [x] A few easter eggs within the game
- [x] Icons and UI tweaks
- [x] High score system (least # of attempts for 3 modes)
- Version 1.0 has been released.

##### Some feature ideas for 2.0:
- [ ] "Duck and jump" instead of just jump
- [ ] Auto-analyze music and jumps based on algorithm
- [ ] Multiple jumps at once on screen
- [ ] "Lives" for an extra hard mode
- [ ] Invisibility toggle for an EXTREME challenge.
- [ ] Remove music easter egg (easter egg #2)
- [ ] Fix bugs mentioned in code, and create Mono or similar build for (Mac?)/Linux (My.Computer.Audio.Stop() is the main issue, using Naudio library is a possible alternative)

### Game Soundtrack Selections/Songs Used

#### Easy Mode (edit: removed)

Formerly: Time Leap by Aero Chord

(custom license by NCS (youtube.com/user/NoCopyrightSounds/about), original upload: soundcloud.com/aerochordmusic/time-leap-original-mix-1)

https://www.youtube.com/watch?v=beDFafObkFw

#### Medium Mode

Final Battle by Waterflame

(non-commercial license, see http://www.waterflamemusic.com/using-my-tracks)

Credit to Waterflame: www.youtube.com/waterflame89

https://www.youtube.com/watch?v=yanwIwtlzEI

#### HARD Mode

Artha by Kurorak

Song license: CC-BY 3.0

Credit to Kurorak: Kurorak - Artha: https://youtu.be/5M61dsEQ1f0

The song is modified (trimmed length) when Easter Egg #3 is not activated. The song stops at 2m 26s.

https://www.youtube.com/watch?v=5M61dsEQ1f0
