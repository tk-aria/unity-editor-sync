@echo off
rem Unityプロジェクトルート直下で起動して下さい.
set SCRIPT_DIR=%~dp0
set PROJECT_ROOT=%cd%

set CLONE_PROJECT_NAME=UnityProj_SymbolicLink

rem Unityプロジェクト同階層にディレクトリ移動.
cd %PROJECT_ROOT%
cd ../

rmdir /s /q %CLONE_PROJECT_NAME%
mkdir %CLONE_PROJECT_NAME%
set PROJECT_PATH=%cd%

rem ↓以下処理でシンボリックの作成を行う.
@echo on
for %%f in (Assets, Packages, ProjectSettings, Library) do (
  mklink /D "%PROJECT_PATH%\%CLONE_PROJECT_NAME%\%%f" "%PROJECT_ROOT%\%%f"
)

@echo off
rem 後処理...
cd %PROJECT_ROOT%
