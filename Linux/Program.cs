using System;
using System.Runtime.InteropServices;

namespace RaspberryPi_PInvoke
{
    class Program
    {
        [DllImport("libc.so.6", EntryPoint = "toupper")]
        private static extern int CharUpper(int c);

        static void Main(string[] args)
        {
            var textToChange = "Hello Internet of Things!";
            var inputCharacterArray = textToChange.ToCharArray();
 
            // array of chars to hold the capitalised text
            var outputCharacterArray = new char[inputCharacterArray.Length];
 
            for(int i = 0; i < inputCharacterArray.Length; i++) 
            {
                var charToByte = (byte)inputCharacterArray[i];
                outputCharacterArray[i] = (char)CharUpper(charToByte);
            }
 
            Console.WriteLine($"Original text is {textToChange}");
            Console.WriteLine($"Changed text is {new string(outputCharacterArray)}");
        }
    }
}