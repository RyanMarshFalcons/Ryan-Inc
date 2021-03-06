﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anagrams_Messages;
using System.Text.RegularExpressions;

namespace Anagrams
{
    public class Utility
    {
        public string GetUserInput(string firstOrSecond)
        {
            var userInput = "";
            Message.RequestString(firstOrSecond);
            while (userInput == "")
            {
                userInput = Console.ReadLine();
                if (userInput == "")
                {
                    Message.NoEmptyStrings();
                }
            }
            return userInput;
        }

        public string InputSorted(string userInput)
        {
            var userInputAsArray = userInput.ToCharArray();
            Array.Sort(userInputAsArray);
            return new string(userInputAsArray);
        }

        public string AdjustString(string userString)
        {
            return Regex.Replace(userString, "[^A-Za-z0-9]", "").ToLower();
        }

        public bool FindOutIfAnagram(string sortedFirstInput, string sortedSecondInput)
        {
            return sortedFirstInput == sortedSecondInput;
        }

        public void DisplayResults(string firstInput, string secondInput, bool areAnagrams)
        {
            if (areAnagrams)
            {
                Message.AreAnagrams(firstInput, secondInput);
            }
            else
            {
                Message.AreNotAnagrams(firstInput, secondInput);
            }
        }
    }
}
