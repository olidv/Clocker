@echo off
color E

rem Printa a apresentacao do deploy:
echo.
echo  DEPLOY DO CLOCKER   [ D:\WORKSPACE\C#\CLOCKER\ETC\DEPLOY.BAT ]
echo.
echo.

echo  ********************************************
echo  **  INICIANDO  IMPLANTACAO  DO  CLOCKER.  **
echo  ********************************************
echo.
echo.

echo Posicionando no diretorio raiz da aplicacao
mkdir C:\Apps\Infinite\Clocker  1>nul  2>&1
cd /d C:\Apps\Infinite\Clocker
echo.

echo Limpando as pastas temporarias da aplicacao
rem del /f /q logs\*.*  1>nul  2>&1
echo.

echo Posicionando no diretorio do projeto
cd /d D:\Workspace\C#\Clocker
echo.

echo Copiando os arquivos do projeto
xcopy dist\*.* C:\Apps\Infinite\Clocker  /E /C /Q /H /R /Y
echo.

echo Disponibilizando release da aplicacao para producao
copy /y dist\*.zip D:\Publico
echo.

rem Pausa final...
echo.
pause
