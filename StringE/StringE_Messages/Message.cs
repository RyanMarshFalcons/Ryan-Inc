﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringE_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello and welcome to my StringE program where you will enter a string and then Iwill tell you whether or not your string is StringE. Press enter to continue.");
            Console.ReadLine();
        }

        public static void RequestUserInput()
        {
            Console.Write("Input at least one character to form your string: ");
        }

        public static void AtLeastOneCharacter()
        {
            Console.Write("\nSorry but you must input at least one character to create a valid string. Pleasetry again: ");
        }

        public static void IsStringE()
        {
            Console.WriteLine($"\nCongratulations your string is StringE!!! Press enter to close the program.");
        }

        public static void IsntStringE()
        {
            Console.WriteLine($"\nUnfortunately your string is not StringE. Press enter to close the program.");
        }
    }
}
