using System;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        Player p;
        String path = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\TestIdle";
        String filename = "TestIdle.xml";
        public Form1() {
            InitializeComponent();
            try {
                System.IO.Directory.CreateDirectory(path);
            } catch {}
            try {
                p = new SaveLoad().load(path, filename);
            } catch {
                p = new Player();
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            p.energyPerTick = p.energyPerTickBase + ((float)p.solarCollectorsLevel / 20);
            if (p.energyMax < p.energyCap) {
                p.energyIdle += p.energyPerTick;
                p.energyMax += p.energyPerTick;
            }
            if (p.solarCollectorsEnergy > 0) {
                p.solarCollectorsExperience += ((float)p.solarCollectorsEnergy / 10000);
            }
            if (p.solarCollectorsExperience > 0) {
                p.solarCollectorsLevel = (int)Math.Floor(p.solarCollectorsExperience / 10);
            }
            updateText();
        }

        private void updateText() {
            txtEnergy.Text = String.Format("Current Energy: {0:0}/{1:0}", Math.Floor(p.energyIdle), Math.Floor(p.energyMax));
            txtSolarCollectorsEnergyLabel.Text = $"{p.solarCollectorsEnergy}";
            txtSolarCollectorsLevelLabel.Text = $"{p.solarCollectorsLevel}";
            txtEnergyHoverLabel.Text = ($"Your energy per second is: {p.energyPerTick*20:0.00}");
            txtLifeTime.Text = String.Format("{0:hh}:{0:mm}:{0:ss}", DateTime.UtcNow.Subtract(p.startTime));
        }

        private void btnSolarCollectorAllocate_Click(object sender, EventArgs e) {
            if (p.energyIdle >= p.inputQuantity) {
                p.solarCollectorsEnergy += p.inputQuantity;
                p.energyIdle -= p.inputQuantity;
            } else {
                p.solarCollectorsEnergy += (int)Math.Floor(p.energyIdle);
                p.energyIdle -= (int)Math.Floor(p.energyIdle);
            }
        }

        private void btnSollarCollectorDeallocate_Click(object sender, EventArgs e) {
            if (p.solarCollectorsEnergy >= p.inputQuantity) {
                p.solarCollectorsEnergy -= p.inputQuantity;
                p.energyIdle += p.inputQuantity;
            } else {
                p.energyIdle += p.solarCollectorsEnergy;
                p.solarCollectorsEnergy = 0;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {
            try {
                p.inputQuantity = Int32.Parse(txtInput.Text);
            } catch {
                txtInput.Text = "0";
            }
        }

        private void txtEnergy_MouseEnter(object sender, EventArgs e) {
            txtEnergyHoverLabel.Visible = true;
        }

        private void txtEnergy_MouseLeave(object sender, EventArgs e) {
            txtEnergyHoverLabel.Visible = false;
        }

        private void txtEnergy_MouseMove(object sender, MouseEventArgs e) {
            if (txtEnergyHoverLabel.Visible) {
                txtEnergyHoverLabel.Location = new System.Drawing.Point(Cursor.Position.X - this.Location.X, Cursor.Position.Y - this.Location.Y);
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            new SaveLoad().save(path, filename, p);
        }
    }
}
