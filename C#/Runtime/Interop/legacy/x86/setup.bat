@echo off

%~dp0quadeq -RegServer
regsvr32 /s %~dp0quadeqps.dll
regsvr32 /s %~dp0finance.dll
if "%PROCESSOR_ARCHITECTURE%" == "AMD64" goto wow64reg
regsvr32.exe /s %~dp0..\aircargo.wsc
goto done
:wow64reg
c:\Windows\SysWOW64\regsvr32.exe /s %~dp0..\aircargo.wsc
echo.
:done
