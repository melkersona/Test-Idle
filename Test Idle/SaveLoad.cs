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
            try {
                Console.WriteLine($"{path}/{filename}");
                System.IO.FileStream file = System.IO.File.Create($"{path}\\{filename}");
                writer.Serialize(file, p);
                file.Close();
            } catch {
                System.Windows.Forms.MessageBox.Show("Failed to save!.");
            }
        }

        public Player load(String path, String filename) {
            Console.WriteLine($"{path}/{filename}");
            Player p = new Player();
            System.Xml.Serialization.XmlSerializer reader =
    new System.Xml.Serialization.XmlSerializer(typeof(Player));
            System.IO.StreamReader file = new System.IO.StreamReader($"{path}\\{filename}");
            p = (Player)reader.Deserialize(file);
            file.Close();
            return p;
        }
    }
}
