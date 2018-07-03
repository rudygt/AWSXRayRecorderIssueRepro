dotnet test -c Release

:repeat
dotnet test --no-build -c Release && goto :repeat
echo Failure!