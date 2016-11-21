@echo off
pushd %~dp0
git add .
set /p message="Message du commit: "
git commit -m "%message%"
git pull
git push
start /d "C:\Program Files\Internet Explorer" IEXPLORE.EXE http://dan-ball.jp/en/javagame/dust2/
echo.   
echo.   
echo                        _. - ~ ~ ~ - .
echo     ..       __.    .-~               ~-.
echo     ((\     /   `}.~                     `.
echo      \\\   {     }               /     \   \         --------------------
echo  (\   \\~~       }                     }   \         FIN DE LA SAUVEGARDE
echo   \`.-~ -@~     }  ,-,.                )    \        --------------------
echo   (___     ) _}  (    :            / /      `.
echo    `----._-~.     _\ \ _       \   / /- _      `.
echo           ~~----~~  \ \ ~~--~~~(  x /     ~-.     ~- _
echo                     /  /         \  \          ~- . _ _~_-_.
echo                  __/  /          _\  )
echo                .k___.'         .k___/
echo.   
echo.   
echo.                   
pause
exit
pause