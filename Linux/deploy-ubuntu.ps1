dotnet restore
dotnet build

dotnet publish . -r ubuntu.16.04-arm

& pscp.exe -r .\bin\Debug\netcoreapp2.0\ubuntu.16.04-arm\publish\* ubuntu@192.168.1.110:/home/ubuntu/rasppinvoke

& plink.exe -v -ssh ubuntu@192.168.1.110 chmod u+x,o+x /home/ubuntu/rasppinvoke/RaspberryPi_PInvoke