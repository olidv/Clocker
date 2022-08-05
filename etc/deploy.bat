@echo off
color E

rem Printa a apresentacao do deploy:
echo.
echo  DEPLOY DO DIGITAL-CLOCK   [ D:\WORKSPACE\C#\DIGITAL-CLOCK\ETC\DEPLOY.BAT ]
echo.
echo.

echo  **************************************************
echo  **  INICIANDO  IMPLANTACAO  DO  DIGITAL-CLOCK.  **
echo  **************************************************
echo.
echo.

echo Posicionando no diretorio raiz da aplicacao
cd /d C:\Apps\B3\Digital-Clock
echo.

echo Limpando as pastas temporarias da aplicacao
rem del /f /q logs\*.*  1>nul  2>&1
echo.

echo Posicionando no diretorio do projeto
cd /d D:\Workspace\C#\Digital-Clock
echo.

echo Copiando os arquivos do projeto
xcopy dist\*.* C:\Apps\B3\Digital-Clock  /E /C /Q /H /R /Y
echo.

rem Pausa final...
echo.
pause
