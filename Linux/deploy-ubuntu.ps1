dotnet restore
dotnet build

dotnet publish . -r ubuntu.16.04-arm

& pscp.exe -r .\bin\Debug\netcoreapp2.0\ubuntu.16.04-arm\publish\* <<remote username>>@<<machine ip address>>:/home/ubuntu/rasppinvoke

& plink.exe -v -ssh <<remote username>>@<<machine ip address>> chmod u+x,o+x /home/<<remote username>>/rasppinvoke/RaspberryPi_PInvoke
