using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1 {
    public class Player {
        public DateTime startTime;
        public DateTime saveTime;
        public double energyIdle = 100;
        public double energyMax = 100;
        public double energyCap = 1000;
        public double energyPerTickBase = 0.1;
        public double energyPerTick;
        public int inputQuantity = 1;
        public int solarCollectorsLevel = 0;
        public int solarCollectorsEnergy = 0;
        public double solarCollectorsExperience = 0;

        public Player() {
            startTime = DateTime.UtcNow;
        }
    }
}
