﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electoral_College_Messages;

namespace Electoral_College
{
    public enum WinnerOfState { User, Me };

    public enum ResultOfElection { UserWon, IWon, Tie};

    public class Utility
    {
        public Dictionary<string, int> VotesPerState()
        {
            return new Dictionary<string, int>()
                {
                    { "Alabama", 9 },
                    { "Alaska", 3 },
                    { "Arizona", 11 },
                    { "Arkansas", 6 },
                    { "California", 55 },
                    { "Colorado", 9 },
                    { "Connecticut", 7 },
                    { "Delaware", 3 },
                    { "District of Columbia", 3},
                    { "Florida", 29 },
                    { "Georgia", 16 },
                    { "Hawaii", 4 },
                    { "Idaho", 4 },
                    { "Illinois", 20 },
                    { "Indiana", 11 },
                    { "Iowa", 6 },
                    { "Kansas", 6 },
                    { "Kentucky", 8 },
                    { "Louisiana", 8 },
                    { "Maine", 4 },
                    { "Maryland", 10 },
                    { "Massachusetts", 11 },
                    { "Michigan", 16 },
                    { "Minnesota", 10 },
                    { "Mississippi", 6 },
                    { "Missouri", 10 },
                    { "Montana", 3 },
                    { "Nebraska", 5 },
                    { "Nevada", 6 },
                    { "New Hampshire", 4 },
                    { "New Jersey", 14 },
                    { "New Mexico", 5 },
                    { "New York", 29 },
                    { "North Carolina", 15 },
                    { "North Dakota", 3 },
                    { "Ohio", 18 },
                    { "Oklahoma", 7 },
                    { "Oregon", 7 },
                    { "Pennsylvania", 20 },
                    { "Rhode Island", 4 },
                    { "South Carolina", 9 },
                    { "South Dakota", 3 },
                    { "Tennessee", 11 },
                    { "Texas", 38 },
                    { "Utah", 6 },
                    { "Vermont", 3 },
                    { "Virginia", 13 },
                    { "Washington", 12 },
                    { "West Virginia", 5 },
                    { "Wisconsin", 10 },
                    { "Wyoming", 3 }
               };
        }

        public int GetValidEntry(string state, int votes)
        {
            Message.EnterWinner(state, votes);
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIf1or2(input) == false)
                {
                    Message.Not1or2(state);
                }
                else
                {
                    isValidInput = true;
                }
            }
            return int.Parse(input);
        }

        public bool CheckIf1or2(string input)
        {
            return input == "1" || input == "2";
        }

        public WinnerOfState NumSelectionToEnum(int numSelection)
        {
            if (numSelection == 1)
            {
                return WinnerOfState.User;
            }
            else
            {
                return WinnerOfState.Me;
            }
        }

        public int SumOfVotes(List<int> stateVotes)
        {
            return stateVotes.Sum();
        }

        public ResultOfElection DetermineResultOfElection(int myTotalVotes, int userTotalVotes)
        {
            if (userTotalVotes > myTotalVotes)
            {
                return ResultOfElection.UserWon;
            }
            else if (myTotalVotes > userTotalVotes)
            {
                return ResultOfElection.IWon;
            }
            else
            {
                return ResultOfElection.Tie;
            }
        }

        public void DisplayResults(ResultOfElection electionResult, int statesIWon, int statesUserWon, int myTotalVotes, int userTotalVotes)
        {
            switch (electionResult)
            {
                case ResultOfElection.UserWon:
                    Message.UserWon(statesUserWon, statesIWon, userTotalVotes, myTotalVotes);
                    break;
                case ResultOfElection.IWon:
                    Message.IWon(statesUserWon, statesIWon, userTotalVotes, myTotalVotes);
                    break;
                case ResultOfElection.Tie:
                    Message.Tie(statesUserWon, statesIWon, userTotalVotes, myTotalVotes);
                    break;
                default:
                    break;
            }
        }
    }
}
