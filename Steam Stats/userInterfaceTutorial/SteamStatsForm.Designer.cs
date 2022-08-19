namespace userInterfaceTutorial
{
    partial class SteamStatsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BrandName = new System.Windows.Forms.Label();
            this.CSGOSelect = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.steamLevelLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.LastOnlineLabel = new System.Windows.Forms.Label();
            this.dateCreatedLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.profilePicBox = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.newUserValue = new System.Windows.Forms.TextBox();
            this.changeUser = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.GameStatsDisplayPanel = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.CSGOSelect);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 533);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::userInterfaceTutorial.Properties.Resources.csgo_icon_42841;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(3, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.BrandName);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(217, 54);
            this.panel6.TabIndex = 0;
            // 
            // BrandName
            // 
            this.BrandName.AutoSize = true;
            this.BrandName.Font = new System.Drawing.Font("Swis721 Ex BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BrandName.Location = new System.Drawing.Point(12, 18);
            this.BrandName.Name = "BrandName";
            this.BrandName.Size = new System.Drawing.Size(175, 25);
            this.BrandName.TabIndex = 2;
            this.BrandName.Text = "GAME STATS";
            // 
            // CSGOSelect
            // 
            this.CSGOSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.CSGOSelect.FlatAppearance.BorderSize = 0;
            this.CSGOSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CSGOSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.CSGOSelect.Location = new System.Drawing.Point(40, 187);
            this.CSGOSelect.Name = "CSGOSelect";
            this.CSGOSelect.Size = new System.Drawing.Size(174, 48);
            this.CSGOSelect.TabIndex = 4;
            this.CSGOSelect.Text = "Counter Strike Global Offensive";
            this.CSGOSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CSGOSelect.UseVisualStyleBackColor = false;
            this.CSGOSelect.Click += new System.EventHandler(this.CSGOSelect_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.steamLevelLabel);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.LastOnlineLabel);
            this.panel2.Controls.Add(this.dateCreatedLabel);
            this.panel2.Controls.Add(this.userNameLabel);
            this.panel2.Controls.Add(this.profilePicBox);
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 128);
            this.panel2.TabIndex = 0;
            // 
            // steamLevelLabel
            // 
            this.steamLevelLabel.AutoSize = true;
            this.steamLevelLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.steamLevelLabel.Location = new System.Drawing.Point(94, 49);
            this.steamLevelLabel.Name = "steamLevelLabel";
            this.steamLevelLabel.Size = new System.Drawing.Size(68, 12);
            this.steamLevelLabel.TabIndex = 4;
            this.steamLevelLabel.Text = "Steam Level";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(217, 1);
            this.panel5.TabIndex = 0;
            // 
            // LastOnlineLabel
            // 
            this.LastOnlineLabel.AutoSize = true;
            this.LastOnlineLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.LastOnlineLabel.Location = new System.Drawing.Point(13, 105);
            this.LastOnlineLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastOnlineLabel.Name = "LastOnlineLabel";
            this.LastOnlineLabel.Size = new System.Drawing.Size(62, 12);
            this.LastOnlineLabel.TabIndex = 3;
            this.LastOnlineLabel.Text = "Last Online";
            // 
            // dateCreatedLabel
            // 
            this.dateCreatedLabel.AutoSize = true;
            this.dateCreatedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.dateCreatedLabel.Location = new System.Drawing.Point(13, 82);
            this.dateCreatedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateCreatedLabel.Name = "dateCreatedLabel";
            this.dateCreatedLabel.Size = new System.Drawing.Size(72, 12);
            this.dateCreatedLabel.TabIndex = 2;
            this.dateCreatedLabel.Text = "Date Created";
            // 
            // userNameLabel
            // 
            this.userNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.userNameLabel.Location = new System.Drawing.Point(93, 31);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(85, 16);
            this.userNameLabel.TabIndex = 1;
            this.userNameLabel.Text = "User Name";
            // 
            // profilePicBox
            // 
            this.profilePicBox.Location = new System.Drawing.Point(13, 12);
            this.profilePicBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.profilePicBox.Name = "profilePicBox";
            this.profilePicBox.Size = new System.Drawing.Size(74, 58);
            this.profilePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePicBox.TabIndex = 0;
            this.profilePicBox.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.newUserValue);
            this.panel3.Controls.Add(this.changeUser);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 493);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(217, 40);
            this.panel3.TabIndex = 1;
            // 
            // newUserValue
            // 
            this.newUserValue.AcceptsTab = true;
            this.newUserValue.BackColor = System.Drawing.SystemColors.Window;
            this.newUserValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newUserValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.newUserValue.Location = new System.Drawing.Point(0, 0);
            this.newUserValue.MaxLength = 32;
            this.newUserValue.Name = "newUserValue";
            this.newUserValue.Size = new System.Drawing.Size(217, 18);
            this.newUserValue.TabIndex = 2;
            // 
            // changeUser
            // 
            this.changeUser.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.changeUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.changeUser.Location = new System.Drawing.Point(0, 17);
            this.changeUser.Name = "changeUser";
            this.changeUser.Size = new System.Drawing.Size(217, 23);
            this.changeUser.TabIndex = 1;
            this.changeUser.Text = "Change User";
            this.changeUser.UseVisualStyleBackColor = false;
            this.changeUser.Click += new System.EventHandler(this.ChangeUser_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.exitButton.Location = new System.Drawing.Point(1065, 8);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(33, 35);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // GameStatsDisplayPanel
            // 
            this.GameStatsDisplayPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.GameStatsDisplayPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GameStatsDisplayPanel.Location = new System.Drawing.Point(217, 53);
            this.GameStatsDisplayPanel.Name = "GameStatsDisplayPanel";
            this.GameStatsDisplayPanel.Size = new System.Drawing.Size(893, 480);
            this.GameStatsDisplayPanel.TabIndex = 2;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MinimizeButton.Location = new System.Drawing.Point(1026, 8);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(33, 35);
            this.MinimizeButton.TabIndex = 3;
            this.MinimizeButton.Text = "-";
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.SettingsButton.Location = new System.Drawing.Point(987, 8);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(33, 35);
            this.SettingsButton.TabIndex = 0;
            this.SettingsButton.Text = "⚙️";
            this.SettingsButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1110, 533);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.GameStatsDisplayPanel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(60, 22);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox profilePicBox;
        private System.Windows.Forms.Label dateCreatedLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox newUserValue;
        private System.Windows.Forms.Button changeUser;
        private System.Windows.Forms.Label LastOnlineLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel GameStatsDisplayPanel;
        private System.Windows.Forms.Label BrandName;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Label steamLevelLabel;
        private System.Windows.Forms.Button CSGOSelect;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

