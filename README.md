# text-ed
a simple text editor for Windows made in Visual Studio/VBasic.NET framework. heavily in development so you can only open files and open a new file, copypastas etc.
I made it following various tutorials on the web so I just wanted to share it here to record my work.
if you just want to use something that is not the default Notepad editor or anything else, you can try it. Or not lel

my first attempt to make a GUI app, am not a pro(crastinator) coder so if you can, you can contribute to it. thanks a bunch lmao

## Building procedure
install VS2022 with .NET C# plugin smth smth idk, and open the text-ed.sln file, find the run button and it will automatically compile. Build artifacts are in ```text-ed/obj/Debug/``` maybe ig.

### nah why do i need to compile stuff am lazy pls provide an exe aaaaa
stay calm bro, find the exe in ```text-ed/obj/Debug``` and download it. 


P/S: GitHub says every file they could detect was 100% written in C#, I'm new to this and also for fun so I didn't really know it was. Maybe a typical Windows app can be written in C# tho.
Also it requires .NET to run (minimum 2.0) so please install if didn't or run it in a stable Windows installation. WinPE does not have .NET by default so idk

edit: Microsoft Windows PE builder or some other such tools may probably have an option for adding .NET redist installation inside your PE distro. If you want to include text-ed for use in your WPE, it is encouraged to add at least .NET 2.0 rt so it might work. I will have a test for it later.
