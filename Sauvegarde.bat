@echo off
pushd %~dp0
git add .
set /p message="Message du commit: "
git commit -m "%message%"
git pull
git push
pause
echo                __    --------------------
echo               / _)   FIN DE LA SAUVEGARDE
echo      _.----._/ /     -------------------- 
echo     /         /
echo  __/ (  | (  |       Henri le pti dino
pause
echo /__.-'|_|--|_|
echo.
echo.
pause
pause