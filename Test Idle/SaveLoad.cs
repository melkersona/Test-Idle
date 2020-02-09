using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1 {
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

            double offlineMilliseconds = DateTime.UtcNow.Subtract(p.saveTime).TotalMilliseconds;

            p.energyPerTick = p.energyPerTickBase + ((double)p.solarCollectorsLevel * 2.5 * Constants._TicksPerSecond / Constants._MillisecondsPerSecond);
            if (p.energyMax < p.energyCap) {
                if ((p.energyPerTick * (offlineMilliseconds / 5)) + p.energyCap < p.energyMax) {
                    p.energyIdle += p.energyPerTick;
                    p.energyMax += p.energyPerTick;
                } else {
                    p.energyIdle += p.energyCap - p.energyMax;
                    p.energyMax = p.energyCap;
                }
            }
            if (p.solarCollectorsEnergy > 0) {
                p.solarCollectorsExperience += ((double)p.solarCollectorsEnergy / 10000);
            }
            if (p.solarCollectorsExperience > 0) {
                p.solarCollectorsLevel = (int)Math.Floor(p.solarCollectorsExperience / 10);
            }

            return p;
        }
    }
}
