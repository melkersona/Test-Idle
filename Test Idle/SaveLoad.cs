using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestIdle {
    class SaveLoad {
        public void save(String path, String filename, Player p) {
            System.Xml.Serialization.XmlSerializer writer =
            new System.Xml.Serialization.XmlSerializer(typeof(Player));
            p.saveTime = DateTime.UtcNow;
            try {
                System.IO.FileStream file = System.IO.File.Create($"{path}\\{filename}");
                writer.Serialize(file, p);
                file.Close();
            } catch {
                System.Windows.Forms.MessageBox.Show("Failed to save!.");
            }
        }

        public Player load(String path, String filename) {
            Player p = new Player();
            System.Xml.Serialization.XmlSerializer reader =
    new System.Xml.Serialization.XmlSerializer(typeof(Player));
            System.IO.StreamReader file = new System.IO.StreamReader($"{path}\\{filename}");
            p = (Player)reader.Deserialize(file);
            file.Close();

            p.energyPerTick = p.energyPerTickBase + ((double)p.solarCollectors.level * 2.5 * Constants._TicksPerSecond / Constants._MillisecondsPerSecond);
            double offlineSeconds = DateTime.UtcNow.Subtract(p.saveTime).TotalSeconds;
            double offlineEnergyGain = p.energyPerTick * (offlineSeconds * Constants._TicksPerSecond);


            
            if (p.energyMax < p.energyCap) {
                if (offlineEnergyGain + p.energyMax < p.energyCap) {
                    p.energyIdle += offlineEnergyGain;
                    p.energyMax += offlineEnergyGain;
                } else {
                    p.energyIdle += p.energyCap - p.energyMax;
                    p.energyMax = p.energyCap;
                }
            }
            if (p.solarCollectors.energy > 0) {
                p.solarCollectors.experience += ((double)p.solarCollectors.energy / 10000);
            }
            if (p.solarCollectors.experience > 0) {
                p.solarCollectors.level = (int)Math.Floor(p.solarCollectors.experience / 10);
            }

            return p;
        }
    }
}
