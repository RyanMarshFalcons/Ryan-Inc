﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Turtle : Animal
    {
        public string Age { get; set; }
        
        public bool Female { get; set; }

        public string Name { get; set; }

        public string Classification()
        {
            return "Reptile";
        }

        public bool LaysEggs()
        {
            return true;
        }

        public string NoiseMakes()
        {
            return "hiss";
        }

        public int NumberOfLegs()
        {
            return 4;
        }

        public bool WarmBlooded()
        {
            return false;
        }
    }
}
