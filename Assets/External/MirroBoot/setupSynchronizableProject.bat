: help
:  - http://orangeclover.hatenablog.com/entry/20101004/1286120668

@echo off
: Please start directly under Unity project route.
set SCRIPT_DIR=%~dp0
set PROJECT_ROOT=%cd%

call :RunProcess %PROJECT_ROOT%
exit /B 0

: main process.
:RunProcess

set CLONE_PROJECT_NAME=Synchronizable%~n1

: Directory go to the Unity project the same hierarchy.
pushd %PROJECT_ROOT%
cd ../
rmdir /s /q %CLONE_PROJECT_NAME%
mkdir %CLONE_PROJECT_NAME%
set PROJECT_PATH=%cd%

: ↓ carry out the creation of a symbolic in the process below.
@echo on
for %%f in (Assets, Packages, ProjectSettings, Library) do (
	mklink /D "%PROJECT_PATH%\%CLONE_PROJECT_NAME%\%%f" "%PROJECT_ROOT%\%%f"
)
@echo off

: Post-processing ...
popd
goto :EOF
