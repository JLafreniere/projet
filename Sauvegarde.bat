@echo off
pushd %~dp0
git add .
set /p message="Message du commit: "
git commit -m "%message%"
git pull
git push
pause
echo               __
echo              / _)
echo     _/\/\/\_/ /
echo   _/         /
echo _/  (  / (  l
echo/__.-'_--   _  alo moi c pablo - pablo 2015
pause