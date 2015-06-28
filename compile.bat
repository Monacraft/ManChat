@echo off
cls
prompt $$\
set path=%path%;C:\Windows\Microsoft.NET\Framework\v4.0.30319
set m=C:\Windows\Microsoft.NET\Framework\v4.0.30319\msbuild.exe
if not exist "App\ICON.ico" Echo Warning: "App\ICON.ico" does not exist. The program will not compile
Echo.
cmd
