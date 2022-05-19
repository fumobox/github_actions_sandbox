@echo off
set UNITY="C:\Program Files\Unity\Hub\Editor\2021.3.2f1\Editor\Unity.exe"
%UNITY% -batchmode -quit -logFile .\Build\android\build.log -projectPath .\ -executeMethod Sandbox.SandboxEditor.BuildAndroid
pause