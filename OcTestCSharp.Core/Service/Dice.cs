﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcTestCSharp.Core.Service
{
    public class Dice
    {
        private Random random;

        public Dice()
        {
            random = new();
        }

        public int Roll()
        {
            return random.Next(1,7);
        }
    }
}
