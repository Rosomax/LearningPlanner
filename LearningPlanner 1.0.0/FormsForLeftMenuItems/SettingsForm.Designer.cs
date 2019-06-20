namespace LearningPlanner_1._0._0
{
    partial class SettingsForm
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.settingChangeColorLabel = new System.Windows.Forms.Label();
            this.ChangeColorTimer = new System.Windows.Forms.Timer(this.components);
            this.defaultColorButton = new System.Windows.Forms.Button();
            this.saveColorChangesButton = new System.Windows.Forms.Button();
            this.RtextBox = new System.Windows.Forms.TextBox();
            this.RtrackBar = new System.Windows.Forms.TrackBar();
            this.GtextBox = new System.Windows.Forms.TextBox();
            this.GtrackBar = new System.Windows.Forms.TrackBar();
            this.BtextBox = new System.Windows.Forms.TextBox();
            this.BtrackBar = new System.Windows.Forms.TrackBar();
            this.BLabel = new System.Windows.Forms.Label();
            this.GLabel = new System.Windows.Forms.Label();
            this.RLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PlayMusicLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BackgroundMusicCheckBox = new System.Windows.Forms.CheckBox();
            this.ReportErrorButttom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RtrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GtrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // settingChangeColorLabel
            // 
            this.settingChangeColorLabel.AutoSize = true;
            this.settingChangeColorLabel.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingChangeColorLabel.ForeColor = System.Drawing.Color.Black;
            this.settingChangeColorLabel.Location = new System.Drawing.Point(510, 9);
            this.settingChangeColorLabel.Name = "settingChangeColorLabel";
            this.settingChangeColorLabel.Size = new System.Drawing.Size(162, 23);
            this.settingChangeColorLabel.TabIndex = 3;
            this.settingChangeColorLabel.Text = "Zmiana koloru:";
            // 
            // ChangeColorTimer
            // 
            this.ChangeColorTimer.Enabled = true;
            this.ChangeColorTimer.Interval = 1;
            this.ChangeColorTimer.Tick += new System.EventHandler(this.ChangeColorTimer_Tick);
            // 
            // defaultColorButton
            // 
            this.defaultColorButton.BackColor = System.Drawing.Color.RosyBrown;
            this.defaultColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.defaultColorButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defaultColorButton.ForeColor = System.Drawing.Color.Black;
            this.defaultColorButton.Location = new System.Drawing.Point(499, 208);
            this.defaultColorButton.Name = "defaultColorButton";
            this.defaultColorButton.Size = new System.Drawing.Size(95, 35);
            this.defaultColorButton.TabIndex = 13;
            this.defaultColorButton.Text = "Domyślny";
            this.defaultColorButton.UseVisualStyleBackColor = false;
            this.defaultColorButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveColorChangesButton
            // 
            this.saveColorChangesButton.BackColor = System.Drawing.Color.RosyBrown;
            this.saveColorChangesButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveColorChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveColorChangesButton.Font = new System.Drawing.Font("Arial", 9.75F);
            this.saveColorChangesButton.ForeColor = System.Drawing.Color.Black;
            this.saveColorChangesButton.Location = new System.Drawing.Point(631, 208);
            this.saveColorChangesButton.Name = "saveColorChangesButton";
            this.saveColorChangesButton.Size = new System.Drawing.Size(95, 35);
            this.saveColorChangesButton.TabIndex = 14;
            this.saveColorChangesButton.Text = "Zapisz";
            this.saveColorChangesButton.UseVisualStyleBackColor = false;
            this.saveColorChangesButton.Click += new System.EventHandler(this.saveColorChangesButton_Click);
            // 
            // RtextBox
            // 
            this.RtextBox.Location = new System.Drawing.Point(619, 49);
            this.RtextBox.Name = "RtextBox";
            this.RtextBox.Size = new System.Drawing.Size(58, 20);
            this.RtextBox.TabIndex = 7;
            this.RtextBox.Text = "138";
            // 
            // RtrackBar
            // 
            this.RtrackBar.Location = new System.Drawing.Point(488, 49);
            this.RtrackBar.Maximum = 255;
            this.RtrackBar.Name = "RtrackBar";
            this.RtrackBar.Size = new System.Drawing.Size(125, 45);
            this.RtrackBar.TabIndex = 4;
            this.RtrackBar.TickFrequency = 10;
            this.RtrackBar.Value = 138;
            // 
            // GtextBox
            // 
            this.GtextBox.Location = new System.Drawing.Point(619, 87);
            this.GtextBox.Name = "GtextBox";
            this.GtextBox.Size = new System.Drawing.Size(58, 20);
            this.GtextBox.TabIndex = 8;
            this.GtextBox.Text = "197";
            // 
            // GtrackBar
            // 
            this.GtrackBar.Location = new System.Drawing.Point(488, 87);
            this.GtrackBar.Maximum = 255;
            this.GtrackBar.Name = "GtrackBar";
            this.GtrackBar.Size = new System.Drawing.Size(125, 45);
            this.GtrackBar.TabIndex = 5;
            this.GtrackBar.TickFrequency = 10;
            this.GtrackBar.Value = 197;
            // 
            // BtextBox
            // 
            this.BtextBox.Location = new System.Drawing.Point(619, 131);
            this.BtextBox.Name = "BtextBox";
            this.BtextBox.Size = new System.Drawing.Size(58, 20);
            this.BtextBox.TabIndex = 9;
            this.BtextBox.Text = "222";
            // 
            // BtrackBar
            // 
            this.BtrackBar.Location = new System.Drawing.Point(488, 131);
            this.BtrackBar.Maximum = 255;
            this.BtrackBar.Name = "BtrackBar";
            this.BtrackBar.Size = new System.Drawing.Size(125, 45);
            this.BtrackBar.TabIndex = 6;
            this.BtrackBar.TickFrequency = 10;
            this.BtrackBar.Value = 222;
            // 
            // BLabel
            // 
            this.BLabel.AutoSize = true;
            this.BLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLabel.ForeColor = System.Drawing.Color.Black;
            this.BLabel.Location = new System.Drawing.Point(692, 131);
            this.BLabel.Name = "BLabel";
            this.BLabel.Size = new System.Drawing.Size(20, 20);
            this.BLabel.TabIndex = 12;
            this.BLabel.Text = "B";
            // 
            // GLabel
            // 
            this.GLabel.AutoSize = true;
            this.GLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GLabel.ForeColor = System.Drawing.Color.Black;
            this.GLabel.Location = new System.Drawing.Point(690, 87);
            this.GLabel.Name = "GLabel";
            this.GLabel.Size = new System.Drawing.Size(22, 20);
            this.GLabel.TabIndex = 11;
            this.GLabel.Text = "G";
            // 
            // RLabel
            // 
            this.RLabel.AutoSize = true;
            this.RLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RLabel.ForeColor = System.Drawing.Color.Black;
            this.RLabel.Location = new System.Drawing.Point(690, 49);
            this.RLabel.Name = "RLabel";
            this.RLabel.Size = new System.Drawing.Size(21, 20);
            this.RLabel.TabIndex = 10;
            this.RLabel.Text = "R";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(481, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 260);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(481, 258);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 3);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(748, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 260);
            this.panel3.TabIndex = 16;
            // 
            // PlayMusicLabel
            // 
            this.PlayMusicLabel.AutoSize = true;
            this.PlayMusicLabel.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayMusicLabel.ForeColor = System.Drawing.Color.Black;
            this.PlayMusicLabel.Location = new System.Drawing.Point(564, 275);
            this.PlayMusicLabel.Name = "PlayMusicLabel";
            this.PlayMusicLabel.Size = new System.Drawing.Size(96, 23);
            this.PlayMusicLabel.TabIndex = 17;
            this.PlayMusicLabel.Text = "Dzwięki:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(481, 261);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 240);
            this.panel4.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(484, 498);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(270, 3);
            this.panel5.TabIndex = 17;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(748, 267);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(3, 240);
            this.panel6.TabIndex = 17;
            // 
            // BackgroundMusicCheckBox
            // 
            this.BackgroundMusicCheckBox.AutoSize = true;
            this.BackgroundMusicCheckBox.ForeColor = System.Drawing.Color.Black;
            this.BackgroundMusicCheckBox.Location = new System.Drawing.Point(499, 311);
            this.BackgroundMusicCheckBox.Name = "BackgroundMusicCheckBox";
            this.BackgroundMusicCheckBox.Size = new System.Drawing.Size(88, 17);
            this.BackgroundMusicCheckBox.TabIndex = 18;
            this.BackgroundMusicCheckBox.Text = "Muzyka w tle";
            this.BackgroundMusicCheckBox.UseVisualStyleBackColor = true;
            this.BackgroundMusicCheckBox.Click += new System.EventHandler(this.BackgroundMusicCheckBox_Click);
            // 
            // ReportErrorButttom
            // 
            this.ReportErrorButttom.BackColor = System.Drawing.Color.RosyBrown;
            this.ReportErrorButttom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportErrorButttom.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportErrorButttom.ForeColor = System.Drawing.Color.Black;
            this.ReportErrorButttom.Location = new System.Drawing.Point(324, 466);
            this.ReportErrorButttom.Name = "ReportErrorButttom";
            this.ReportErrorButttom.Size = new System.Drawing.Size(95, 35);
            this.ReportErrorButttom.TabIndex = 19;
            this.ReportErrorButttom.Text = "Zgłoś Błąd";
            this.ReportErrorButttom.UseVisualStyleBackColor = false;
            this.ReportErrorButttom.Click += new System.EventHandler(this.ReportErrorButttom_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(750, 513);
            this.Controls.Add(this.ReportErrorButttom);
            this.Controls.Add(this.BackgroundMusicCheckBox);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.PlayMusicLabel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BLabel);
            this.Controls.Add(this.GLabel);
            this.Controls.Add(this.RLabel);
            this.Controls.Add(this.saveColorChangesButton);
            this.Controls.Add(this.defaultColorButton);
            this.Controls.Add(this.BtextBox);
            this.Controls.Add(this.BtrackBar);
            this.Controls.Add(this.GtextBox);
            this.Controls.Add(this.settingChangeColorLabel);
            this.Controls.Add(this.RtextBox);
            this.Controls.Add(this.RtrackBar);
            this.Controls.Add(this.GtrackBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SettingsForm";
            this.Text = "UstawieniaForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SettingsForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.RtrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GtrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label settingChangeColorLabel;
        private System.Windows.Forms.Timer ChangeColorTimer;
        private System.Windows.Forms.Button defaultColorButton;
        private System.Windows.Forms.Button saveColorChangesButton;
        private System.Windows.Forms.TextBox RtextBox;
        private System.Windows.Forms.TrackBar RtrackBar;
        private System.Windows.Forms.TextBox GtextBox;
        private System.Windows.Forms.TrackBar GtrackBar;
        private System.Windows.Forms.TextBox BtextBox;
        private System.Windows.Forms.TrackBar BtrackBar;
        private System.Windows.Forms.Label BLabel;
        private System.Windows.Forms.Label GLabel;
        private System.Windows.Forms.Label RLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label PlayMusicLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.CheckBox BackgroundMusicCheckBox;
        private System.Windows.Forms.Button ReportErrorButttom;
    }
}