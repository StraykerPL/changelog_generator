# ChangeLog Generator

Simple C# app to create changelog files dynamically. To create file, user have to fill in appropriate text boxes and choose directory to save file.

![main.PNG](https://github.com/StraykerPL/changelog_generator/blob/master/images/main.PNG)

![edit.PNG](https://github.com/StraykerPL/changelog_generator/blob/master/images/edit.PNG)

![infowindow.PNG](https://github.com/StraykerPL/changelog_generator/blob/master/images/infowindow.PNG)

# Building

To build app, you have to open it with MS Visual Studio, load solution to editor and start build with CTRL + F5. In repo's "bin" folder in build-related folder, will be EXE file. Project was written on .NET Framework v4.7.2, so you will need it to build app properly. You can use MonoDevelop or something similar to build app, but I didn't test it. Feel free to make research!

# TODO

- [x] class for managing larger data,

- [ ] support for dynamic data input,

# Using

- Download .exe file from repository at "bin/Release" directory. Check if you have installed .NET Framework 4.7.2 on your computer. If yes, run the app!
- If you want to add app to another program, feel free to change project build setting from Windows Forms App to Windows Class Library, and try building it. Just remember, that I don't prepared project to this operation, so you will have to recode some functions or copy main class file to your app,
- (TODO in near future!) App can accept args from calling process, for example Strayex Shell, and generate changelog without accessing GUI,

For additional info, look into [USING.md](USING.md)!

# Contributions

I'm waiting for some cool ideas and bug reports for this repository. Feel free to join me in development! :D
If you have any suggestions for Strayex or you want to ask me for something, join to [Strayex Discord Server!](https://discord.gg/ytdkCVD)

# Licensing

This app is distributed under MIT/X11 license, but some files are generated by MS Visual Studio.
Please look at https://visualstudio.microsoft.com for licensing terms for that files.
