# RaspberryPi.PInvoke

This project is a simple proof of concept to show that it is possible to use PInvoke commands on the Raspberry Pi 3 ARM processor architecture.

## C# Method signatures for native functions.

### [CharUpper](https://msdn.microsoft.com/en-us/library/windows/desktop/ms647474%28v=vs.85%29.aspx?f=255&MSPPError=-2147217396)

[DllImport("user32.dll", CharSet = CharSet.Auto)]  
static extern char CharUpper(char character);
