using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIdle {
    public class Player {
        public DateTime startTime;
        public DateTime saveTime;
        public double energyIdle;
        public double energyMax;
        public double energyCap;
        public double energyPerTickBase;
        public double energyPerTick;
        public int inputQuantity;
        public double water;
        public double minerals;
        public Organ leaves = new Organ();
        public Organ roots = new Organ();

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
            leaves.name = "Leaves";
            leaves.prestige();
            roots.name = "Roots";
            roots.prestige();
        }
    }
}
