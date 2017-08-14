﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share_Digit_2_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Share Digit 2 program where you enter two 2 digit numbers and I\ntell you whether or not they share a digit. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterNumber()
        {
            Console.Write("\nEnter a 2 digit number: ");
        }

        public static void MustBe10to99()
        {
            Console.Write("\nSorry but the number must be between 10 and 99. Please enter a 2 digit\nnumber: ");
        }

        public static void NotANumber(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. Please enter a 2 digit number: ");
        }

        public static void DoShareDigit()
        {
            Console.WriteLine("\nCongratulations your two numbers share a digit!!! Press enter to close the\nprogram.");
        }

        public static void DoNotShareDigit()
        {
            Console.WriteLine("\nUnfortunately your two numbers do not share a digit. Press enter to close the\nprogram.");
        }
    }
}