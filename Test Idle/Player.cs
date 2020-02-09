using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIdle {
    public class Player {
        public DateTime startTime;
        public DateTime saveTime;
        public double energyIdle = 100;
        public double energyMax = 100;
        public double energyCap = 1000;
        public double energyPerTickBase = 0.1;
        public double energyPerTick;
        public int inputQuantity = 1;
        public Component solarCollectors = new Component();

        public Player() {
            resetStats();
        }

        public void Prestige() {
            resetStats();
            energyIdle = 100;
            energyCap = energyCap + energyMax * 0.1;
            energyMax = 100;
            inputQuantity = 1;
        }

        private void resetStats() {
            startTime = DateTime.UtcNow;
            solarCollectors.name = "Solar Collectors";
            solarCollectors.level = 0;
            solarCollectors.energy = 0;
            solarCollectors.experience = 0;
        }
    }
}
