﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using End_Other;
using End_Other_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var firstString = utility.GetValidString("first");
            var secondString = utility.GetValidString("second");
            if (utility.CheckIfSameLength(firstString, secondString))
            {
                if (utility.CheckIfSameString(firstString, secondString))
                {
                    Message.SameString();
                }
                else
                {
                    Message.NoMatches();
                }
            }
            else
            {
                var firstIsLonger = utility.CheckIfFirstIsLonger(firstString, secondString);
                if (utility.CheckIfShorterIsEndOfLonger(firstString, secondString, firstIsLonger))
                {
                    if (firstIsLonger)
                    {
                        Message.MatchesTheEnd("second", "first");
                    }
                    else
                    {
                        Message.MatchesTheEnd("first", "second");
                    }
                }
                else
                {
                    Message.NoMatches();
                }
            }
            Console.ReadLine();
        }
    }
}
