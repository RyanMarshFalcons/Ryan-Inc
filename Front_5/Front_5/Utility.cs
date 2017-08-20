﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Front_5_Messages;

namespace Front_5
{
    public class Utility
    {
        public string GetString()
        {
            var isValid = false;
            var userInput = "";
            Message.EnterString();
            while (isValid == false)
            {
                userInput = Console.ReadLine();
                if (!CheckIfValidString(userInput))
                {
                    Message.AtLeastFive();
                }
                else
                {
                    isValid = true;
                }
            }
            return userInput;
        }

        public bool CheckIfValidString(string input)
        {
            return input.Length >= 5;
        }

        public string CreateNewString(string userString)
        {
            var first5Chars = userString.Substring(0, 5);
            return first5Chars + first5Chars + first5Chars + first5Chars + first5Chars;
        }
    }
}