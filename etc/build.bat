@echo off
color E

rem Printa a apresentacao do build.
echo.
echo  BUILD DO CLOCKER   [ D:\WORKSPACE\C#\CLOCKER\ETC\BUILD.BAT ]
echo.
echo.

echo  *******************************************
echo  **  INICIANDO  COMPILACAO  DO  CLOCKER.  **
echo  *******************************************
echo.
echo.

echo Posicionando no diretorio raiz do projeto
cd ..
echo.

echo Apagando a pasta de distribuicao para nova release [ \dist ]
rmdir /s /q dist  1>nul  2>&1
echo.

echo Criando nova estrutura para distribuir o pacote do executavel
mkdir dist       1>nul  2>&1
mkdir dist\logs  1>nul  2>&1
echo.

echo Copiando para distribuicao os arquivos de resources e executavel
copy bin\Release\*.* dist\
echo.

echo Compactando o build e gerando pacote de distribuicao da release [ ZIP ]
python -m zipfile -c clocker-1.0.zip dist\.
move clocker-1.0.zip dist\.  1>nul  2>&1
echo.

rem Pausa final...
echo.
pause
