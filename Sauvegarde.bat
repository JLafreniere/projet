pushd %~dp0
git add .
git commit -m "Sauvegarde de fin de journée"
git pull
git push
pause