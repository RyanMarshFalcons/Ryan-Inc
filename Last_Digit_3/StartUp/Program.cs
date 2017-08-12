﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Last_Digit_3;
using Last_Digit_3_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var nums = new int[3];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = utility.GetValidNumber();
            }
            var lastDigits = utility.LastDigits(nums);
            var isMatch = utility.CheckForMatch(lastDigits);
            utility.DisplayResults(isMatch);
            Console.ReadLine();
        }
    }
}
