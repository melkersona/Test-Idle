﻿using System;
using System.Windows.Forms;

namespace TestIdle {
    public partial class Form1 : Form {
        Player p;
        String path = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\TestIdle";
        String filename = "TestIdle.xml";

        public Form1() {
            InitializeComponent();
            timerTick.Interval = (int)(1.0 / Constants._TicksPerSecond * Constants._MillisecondsPerSecond);
            try {
                System.IO.Directory.CreateDirectory(path);
            } catch { }
            try {
                p = new SaveLoad().load(path, filename);
            } catch {
                p = new Player();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e) {
            //p.energyPerTick = p.energyPerTickBase + ((double)p.leaves.level * 2.5 * Constants._TicksPerSecond / Constants._MillisecondsPerSecond);
            p.water += p.leaves.level / Constants._TicksPerSecond;
            p.minerals += p.roots.level / Constants._TicksPerSecond;
            if (p.energyMax < p.energyCap) {
                p.energyIdle += p.energyPerTick;
                p.energyMax += p.energyPerTick;
            }
            if (p.leaves.energy > 0) {
                p.leaves.experience += ((double)p.leaves.energy / 100);
            }
            if (p.leaves.experience > 0) {
                p.leaves.level = (int)Math.Floor(p.leaves.experience / 10);
            }

            if (p.roots.energy > 0)
            {
                p.roots.experience += ((double)p.roots.energy / 100);
            }
            if (p.roots.experience > 0)
            {
                p.roots.level = (int)Math.Floor(p.roots.experience / 10);
            }
            updateText();
        }

        private void timerAutoSave_Tick(object sender, EventArgs e) {
            new SaveLoad().save(path, filename, p);
        }
        private void updateText() {
            txtEnergy.Text = String.Format("Current Energy: {0:0}/{1:0}", Math.Floor(p.energyIdle), Math.Floor(p.energyMax));
            txtLeavesEnergy.Text = $"{p.leaves.energy}";
            txtLeavesLevel.Text = $"{p.leaves.level}";
            txtRootsEnergy.Text = $"{p.roots.energy}";
            txtRootsLevel.Text = $"{p.roots.level}";
            txtEnergyHoverLabel.Text = ($"Your energy per second is: {p.energyPerTick * Constants._TicksPerSecond:0.00}\r\n" +
                $"Your energy cap for this prestige is: {p.energyCap}");
            txtLifeTime.Text = String.Format("{0:hh}:{0:mm}:{0:ss}", DateTime.UtcNow.Subtract(p.startTime));
            txtInput.Text = $"{p.inputQuantity}";
            txtWater.Text = $"Water: {p.water:0.00}";
            txtMinerals.Text = $"Minerals: {p.minerals:0.00}";
        }

        private void btnLeavesAllocate_Click(object sender, EventArgs e) {
            if (p.energyIdle >= p.inputQuantity) {
                p.leaves.energy += p.inputQuantity;
                p.energyIdle -= p.inputQuantity;
            } else {
                p.leaves.energy += (int)Math.Floor(p.energyIdle);
                p.energyIdle -= (int)Math.Floor(p.energyIdle);
            }
        }

        private void btnLeavesDeallocate_Click(object sender, EventArgs e) {
            if (p.leaves.energy >= p.inputQuantity) {
                p.leaves.energy -= p.inputQuantity;
                p.energyIdle += p.inputQuantity;
            } else {
                p.energyIdle += p.leaves.energy;
                p.leaves.energy = 0;
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

        private void btnPrestige_Click(object sender, EventArgs e) {
            p.Prestige();
        }

        private void btnRootsAllocate_Click(object sender, EventArgs e)
        {
            if (p.energyIdle >= p.inputQuantity)
            {
                p.roots.energy += p.inputQuantity;
                p.energyIdle -= p.inputQuantity;
            }
            else
            {
                p.roots.energy += (int)Math.Floor(p.energyIdle);
                p.energyIdle -= (int)Math.Floor(p.energyIdle);
            }
        }

        private void btnRootsDeallocate_Click(object sender, EventArgs e)
        {
            if (p.roots.energy >= p.inputQuantity)
            {
                p.roots.energy -= p.inputQuantity;
                p.energyIdle += p.inputQuantity;
            }
            else
            {
                p.energyIdle += p.roots.energy;
                p.roots.energy = 0;
            }
        }

        private void btnOrgansView_Click(object sender, EventArgs e)
        {
            this.grpboxOrgans.Visible = true;
        }

        private void btnHeightView_Click(object sender, EventArgs e)
        {
            this.grpboxOrgans.Visible = false;
        }
    }
}
