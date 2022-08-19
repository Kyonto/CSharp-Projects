namespace userInterfaceTutorial
{
    partial class csgoStatsForm
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
            this.totalKillsLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.totalDeathsLabel = new System.Windows.Forms.Label();
            this.totalPlantedBombsLabel = new System.Windows.Forms.Label();
            this.totalTimePlayedLabel = new System.Windows.Forms.Label();
            this.totalDefusedBombsLabel = new System.Windows.Forms.Label();
            this.totalWinsLabel = new System.Windows.Forms.Label();
            this.totalRescuedHostagesLabel = new System.Windows.Forms.Label();
            this.totalMoneyEarnedLabel = new System.Windows.Forms.Label();
            this.totalDamageDoneLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.totalKnifeKillsLabel = new System.Windows.Forms.Label();
            this.kdRatioLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kdDisplayValueLabel = new System.Windows.Forms.Label();
            this.kdBar = new CircularProgressBar.CircularProgressBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // totalKillsLabel
            // 
            this.totalKillsLabel.AutoSize = true;
            this.totalKillsLabel.Font = new System.Drawing.Font("SansSerif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.totalKillsLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.totalKillsLabel.Location = new System.Drawing.Point(3, 9);
            this.totalKillsLabel.Name = "totalKillsLabel";
            this.totalKillsLabel.Size = new System.Drawing.Size(143, 17);
            this.totalKillsLabel.TabIndex = 0;
            this.totalKillsLabel.Text = "Total Kills: No Data";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IDLabel.Location = new System.Drawing.Point(638, 428);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(24, 13);
            this.IDLabel.TabIndex = 1;
            this.IDLabel.Text = "ID: ";
            this.IDLabel.TextChanged += new System.EventHandler(this.IDLabel_TextChanged);
            // 
            // totalDeathsLabel
            // 
            this.totalDeathsLabel.AutoSize = true;
            this.totalDeathsLabel.Font = new System.Drawing.Font("SansSerif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.totalDeathsLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.totalDeathsLabel.Location = new System.Drawing.Point(3, 26);
            this.totalDeathsLabel.Name = "totalDeathsLabel";
            this.totalDeathsLabel.Size = new System.Drawing.Size(161, 17);
            this.totalDeathsLabel.TabIndex = 2;
            this.totalDeathsLabel.Text = "Total Deaths: No Data";
            // 
            // totalPlantedBombsLabel
            // 
            this.totalPlantedBombsLabel.AutoSize = true;
            this.totalPlantedBombsLabel.Font = new System.Drawing.Font("SansSerif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.totalPlantedBombsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalPlantedBombsLabel.Location = new System.Drawing.Point(509, 249);
            this.totalPlantedBombsLabel.Name = "totalPlantedBombsLabel";
            this.totalPlantedBombsLabel.Size = new System.Drawing.Size(219, 17);
            this.totalPlantedBombsLabel.TabIndex = 3;
            this.totalPlantedBombsLabel.Text = "Total Bombs Planted: No Data";
            // 
            // totalTimePlayedLabel
            // 
            this.totalTimePlayedLabel.AutoSize = true;
            this.totalTimePlayedLabel.Font = new System.Drawing.Font("SansSerif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.totalTimePlayedLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalTimePlayedLabel.Location = new System.Drawing.Point(509, 232);
            this.totalTimePlayedLabel.Name = "totalTimePlayedLabel";
            this.totalTimePlayedLabel.Size = new System.Drawing.Size(197, 17);
            this.totalTimePlayedLabel.TabIndex = 4;
            this.totalTimePlayedLabel.Text = "Total Time Played: No Data";
            // 
            // totalDefusedBombsLabel
            // 
            this.totalDefusedBombsLabel.AutoSize = true;
            this.totalDefusedBombsLabel.Font = new System.Drawing.Font("SansSerif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.totalDefusedBombsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalDefusedBombsLabel.Location = new System.Drawing.Point(509, 266);
            this.totalDefusedBombsLabel.Name = "totalDefusedBombsLabel";
            this.totalDefusedBombsLabel.Size = new System.Drawing.Size(224, 17);
            this.totalDefusedBombsLabel.TabIndex = 5;
            this.totalDefusedBombsLabel.Text = "Total Bombs Defused: No Data";
            // 
            // totalWinsLabel
            // 
            this.totalWinsLabel.AutoSize = true;
            this.totalWinsLabel.Font = new System.Drawing.Font("SansSerif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.totalWinsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalWinsLabel.Location = new System.Drawing.Point(509, 283);
            this.totalWinsLabel.Name = "totalWinsLabel";
            this.totalWinsLabel.Size = new System.Drawing.Size(147, 17);
            this.totalWinsLabel.TabIndex = 6;
            this.totalWinsLabel.Text = "Total Wins: No Data";
            // 
            // totalRescuedHostagesLabel
            // 
            this.totalRescuedHostagesLabel.AutoSize = true;
            this.totalRescuedHostagesLabel.Font = new System.Drawing.Font("SansSerif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.totalRescuedHostagesLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalRescuedHostagesLabel.Location = new System.Drawing.Point(509, 334);
            this.totalRescuedHostagesLabel.Name = "totalRescuedHostagesLabel";
            this.totalRescuedHostagesLabel.Size = new System.Drawing.Size(243, 17);
            this.totalRescuedHostagesLabel.TabIndex = 7;
            this.totalRescuedHostagesLabel.Text = "Total Rescued Hostages: No Data";
            // 
            // totalMoneyEarnedLabel
            // 
            this.totalMoneyEarnedLabel.AutoSize = true;
            this.totalMoneyEarnedLabel.Font = new System.Drawing.Font("SansSerif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.totalMoneyEarnedLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalMoneyEarnedLabel.Location = new System.Drawing.Point(509, 317);
            this.totalMoneyEarnedLabel.Name = "totalMoneyEarnedLabel";
            this.totalMoneyEarnedLabel.Size = new System.Drawing.Size(212, 17);
            this.totalMoneyEarnedLabel.TabIndex = 8;
            this.totalMoneyEarnedLabel.Text = "Total Money Earned: No Data";
            // 
            // totalDamageDoneLabel
            // 
            this.totalDamageDoneLabel.AutoSize = true;
            this.totalDamageDoneLabel.Font = new System.Drawing.Font("SansSerif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.totalDamageDoneLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalDamageDoneLabel.Location = new System.Drawing.Point(509, 300);
            this.totalDamageDoneLabel.Name = "totalDamageDoneLabel";
            this.totalDamageDoneLabel.Size = new System.Drawing.Size(210, 17);
            this.totalDamageDoneLabel.TabIndex = 9;
            this.totalDamageDoneLabel.Text = "Total Damage Done: No Data";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("SansSerif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(509, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Total Deaths: No Data";
            // 
            // totalKnifeKillsLabel
            // 
            this.totalKnifeKillsLabel.AutoSize = true;
            this.totalKnifeKillsLabel.Font = new System.Drawing.Font("SansSerif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.totalKnifeKillsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalKnifeKillsLabel.Location = new System.Drawing.Point(509, 351);
            this.totalKnifeKillsLabel.Name = "totalKnifeKillsLabel";
            this.totalKnifeKillsLabel.Size = new System.Drawing.Size(184, 17);
            this.totalKnifeKillsLabel.TabIndex = 11;
            this.totalKnifeKillsLabel.Text = "Total Knife Kills: No Data";
            // 
            // kdRatioLabel
            // 
            this.kdRatioLabel.AutoSize = true;
            this.kdRatioLabel.Font = new System.Drawing.Font("SansSerif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.kdRatioLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.kdRatioLabel.Location = new System.Drawing.Point(3, 43);
            this.kdRatioLabel.Name = "kdRatioLabel";
            this.kdRatioLabel.Size = new System.Drawing.Size(71, 17);
            this.kdRatioLabel.TabIndex = 12;
            this.kdRatioLabel.Text = "KD Ratio";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.kdDisplayValueLabel);
            this.panel1.Controls.Add(this.kdBar);
            this.panel1.Controls.Add(this.kdRatioLabel);
            this.panel1.Controls.Add(this.totalKillsLabel);
            this.panel1.Controls.Add(this.totalDeathsLabel);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 317);
            this.panel1.TabIndex = 13;
            // 
            // kdDisplayValueLabel
            // 
            this.kdDisplayValueLabel.AutoSize = true;
            this.kdDisplayValueLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kdDisplayValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kdDisplayValueLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kdDisplayValueLabel.Location = new System.Drawing.Point(96, 153);
            this.kdDisplayValueLabel.Name = "kdDisplayValueLabel";
            this.kdDisplayValueLabel.Size = new System.Drawing.Size(91, 55);
            this.kdDisplayValueLabel.TabIndex = 15;
            this.kdDisplayValueLabel.Text = "0.0";
            // 
            // kdBar
            // 
            this.kdBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.kdBar.AnimationSpeed = 500;
            this.kdBar.BackColor = System.Drawing.Color.Transparent;
            this.kdBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.kdBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kdBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kdBar.InnerMargin = 2;
            this.kdBar.InnerWidth = -1;
            this.kdBar.Location = new System.Drawing.Point(41, 70);
            this.kdBar.MarqueeAnimationSpeed = 2000;
            this.kdBar.Maximum = 200;
            this.kdBar.Name = "kdBar";
            this.kdBar.OuterColor = System.Drawing.Color.Gray;
            this.kdBar.OuterMargin = -25;
            this.kdBar.OuterWidth = 17;
            this.kdBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kdBar.ProgressWidth = 25;
            this.kdBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.kdBar.Size = new System.Drawing.Size(193, 230);
            this.kdBar.StartAngle = 270;
            this.kdBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.kdBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.kdBar.SubscriptText = "";
            this.kdBar.SuperscriptColor = System.Drawing.Color.Black;
            this.kdBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.kdBar.SuperscriptText = "";
            this.kdBar.TabIndex = 14;
            this.kdBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.kdBar.Value = 68;
            // 
            // csgoStatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(893, 480);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.totalKnifeKillsLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.totalDamageDoneLabel);
            this.Controls.Add(this.totalMoneyEarnedLabel);
            this.Controls.Add(this.totalRescuedHostagesLabel);
            this.Controls.Add(this.totalWinsLabel);
            this.Controls.Add(this.totalDefusedBombsLabel);
            this.Controls.Add(this.totalTimePlayedLabel);
            this.Controls.Add(this.totalPlantedBombsLabel);
            this.Controls.Add(this.IDLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(893, 480);
            this.MinimumSize = new System.Drawing.Size(893, 480);
            this.Name = "csgoStatsForm";
            this.Text = "csgoStatsForm";
            this.Load += new System.EventHandler(this.csgoStatsForm_Load);
            this.MouseEnter += new System.EventHandler(this.csgoStatsForm_MouseEnter);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalKillsLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label totalDeathsLabel;
        private System.Windows.Forms.Label totalPlantedBombsLabel;
        private System.Windows.Forms.Label totalTimePlayedLabel;
        private System.Windows.Forms.Label totalDefusedBombsLabel;
        private System.Windows.Forms.Label totalWinsLabel;
        private System.Windows.Forms.Label totalRescuedHostagesLabel;
        private System.Windows.Forms.Label totalMoneyEarnedLabel;
        private System.Windows.Forms.Label totalDamageDoneLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label totalKnifeKillsLabel;
        private System.Windows.Forms.Label kdRatioLabel;
        private System.Windows.Forms.Panel panel1;
        private CircularProgressBar.CircularProgressBar kdBar;
        private System.Windows.Forms.Label kdDisplayValueLabel;
    }
}