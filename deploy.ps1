dotnet restore .

dotnet build .

dotnet publish -r win8-arm

robocopy.exe /MIR ".\bin\Debug\netcoreapp2.0\win8-arm\publish" "\\192.168.1.125\c$\ConsoleApps\PInvoke"