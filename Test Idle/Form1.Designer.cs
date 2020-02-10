namespace TestIdle
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
            this.txtLeavesOrgan = new System.Windows.Forms.TextBox();
            this.btnLeavesDeallocate = new System.Windows.Forms.Button();
            this.btnLeavesAllocate = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtInputLabel = new System.Windows.Forms.TextBox();
            this.txtLeavesEnergy = new System.Windows.Forms.TextBox();
            this.txtLeavesLevel = new System.Windows.Forms.TextBox();
            this.grpboxOrgans = new System.Windows.Forms.GroupBox();
            this.panelRoots = new System.Windows.Forms.Panel();
            this.txtRootsEnergy = new System.Windows.Forms.TextBox();
            this.btnRootsAllocate = new System.Windows.Forms.Button();
            this.btnRootsDeallocate = new System.Windows.Forms.Button();
            this.txtRootsLevel = new System.Windows.Forms.TextBox();
            this.txtRootsOrgan = new System.Windows.Forms.TextBox();
            this.panelLeaves = new System.Windows.Forms.Panel();
            this.txtComponentEnergyLabel = new System.Windows.Forms.TextBox();
            this.txtComponentLevelLabel = new System.Windows.Forms.TextBox();
            this.txtComonentNameLabel = new System.Windows.Forms.TextBox();
            this.txtEnergyHoverLabel = new System.Windows.Forms.TextBox();
            this.groupMetabuttons = new System.Windows.Forms.GroupBox();
            this.btnPrestige = new System.Windows.Forms.Button();
            this.txtLifeTimeLabel = new System.Windows.Forms.TextBox();
            this.txtLifeTime = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupboxStats = new System.Windows.Forms.GroupBox();
            this.txtMinerals = new System.Windows.Forms.TextBox();
            this.txtWater = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timerAutoSave = new System.Windows.Forms.Timer(this.components);
            this.btnOrgansView = new System.Windows.Forms.Button();
            this.btnHeightView = new System.Windows.Forms.Button();
            this.grpboxOrgans.SuspendLayout();
            this.panelRoots.SuspendLayout();
            this.panelLeaves.SuspendLayout();
            this.groupMetabuttons.SuspendLayout();
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
            // txtLeavesOrgan
            // 
            this.txtLeavesOrgan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtLeavesOrgan.BackColor = System.Drawing.SystemColors.Control;
            this.txtLeavesOrgan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLeavesOrgan.Location = new System.Drawing.Point(8, 9);
            this.txtLeavesOrgan.Name = "txtLeavesOrgan";
            this.txtLeavesOrgan.ReadOnly = true;
            this.txtLeavesOrgan.Size = new System.Drawing.Size(84, 13);
            this.txtLeavesOrgan.TabIndex = 6;
            this.txtLeavesOrgan.TabStop = false;
            this.txtLeavesOrgan.Text = "Leaves";
            // 
            // btnLeavesDeallocate
            // 
            this.btnLeavesDeallocate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLeavesDeallocate.AutoSize = true;
            this.btnLeavesDeallocate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLeavesDeallocate.Location = new System.Drawing.Point(279, 4);
            this.btnLeavesDeallocate.Name = "btnLeavesDeallocate";
            this.btnLeavesDeallocate.Size = new System.Drawing.Size(20, 23);
            this.btnLeavesDeallocate.TabIndex = 7;
            this.btnLeavesDeallocate.Text = "-";
            this.btnLeavesDeallocate.UseVisualStyleBackColor = true;
            this.btnLeavesDeallocate.Click += new System.EventHandler(this.btnLeavesDeallocate_Click);
            // 
            // btnLeavesAllocate
            // 
            this.btnLeavesAllocate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLeavesAllocate.AutoSize = true;
            this.btnLeavesAllocate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLeavesAllocate.Location = new System.Drawing.Point(253, 4);
            this.btnLeavesAllocate.Name = "btnLeavesAllocate";
            this.btnLeavesAllocate.Size = new System.Drawing.Size(23, 23);
            this.btnLeavesAllocate.TabIndex = 8;
            this.btnLeavesAllocate.Text = "+";
            this.btnLeavesAllocate.UseVisualStyleBackColor = true;
            this.btnLeavesAllocate.Click += new System.EventHandler(this.btnLeavesAllocate_Click);
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
            // txtLeavesEnergy
            // 
            this.txtLeavesEnergy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtLeavesEnergy.BackColor = System.Drawing.SystemColors.Control;
            this.txtLeavesEnergy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLeavesEnergy.Location = new System.Drawing.Point(164, 9);
            this.txtLeavesEnergy.Name = "txtLeavesEnergy";
            this.txtLeavesEnergy.ReadOnly = true;
            this.txtLeavesEnergy.Size = new System.Drawing.Size(26, 13);
            this.txtLeavesEnergy.TabIndex = 14;
            this.txtLeavesEnergy.TabStop = false;
            this.txtLeavesEnergy.Text = "0";
            // 
            // txtLeavesLevel
            // 
            this.txtLeavesLevel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtLeavesLevel.BackColor = System.Drawing.SystemColors.Control;
            this.txtLeavesLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLeavesLevel.Location = new System.Drawing.Point(98, 9);
            this.txtLeavesLevel.Name = "txtLeavesLevel";
            this.txtLeavesLevel.ReadOnly = true;
            this.txtLeavesLevel.Size = new System.Drawing.Size(26, 13);
            this.txtLeavesLevel.TabIndex = 13;
            this.txtLeavesLevel.TabStop = false;
            this.txtLeavesLevel.Text = "0";
            // 
            // grpboxOrgans
            // 
            this.grpboxOrgans.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpboxOrgans.Controls.Add(this.panelRoots);
            this.grpboxOrgans.Controls.Add(this.panelLeaves);
            this.grpboxOrgans.Controls.Add(this.txtComponentEnergyLabel);
            this.grpboxOrgans.Controls.Add(this.txtComponentLevelLabel);
            this.grpboxOrgans.Controls.Add(this.txtComonentNameLabel);
            this.grpboxOrgans.Location = new System.Drawing.Point(278, 147);
            this.grpboxOrgans.Name = "grpboxOrgans";
            this.grpboxOrgans.Size = new System.Drawing.Size(314, 381);
            this.grpboxOrgans.TabIndex = 15;
            this.grpboxOrgans.TabStop = false;
            // 
            // panelRoots
            // 
            this.panelRoots.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRoots.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelRoots.Controls.Add(this.txtRootsEnergy);
            this.panelRoots.Controls.Add(this.btnRootsAllocate);
            this.panelRoots.Controls.Add(this.btnRootsDeallocate);
            this.panelRoots.Controls.Add(this.txtRootsLevel);
            this.panelRoots.Controls.Add(this.txtRootsOrgan);
            this.panelRoots.Location = new System.Drawing.Point(6, 77);
            this.panelRoots.Name = "panelRoots";
            this.panelRoots.Size = new System.Drawing.Size(302, 30);
            this.panelRoots.TabIndex = 17;
            // 
            // txtRootsEnergy
            // 
            this.txtRootsEnergy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtRootsEnergy.BackColor = System.Drawing.SystemColors.Control;
            this.txtRootsEnergy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRootsEnergy.Location = new System.Drawing.Point(164, 9);
            this.txtRootsEnergy.Name = "txtRootsEnergy";
            this.txtRootsEnergy.ReadOnly = true;
            this.txtRootsEnergy.Size = new System.Drawing.Size(26, 13);
            this.txtRootsEnergy.TabIndex = 14;
            this.txtRootsEnergy.TabStop = false;
            this.txtRootsEnergy.Text = "0";
            // 
            // btnRootsAllocate
            // 
            this.btnRootsAllocate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRootsAllocate.AutoSize = true;
            this.btnRootsAllocate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRootsAllocate.Location = new System.Drawing.Point(253, 4);
            this.btnRootsAllocate.Name = "btnRootsAllocate";
            this.btnRootsAllocate.Size = new System.Drawing.Size(23, 23);
            this.btnRootsAllocate.TabIndex = 8;
            this.btnRootsAllocate.Text = "+";
            this.btnRootsAllocate.UseVisualStyleBackColor = true;
            this.btnRootsAllocate.Click += new System.EventHandler(this.btnRootsAllocate_Click);
            // 
            // btnRootsDeallocate
            // 
            this.btnRootsDeallocate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRootsDeallocate.AutoSize = true;
            this.btnRootsDeallocate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRootsDeallocate.Location = new System.Drawing.Point(279, 4);
            this.btnRootsDeallocate.Name = "btnRootsDeallocate";
            this.btnRootsDeallocate.Size = new System.Drawing.Size(20, 23);
            this.btnRootsDeallocate.TabIndex = 7;
            this.btnRootsDeallocate.Text = "-";
            this.btnRootsDeallocate.UseVisualStyleBackColor = true;
            this.btnRootsDeallocate.Click += new System.EventHandler(this.btnRootsDeallocate_Click);
            // 
            // txtRootsLevel
            // 
            this.txtRootsLevel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtRootsLevel.BackColor = System.Drawing.SystemColors.Control;
            this.txtRootsLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRootsLevel.Location = new System.Drawing.Point(98, 9);
            this.txtRootsLevel.Name = "txtRootsLevel";
            this.txtRootsLevel.ReadOnly = true;
            this.txtRootsLevel.Size = new System.Drawing.Size(26, 13);
            this.txtRootsLevel.TabIndex = 13;
            this.txtRootsLevel.TabStop = false;
            this.txtRootsLevel.Text = "0";
            // 
            // txtRootsOrgan
            // 
            this.txtRootsOrgan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtRootsOrgan.BackColor = System.Drawing.SystemColors.Control;
            this.txtRootsOrgan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRootsOrgan.Location = new System.Drawing.Point(8, 9);
            this.txtRootsOrgan.Name = "txtRootsOrgan";
            this.txtRootsOrgan.ReadOnly = true;
            this.txtRootsOrgan.Size = new System.Drawing.Size(84, 13);
            this.txtRootsOrgan.TabIndex = 6;
            this.txtRootsOrgan.TabStop = false;
            this.txtRootsOrgan.Text = "Roots";
            // 
            // panelLeaves
            // 
            this.panelLeaves.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLeaves.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelLeaves.Controls.Add(this.txtLeavesEnergy);
            this.panelLeaves.Controls.Add(this.btnLeavesAllocate);
            this.panelLeaves.Controls.Add(this.btnLeavesDeallocate);
            this.panelLeaves.Controls.Add(this.txtLeavesLevel);
            this.panelLeaves.Controls.Add(this.txtLeavesOrgan);
            this.panelLeaves.Location = new System.Drawing.Point(6, 44);
            this.panelLeaves.Name = "panelLeaves";
            this.panelLeaves.Size = new System.Drawing.Size(302, 30);
            this.panelLeaves.TabIndex = 16;
            // 
            // txtComponentEnergyLabel
            // 
            this.txtComponentEnergyLabel.BackColor = System.Drawing.SystemColors.Control;
            this.txtComponentEnergyLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComponentEnergyLabel.Location = new System.Drawing.Point(170, 19);
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
            this.txtComonentNameLabel.Location = new System.Drawing.Point(14, 19);
            this.txtComonentNameLabel.Name = "txtComonentNameLabel";
            this.txtComonentNameLabel.ReadOnly = true;
            this.txtComonentNameLabel.Size = new System.Drawing.Size(84, 13);
            this.txtComonentNameLabel.TabIndex = 15;
            this.txtComonentNameLabel.TabStop = false;
            this.txtComonentNameLabel.Text = "Organ";
            // 
            // txtEnergyHoverLabel
            // 
            this.txtEnergyHoverLabel.Location = new System.Drawing.Point(382, 77);
            this.txtEnergyHoverLabel.Multiline = true;
            this.txtEnergyHoverLabel.Name = "txtEnergyHoverLabel";
            this.txtEnergyHoverLabel.ReadOnly = true;
            this.txtEnergyHoverLabel.Size = new System.Drawing.Size(210, 52);
            this.txtEnergyHoverLabel.TabIndex = 16;
            this.txtEnergyHoverLabel.TabStop = false;
            this.txtEnergyHoverLabel.Text = "Your energy per second is: 0\r\nYour energy cap this prestige is: 00000";
            this.txtEnergyHoverLabel.Visible = false;
            // 
            // groupMetabuttons
            // 
            this.groupMetabuttons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupMetabuttons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupMetabuttons.Controls.Add(this.btnHeightView);
            this.groupMetabuttons.Controls.Add(this.btnOrgansView);
            this.groupMetabuttons.Controls.Add(this.btnPrestige);
            this.groupMetabuttons.Controls.Add(this.txtLifeTimeLabel);
            this.groupMetabuttons.Controls.Add(this.txtLifeTime);
            this.groupMetabuttons.Controls.Add(this.btnSave);
            this.groupMetabuttons.Location = new System.Drawing.Point(12, 147);
            this.groupMetabuttons.Name = "groupMetabuttons";
            this.groupMetabuttons.Size = new System.Drawing.Size(92, 381);
            this.groupMetabuttons.TabIndex = 17;
            this.groupMetabuttons.TabStop = false;
            // 
            // btnPrestige
            // 
            this.btnPrestige.Location = new System.Drawing.Point(8, 277);
            this.btnPrestige.Name = "btnPrestige";
            this.btnPrestige.Size = new System.Drawing.Size(77, 23);
            this.btnPrestige.TabIndex = 3;
            this.btnPrestige.Text = "RESET";
            this.btnPrestige.UseVisualStyleBackColor = true;
            this.btnPrestige.Click += new System.EventHandler(this.btnPrestige_Click);
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
            this.groupboxStats.Controls.Add(this.txtMinerals);
            this.groupboxStats.Controls.Add(this.txtWater);
            this.groupboxStats.Controls.Add(this.txtEnergy);
            this.groupboxStats.Location = new System.Drawing.Point(12, 12);
            this.groupboxStats.Name = "groupboxStats";
            this.groupboxStats.Size = new System.Drawing.Size(161, 97);
            this.groupboxStats.TabIndex = 18;
            this.groupboxStats.TabStop = false;
            this.groupboxStats.Text = "Stats";
            // 
            // txtMinerals
            // 
            this.txtMinerals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMinerals.Location = new System.Drawing.Point(6, 50);
            this.txtMinerals.Name = "txtMinerals";
            this.txtMinerals.ReadOnly = true;
            this.txtMinerals.Size = new System.Drawing.Size(149, 13);
            this.txtMinerals.TabIndex = 7;
            this.txtMinerals.TabStop = false;
            this.txtMinerals.Text = "Minerals: 000000";
            // 
            // txtWater
            // 
            this.txtWater.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWater.Location = new System.Drawing.Point(6, 31);
            this.txtWater.Name = "txtWater";
            this.txtWater.ReadOnly = true;
            this.txtWater.Size = new System.Drawing.Size(149, 13);
            this.txtWater.TabIndex = 6;
            this.txtWater.TabStop = false;
            this.txtWater.Text = "Water: 000000";
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
            this.timerAutoSave.Enabled = true;
            this.timerAutoSave.Interval = 30000;
            this.timerAutoSave.Tick += new System.EventHandler(this.timerAutoSave_Tick);
            // 
            // btnOrgansView
            // 
            this.btnOrgansView.Location = new System.Drawing.Point(7, 8);
            this.btnOrgansView.Name = "btnOrgansView";
            this.btnOrgansView.Size = new System.Drawing.Size(75, 23);
            this.btnOrgansView.TabIndex = 4;
            this.btnOrgansView.Text = "Organs";
            this.btnOrgansView.UseVisualStyleBackColor = true;
            this.btnOrgansView.Click += new System.EventHandler(this.btnOrgansView_Click);
            // 
            // btnHeightView
            // 
            this.btnHeightView.Location = new System.Drawing.Point(7, 37);
            this.btnHeightView.Name = "btnHeightView";
            this.btnHeightView.Size = new System.Drawing.Size(75, 23);
            this.btnHeightView.TabIndex = 5;
            this.btnHeightView.Text = "Height";
            this.btnHeightView.UseVisualStyleBackColor = true;
            this.btnHeightView.Click += new System.EventHandler(this.btnHeightView_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 540);
            this.Controls.Add(this.txtEnergyHoverLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupboxStats);
            this.Controls.Add(this.groupMetabuttons);
            this.Controls.Add(this.grpboxOrgans);
            this.Name = "Form1";
            this.Text = "Test Idle";
            this.grpboxOrgans.ResumeLayout(false);
            this.grpboxOrgans.PerformLayout();
            this.panelRoots.ResumeLayout(false);
            this.panelRoots.PerformLayout();
            this.panelLeaves.ResumeLayout(false);
            this.panelLeaves.PerformLayout();
            this.groupMetabuttons.ResumeLayout(false);
            this.groupMetabuttons.PerformLayout();
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
        private System.Windows.Forms.TextBox txtLeavesOrgan;
        private System.Windows.Forms.Button btnLeavesDeallocate;
        private System.Windows.Forms.Button btnLeavesAllocate;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtInputLabel;
        private System.Windows.Forms.TextBox txtLeavesEnergy;
        private System.Windows.Forms.TextBox txtLeavesLevel;
        private System.Windows.Forms.GroupBox grpboxOrgans;
        private System.Windows.Forms.TextBox txtComponentEnergyLabel;
        private System.Windows.Forms.TextBox txtComponentLevelLabel;
        private System.Windows.Forms.TextBox txtComonentNameLabel;
        private System.Windows.Forms.Panel panelLeaves;
        private System.Windows.Forms.TextBox txtEnergyHoverLabel;
        private System.Windows.Forms.GroupBox groupMetabuttons;
        private System.Windows.Forms.GroupBox groupboxStats;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLifeTime;
        private System.Windows.Forms.TextBox txtLifeTimeLabel;
        private System.Windows.Forms.Timer timerAutoSave;
        private System.Windows.Forms.Button btnPrestige;
        private System.Windows.Forms.TextBox txtWater;
        private System.Windows.Forms.Panel panelRoots;
        private System.Windows.Forms.TextBox txtRootsEnergy;
        private System.Windows.Forms.Button btnRootsAllocate;
        private System.Windows.Forms.Button btnRootsDeallocate;
        private System.Windows.Forms.TextBox txtRootsLevel;
        private System.Windows.Forms.TextBox txtRootsOrgan;
        private System.Windows.Forms.TextBox txtMinerals;
        private System.Windows.Forms.Button btnHeightView;
        private System.Windows.Forms.Button btnOrgansView;
    }
}

