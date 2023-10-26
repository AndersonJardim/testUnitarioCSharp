
cls
mkdir src
mkdir teste

dotnet new webapi -n minhaapi -o src/minhaapi
dotnet build src\minhaapi\minhaapi.csproj
dotnet run -p src\minhaapi\minhaapi.csproj

dotnet new -h
dotnet new -l

dotnet new gitignore

