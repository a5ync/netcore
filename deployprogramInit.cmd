SET local=C:\Repos\netcore
SET remote=~/netcore

pushd %local%

dnvm use 1.0.0-beta7 & dnu restore & dnu publish --no-source & popd & for /F "tokens=*" %%A in (ips.txt) do pscp -scp -r %local%\bin\output\approot root@192.168.1.%%A:%remote%
pause