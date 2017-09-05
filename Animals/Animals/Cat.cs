﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Cat : Animal
    {
        public string Age { get; set; }

        public bool Female { get; set; }

        public string Name { get; set; }

        public string Classification()
        {
            return "Mammal";
        }

        public bool LaysEggs()
        {
            return false;
        }

        public string NoiseMakes()
        {
            return "meow";
        }

        public int NumberOfLegs()
        {
            return 4;
        }

        public bool WarmBlooded()
        {
            return true;
        }
    }
}
