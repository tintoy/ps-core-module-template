# ps-binary-module-template

A `dotnet new` template that creates a project for a binary PowerShell module.

## Getting started

1. `dotnet restore`
2. `dotnet pack`
3. `dotnet new -i src/Templates.PSCore/bin/Debug/Tintoy.Templates.PSCore.0.1.0-alpha1.nupkg` (or just `dotnet new -i src/Templates.PSCore/content`)
4. `mkdir MyModule; cd MyModule`
5. `dotnet new ps-core-module`
6. `dotnet restore`
7. `dotnet publish -c release -o $PWD/bin/release`
8. `powershell`
9. `Import-Module ./bin/release/MyModule.dll`
10. `Get-Greeting -Name 'PowerShell'`
