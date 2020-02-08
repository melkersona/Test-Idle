using System;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        double energyIdle = 100;
        double energyMax = 100;
        double energyCap = 1000;
        double energyPerTickBase = 0.1;
        double energyPerTick;
        int inputQuantity = 1;
        int solarCollectorsLevel = 0;
        int solarCollectorsEnergy = 0;
        double solarCollectorsExperience = 0;
        public Form1() {
            InitializeComponent();
            energyPerTick = energyPerTickBase;
        }

        private void timer1_Tick(object sender, EventArgs e) {
            energyPerTick = energyPerTickBase + ((float)solarCollectorsLevel / 20);
            if (energyMax < energyCap) {
                energyIdle += energyPerTick;
                energyMax += energyPerTick;
            }
            //if (solarCollectorsEnergy > 0) {
                solarCollectorsExperience += ((float)solarCollectorsEnergy / 10000);
            //}
            if (solarCollectorsExperience > 0) {
                solarCollectorsLevel = (int)Math.Floor(solarCollectorsExperience / 10);
            }
            updateText();
        }

        private void updateText() {
            txtEnergy.Text = String.Format("Current Energy: {0:0}/{1:0}", Math.Floor(energyIdle), Math.Floor(energyMax));
            txtSolarCollectorsEnergyLabel.Text = String.Format("{0}", solarCollectorsEnergy);
            txtSolarCollectorsLevelLabel.Text = String.Format("{0}", solarCollectorsLevel);
            txtEnergyHoverLabel.Text = String.Format("Your energy per second is: {0:0.00}", energyPerTick * 20);

        }

        private void btnSolarCollectorAllocate_Click(object sender, EventArgs e) {
            if (energyIdle >= inputQuantity) {
                solarCollectorsEnergy += inputQuantity;
                energyIdle -= inputQuantity;
            } else {
                solarCollectorsEnergy += (int)Math.Floor(energyIdle);
                energyIdle -= (int)Math.Floor(energyIdle);
            }

            //updateText();
        }

        private void btnSollarCollectorDeallocate_Click(object sender, EventArgs e) {
            if (solarCollectorsEnergy >= inputQuantity) {
                solarCollectorsEnergy -= inputQuantity;
                energyIdle += inputQuantity;
            } else {
                energyIdle += solarCollectorsEnergy;
                solarCollectorsEnergy = 0;
            }

            //updateText();
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {
            try {
                inputQuantity = Int32.Parse(txtInput.Text);
#pragma warning disable CS0168 // Variable is declared but never used
            } catch (Exception f) {
#pragma warning restore CS0168 // Variable is declared but never used
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
    }
}
