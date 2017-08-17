﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Same_First_Digit;
using Same_First_Digit_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var num1 = utility.GetNumber("first");
            var num2 = utility.GetNumber("second");
            var digit1 = utility.GetFirstDigit(num1);
            var digit2 = utility.GetFirstDigit(num2);
            var areSame = utility.CheckIfSame(digit1, digit2);
            utility.DisplayResults(areSame, digit1, digit2);
            Console.ReadLine();
        }
    }
}
