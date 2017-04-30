using System;
using System.Runtime.InteropServices;

namespace RaspberryPiCore
{
    class Program
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern char CharUpper(char character);

        static void Main(string[] args)
        {
            var textToChange = "Hello Internet of Things!";
            var inputCharacterArray = textToChange.ToCharArray();

            // array of chars to hold the capitalised text
            var outputCharacterArray = new char[inputCharacterArray.Length];

            for (int i = 0; i < inputCharacterArray.Length; i++)
            {
                outputCharacterArray[i] = CharUpper(inputCharacterArray[i]);
            }

            Console.WriteLine($"Original text is {textToChange}");
            Console.WriteLine($"Changed text is {new string(outputCharacterArray)}");
        }
    }
}