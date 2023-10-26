### Parte 1
cls
mkdir src
mkdir teste

dotnet new webapi -n minhaapi -o src/minhaapi
dotnet build src\minhaapi\minhaapi.csproj
dotnet run -p src\minhaapi\minhaapi.csproj

dotnet new -h
dotnet new -l
dotnet new gitignore

### Parte 2

### Criando a sln forçadamente
dotnet new sln --force

### Criando o teste unitário: xunit
dotnet new xunit -n minhaapi.tests -o tests\minhaapi.tests

## adicionando na sln projetos 
dotnet sln add .\src\minhaapi\
dotnet sln add .\tests\minhaapi.tests\

## Adicionando APENAS no projeto de tests a referencias para minhaapi
dotnet add .\tests\minhaapi.tests\ reference .\src\minhaapi\

## Adicionando PACKAGE
dotnet add .\tests\minhaapi.tests\ package FluentAssertons














