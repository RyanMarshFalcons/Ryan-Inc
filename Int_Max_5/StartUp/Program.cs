﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Int_Max_5;
using Int_Max_5_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var num1 = utility.GetValidNumber("first");
            var num2 = utility.GetValidNumber("second");
            var num3 = utility.GetValidNumber("third");
            var num4 = utility.GetValidNumber("fourth");
            var num5 = utility.GetValidNumber("fifth");
            var maxNum = utility.GetMax(num1, num2, num3, num4, num5);
            Message.DisplayHighest(maxNum);
            Console.ReadLine();
        }
    }
}
