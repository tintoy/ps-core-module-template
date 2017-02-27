# ps-binary-module-template

A `dotnet new` template that creates a project for a binary PowerShell module.

## Getting started

1. `dotnet new -i FiftyProtons.Templates.PSCore::*`
2. `mkdir MyModule; cd MyModule`
3. `dotnet new ps-core-module`
4. `dotnet restore`
5. `dotnet publish -c release -o $PWD/bin/release`
6. `powershell`
7. `Import-Module ./bin/release/MyModule.dll`
8. `Get-Greeting -Name 'PowerShell'`

## Building

1. `dotnet restore`
2. `dotnet pack`
3. And to use locally-built templates: `dotnet new -i src/Templates.PSCore/content`
