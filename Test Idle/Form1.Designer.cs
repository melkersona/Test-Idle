namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerTick = new System.Windows.Forms.Timer(this.components);
            this.txtEnergy = new System.Windows.Forms.TextBox();
            this.txtSollarCollectorsComponentLabel = new System.Windows.Forms.TextBox();
            this.btnSollarCollectorDeallocate = new System.Windows.Forms.Button();
            this.btnSolarCollectorAllocate = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtInputLabel = new System.Windows.Forms.TextBox();
            this.txtSolarCollectorsEnergyLabel = new System.Windows.Forms.TextBox();
            this.txtSolarCollectorsLevelLabel = new System.Windows.Forms.TextBox();
            this.grpboxComponents = new System.Windows.Forms.GroupBox();
            this.panelSolarCollector = new System.Windows.Forms.Panel();
            this.txtComponentEnergyLabel = new System.Windows.Forms.TextBox();
            this.txtComponentLevelLabel = new System.Windows.Forms.TextBox();
            this.txtComonentNameLabel = new System.Windows.Forms.TextBox();
            this.txtEnergyHoverLabel = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLifeTimeLabel = new System.Windows.Forms.TextBox();
            this.txtLifeTime = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupboxStats = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timerAutoSave = new System.Windows.Forms.Timer(this.components);
            this.grpboxComponents.SuspendLayout();
            this.panelSolarCollector.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupboxStats.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerTick
            // 
            this.timerTick.Enabled = true;
            this.timerTick.Interval = 50;
            this.timerTick.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtEnergy
            // 
            this.txtEnergy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEnergy.Location = new System.Drawing.Point(6, 12);
            this.txtEnergy.Name = "txtEnergy";
            this.txtEnergy.ReadOnly = true;
            this.txtEnergy.Size = new System.Drawing.Size(149, 13);
            this.txtEnergy.TabIndex = 5;
            this.txtEnergy.TabStop = false;
            this.txtEnergy.Text = "Current Energy: 100/100";
            this.txtEnergy.MouseEnter += new System.EventHandler(this.txtEnergy_MouseEnter);
            this.txtEnergy.MouseLeave += new System.EventHandler(this.txtEnergy_MouseLeave);
            this.txtEnergy.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtEnergy_MouseMove);
            // 
            // txtSollarCollectorsComponentLabel
            // 
            this.txtSollarCollectorsComponentLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSollarCollectorsComponentLabel.BackColor = System.Drawing.SystemColors.Control;
            this.txtSollarCollectorsComponentLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSollarCollectorsComponentLabel.Location = new System.Drawing.Point(8, 9);
            this.txtSollarCollectorsComponentLabel.Name = "txtSollarCollectorsComponentLabel";
            this.txtSollarCollectorsComponentLabel.ReadOnly = true;
            this.txtSollarCollectorsComponentLabel.Size = new System.Drawing.Size(84, 13);
            this.txtSollarCollectorsComponentLabel.TabIndex = 6;
            this.txtSollarCollectorsComponentLabel.TabStop = false;
            this.txtSollarCollectorsComponentLabel.Text = "Solar Collectors";
            // 
            // btnSollarCollectorDeallocate
            // 
            this.btnSollarCollectorDeallocate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSollarCollectorDeallocate.AutoSize = true;
            this.btnSollarCollectorDeallocate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSollarCollectorDeallocate.Location = new System.Drawing.Point(279, 4);
            this.btnSollarCollectorDeallocate.Name = "btnSollarCollectorDeallocate";
            this.btnSollarCollectorDeallocate.Size = new System.Drawing.Size(20, 23);
            this.btnSollarCollectorDeallocate.TabIndex = 7;
            this.btnSollarCollectorDeallocate.Text = "-";
            this.btnSollarCollectorDeallocate.UseVisualStyleBackColor = true;
            this.btnSollarCollectorDeallocate.Click += new System.EventHandler(this.btnSollarCollectorDeallocate_Click);
            // 
            // btnSolarCollectorAllocate
            // 
            this.btnSolarCollectorAllocate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSolarCollectorAllocate.AutoSize = true;
            this.btnSolarCollectorAllocate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSolarCollectorAllocate.Location = new System.Drawing.Point(253, 4);
            this.btnSolarCollectorAllocate.Name = "btnSolarCollectorAllocate";
            this.btnSolarCollectorAllocate.Size = new System.Drawing.Size(23, 23);
            this.btnSolarCollectorAllocate.TabIndex = 8;
            this.btnSolarCollectorAllocate.Text = "+";
            this.btnSolarCollectorAllocate.UseVisualStyleBackColor = true;
            this.btnSolarCollectorAllocate.Click += new System.EventHandler(this.btnSolarCollectorAllocate_Click);
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Location = new System.Drawing.Point(40, 10);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(34, 20);
            this.txtInput.TabIndex = 9;
            this.txtInput.Text = "1";
            this.txtInput.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtInputLabel
            // 
            this.txtInputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInputLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInputLabel.Location = new System.Drawing.Point(9, 14);
            this.txtInputLabel.Name = "txtInputLabel";
            this.txtInputLabel.ReadOnly = true;
            this.txtInputLabel.Size = new System.Drawing.Size(25, 13);
            this.txtInputLabel.TabIndex = 10;
            this.txtInputLabel.TabStop = false;
            this.txtInputLabel.Text = "Input:";
            // 
            // txtSolarCollectorsEnergyLabel
            // 
            this.txtSolarCollectorsEnergyLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSolarCollectorsEnergyLabel.BackColor = System.Drawing.SystemColors.Control;
            this.txtSolarCollectorsEnergyLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSolarCollectorsEnergyLabel.Location = new System.Drawing.Point(148, 9);
            this.txtSolarCollectorsEnergyLabel.Name = "txtSolarCollectorsEnergyLabel";
            this.txtSolarCollectorsEnergyLabel.ReadOnly = true;
            this.txtSolarCollectorsEnergyLabel.Size = new System.Drawing.Size(26, 13);
            this.txtSolarCollectorsEnergyLabel.TabIndex = 14;
            this.txtSolarCollectorsEnergyLabel.TabStop = false;
            this.txtSolarCollectorsEnergyLabel.Text = "0";
            // 
            // txtSolarCollectorsLevelLabel
            // 
            this.txtSolarCollectorsLevelLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSolarCollectorsLevelLabel.BackColor = System.Drawing.SystemColors.Control;
            this.txtSolarCollectorsLevelLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSolarCollectorsLevelLabel.Location = new System.Drawing.Point(98, 9);
            this.txtSolarCollectorsLevelLabel.Name = "txtSolarCollectorsLevelLabel";
            this.txtSolarCollectorsLevelLabel.ReadOnly = true;
            this.txtSolarCollectorsLevelLabel.Size = new System.Drawing.Size(26, 13);
            this.txtSolarCollectorsLevelLabel.TabIndex = 13;
            this.txtSolarCollectorsLevelLabel.TabStop = false;
            this.txtSolarCollectorsLevelLabel.Text = "0";
            // 
            // grpboxComponents
            // 
            this.grpboxComponents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpboxComponents.Controls.Add(this.panelSolarCollector);
            this.grpboxComponents.Controls.Add(this.txtComponentEnergyLabel);
            this.grpboxComponents.Controls.Add(this.txtComponentLevelLabel);
            this.grpboxComponents.Controls.Add(this.txtComonentNameLabel);
            this.grpboxComponents.Location = new System.Drawing.Point(278, 147);
            this.grpboxComponents.Name = "grpboxComponents";
            this.grpboxComponents.Size = new System.Drawing.Size(314, 381);
            this.grpboxComponents.TabIndex = 15;
            this.grpboxComponents.TabStop = false;
            // 
            // panelSolarCollector
            // 
            this.panelSolarCollector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSolarCollector.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelSolarCollector.Controls.Add(this.txtSolarCollectorsEnergyLabel);
            this.panelSolarCollector.Controls.Add(this.btnSolarCollectorAllocate);
            this.panelSolarCollector.Controls.Add(this.btnSollarCollectorDeallocate);
            this.panelSolarCollector.Controls.Add(this.txtSolarCollectorsLevelLabel);
            this.panelSolarCollector.Controls.Add(this.txtSollarCollectorsComponentLabel);
            this.panelSolarCollector.Location = new System.Drawing.Point(6, 44);
            this.panelSolarCollector.Name = "panelSolarCollector";
            this.panelSolarCollector.Size = new System.Drawing.Size(302, 30);
            this.panelSolarCollector.TabIndex = 16;
            // 
            // txtComponentEnergyLabel
            // 
            this.txtComponentEnergyLabel.BackColor = System.Drawing.SystemColors.Control;
            this.txtComponentEnergyLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComponentEnergyLabel.Location = new System.Drawing.Point(154, 19);
            this.txtComponentEnergyLabel.Name = "txtComponentEnergyLabel";
            this.txtComponentEnergyLabel.ReadOnly = true;
            this.txtComponentEnergyLabel.Size = new System.Drawing.Size(84, 13);
            this.txtComponentEnergyLabel.TabIndex = 17;
            this.txtComponentEnergyLabel.TabStop = false;
            this.txtComponentEnergyLabel.Text = "Energy";
            // 
            // txtComponentLevelLabel
            // 
            this.txtComponentLevelLabel.BackColor = System.Drawing.SystemColors.Control;
            this.txtComponentLevelLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComponentLevelLabel.Location = new System.Drawing.Point(104, 19);
            this.txtComponentLevelLabel.Name = "txtComponentLevelLabel";
            this.txtComponentLevelLabel.ReadOnly = true;
            this.txtComponentLevelLabel.Size = new System.Drawing.Size(44, 13);
            this.txtComponentLevelLabel.TabIndex = 16;
            this.txtComponentLevelLabel.TabStop = false;
            this.txtComponentLevelLabel.Text = "Level";
            // 
            // txtComonentNameLabel
            // 
            this.txtComonentNameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.txtComonentNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComonentNameLabel.Location = new System.Drawing.Point(6, 19);
            this.txtComonentNameLabel.Name = "txtComonentNameLabel";
            this.txtComonentNameLabel.ReadOnly = true;
            this.txtComonentNameLabel.Size = new System.Drawing.Size(84, 13);
            this.txtComonentNameLabel.TabIndex = 15;
            this.txtComonentNameLabel.TabStop = false;
            this.txtComonentNameLabel.Text = "Component";
            // 
            // txtEnergyHoverLabel
            // 
            this.txtEnergyHoverLabel.Location = new System.Drawing.Point(492, 77);
            this.txtEnergyHoverLabel.Multiline = true;
            this.txtEnergyHoverLabel.Name = "txtEnergyHoverLabel";
            this.txtEnergyHoverLabel.ReadOnly = true;
            this.txtEnergyHoverLabel.Size = new System.Drawing.Size(100, 42);
            this.txtEnergyHoverLabel.TabIndex = 16;
            this.txtEnergyHoverLabel.TabStop = false;
            this.txtEnergyHoverLabel.Text = "Your energy per second is: 0";
            this.txtEnergyHoverLabel.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.txtLifeTimeLabel);
            this.groupBox1.Controls.Add(this.txtLifeTime);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Location = new System.Drawing.Point(12, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(92, 381);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // txtLifeTimeLabel
            // 
            this.txtLifeTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLifeTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLifeTimeLabel.Location = new System.Drawing.Point(14, 306);
            this.txtLifeTimeLabel.Name = "txtLifeTimeLabel";
            this.txtLifeTimeLabel.ReadOnly = true;
            this.txtLifeTimeLabel.Size = new System.Drawing.Size(63, 13);
            this.txtLifeTimeLabel.TabIndex = 2;
            this.txtLifeTimeLabel.TabStop = false;
            this.txtLifeTimeLabel.Text = "Current Time:";
            // 
            // txtLifeTime
            // 
            this.txtLifeTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLifeTime.Location = new System.Drawing.Point(23, 326);
            this.txtLifeTime.Name = "txtLifeTime";
            this.txtLifeTime.ReadOnly = true;
            this.txtLifeTime.Size = new System.Drawing.Size(45, 13);
            this.txtLifeTime.TabIndex = 1;
            this.txtLifeTime.TabStop = false;
            this.txtLifeTime.Text = "00:00:00";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(7, 352);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save Game";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupboxStats
            // 
            this.groupboxStats.Controls.Add(this.txtEnergy);
            this.groupboxStats.Location = new System.Drawing.Point(12, 12);
            this.groupboxStats.Name = "groupboxStats";
            this.groupboxStats.Size = new System.Drawing.Size(161, 59);
            this.groupboxStats.TabIndex = 18;
            this.groupboxStats.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtInput);
            this.panel1.Controls.Add(this.txtInputLabel);
            this.panel1.Location = new System.Drawing.Point(509, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(83, 60);
            this.panel1.TabIndex = 19;
            // 
            // timerAutoSave
            // 
            this.timerAutoSave.Interval = 30000;
            this.timerAutoSave.Tick += new System.EventHandler(this.timerAutoSave_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 540);
            this.Controls.Add(this.txtEnergyHoverLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupboxStats);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpboxComponents);
            this.Name = "Form1";
            this.Text = "Test Idle";
            this.grpboxComponents.ResumeLayout(false);
            this.grpboxComponents.PerformLayout();
            this.panelSolarCollector.ResumeLayout(false);
            this.panelSolarCollector.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupboxStats.ResumeLayout(false);
            this.groupboxStats.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerTick;
        private System.Windows.Forms.TextBox txtEnergy;
        private System.Windows.Forms.TextBox txtSollarCollectorsComponentLabel;
        private System.Windows.Forms.Button btnSollarCollectorDeallocate;
        private System.Windows.Forms.Button btnSolarCollectorAllocate;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtInputLabel;
        private System.Windows.Forms.TextBox txtSolarCollectorsEnergyLabel;
        private System.Windows.Forms.TextBox txtSolarCollectorsLevelLabel;
        private System.Windows.Forms.GroupBox grpboxComponents;
        private System.Windows.Forms.TextBox txtComponentEnergyLabel;
        private System.Windows.Forms.TextBox txtComponentLevelLabel;
        private System.Windows.Forms.TextBox txtComonentNameLabel;
        private System.Windows.Forms.Panel panelSolarCollector;
        private System.Windows.Forms.TextBox txtEnergyHoverLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupboxStats;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLifeTime;
        private System.Windows.Forms.TextBox txtLifeTimeLabel;
        private System.Windows.Forms.Timer timerAutoSave;
    }
}

