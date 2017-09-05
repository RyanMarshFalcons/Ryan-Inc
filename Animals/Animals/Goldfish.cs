﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Goldfish : Animal 
    {
        public string Age { get; set; }

        public bool Female { get; set; }

        public string Name { get; set; }

        public string Classification()
        {
            return "Fish";
        }

        public bool LaysEggs()
        {
            return true;
        }

        public string NoiseMakes()
        {
            return "kiss";
        }

        public int NumberOfLegs()
        {
            return 0;
        }

        public bool WarmBlooded()
        {
            return false;
        }
    }
}