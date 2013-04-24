@ECHO OFF
 
REM The following directory is for .NET 2.0
REM set DOTNETFX2=%SystemRoot%\Microsoft.NET\Framework\v2.0.50727
set DOTNETFX2=%SystemRoot%\Microsoft.NET\Framework\v4.0.30319
set PATH=%PATH%;%DOTNETFX2%
 
echo Installing EventLogger Service...
echo ---------------------------------------------------
InstallUtil D:\04_Semester\Masterarbeit_Hawaii_Stuff\Praxis\C#Workspace\EventLogger\EventLogger\bin\Debug\EventLogger.exe
echo ---------------------------------------------------
echo Done.
REM pause