@echo off
pushd %~dp0
git add .
set /p message="Message du commit: "
git commit -m "%message%"
git pull
git push
echo.
echo.
echo --------------------
echo FIN DE LA SAUVEGARDE
echo --------------------
echo.
echo.
echo              _ _,---._ 
echo           ,-','       `-.___ 
echo          /-;'               `._ 
echo         /\/          ._   _,'o \ 
echo        ( /\       _,--'\,','"`. ) 
echo         ^|\      ,'o     \'    //\ 
echo         ^|      \        /   ,--'""`-. 
echo         :       \_    _/ ,-'         `-._ 
echo          \        `--'  /                ) 
echo           `.  \`._    ,'     ________,',' 
echo             .--`     ,'  ,--` __\___,;' 
echo              \`.,-- ,' ,`_)--'  /`.,' 
echo               \^( ;  ^| ^| )      ^(`-/ 
echo                 `--'^| ^|^)       ^|-/ 
echo                   ^| ^| ^|        ^| ^| 
echo                   ^| ^| ^|,.,-.   ^| ^|_ 
echo                   ^| `./ /   )---`  ) 
echo                  _^|  /    ,',   ,-' 
echo                 ,'^|_(    /-^<._,' ^|--, 
echo                 ^|    `--'---.     \/ \ 
echo                 ^|          / \    /\  \ 
echo               ,-^---._     ^|  \  /  \  \ 
echo            ,-'        \----'   \/    \--`. 
echo           /            \              \   \ 
pause