﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIdle {
    public class Organ {
        public String name;
        public double experience;
        public double level;
        public double energy;

        public void prestige()
        {
            this.experience = 0;
            this.level = 0;
            this.energy = 0;
        }
    }
}
