﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Share_Digit_2;
using Share_Digit_2_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var num1 = utility.GetValidNumber();
            var num2 = utility.GetValidNumber();
            var num1sDigits = utility.GetDigits(num1);
            var num2sDigits = utility.GetDigits(num2);
            var isMatch = utility.MatchingDigits(num1sDigits, num2sDigits);
            utility.DisplayResults(isMatch);
            Console.ReadLine();
        }
    }
}
