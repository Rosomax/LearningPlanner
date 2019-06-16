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
            this.RtrackBar = new System.Windows.Forms.TrackBar();
            this.GtrackBar = new System.Windows.Forms.TrackBar();
            this.BtrackBar = new System.Windows.Forms.TrackBar();
            this.RtextBox = new System.Windows.Forms.TextBox();
            this.GtextBox = new System.Windows.Forms.TextBox();
            this.BtextBox = new System.Windows.Forms.TextBox();
            this.RLabel = new System.Windows.Forms.Label();
            this.GLabel = new System.Windows.Forms.Label();
            this.BLabel = new System.Windows.Forms.Label();
            this.ChangeColorTimer = new System.Windows.Forms.Timer(this.components);
            this.defaultColorButton = new System.Windows.Forms.Button();
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
            // RtrackBar
            // 
            this.RtrackBar.Location = new System.Drawing.Point(497, 59);
            this.RtrackBar.Maximum = 255;
            this.RtrackBar.Name = "RtrackBar";
            this.RtrackBar.Size = new System.Drawing.Size(125, 45);
            this.RtrackBar.TabIndex = 4;
            this.RtrackBar.TickFrequency = 10;
            this.RtrackBar.Value = 138;
            // 
            // GtrackBar
            // 
            this.GtrackBar.Location = new System.Drawing.Point(497, 98);
            this.GtrackBar.Maximum = 255;
            this.GtrackBar.Name = "GtrackBar";
            this.GtrackBar.Size = new System.Drawing.Size(125, 45);
            this.GtrackBar.TabIndex = 5;
            this.GtrackBar.TickFrequency = 10;
            this.GtrackBar.Value = 197;
            // 
            // BtrackBar
            // 
            this.BtrackBar.Location = new System.Drawing.Point(497, 140);
            this.BtrackBar.Maximum = 255;
            this.BtrackBar.Name = "BtrackBar";
            this.BtrackBar.Size = new System.Drawing.Size(125, 45);
            this.BtrackBar.TabIndex = 6;
            this.BtrackBar.TickFrequency = 10;
            this.BtrackBar.Value = 222;
            // 
            // RtextBox
            // 
            this.RtextBox.Location = new System.Drawing.Point(628, 59);
            this.RtextBox.Name = "RtextBox";
            this.RtextBox.Size = new System.Drawing.Size(58, 20);
            this.RtextBox.TabIndex = 7;
            this.RtextBox.Text = "138";
            // 
            // GtextBox
            // 
            this.GtextBox.Location = new System.Drawing.Point(628, 98);
            this.GtextBox.Name = "GtextBox";
            this.GtextBox.Size = new System.Drawing.Size(58, 20);
            this.GtextBox.TabIndex = 8;
            this.GtextBox.Text = "197";
            // 
            // BtextBox
            // 
            this.BtextBox.Location = new System.Drawing.Point(628, 140);
            this.BtextBox.Name = "BtextBox";
            this.BtextBox.Size = new System.Drawing.Size(58, 20);
            this.BtextBox.TabIndex = 9;
            this.BtextBox.Text = "222";
            // 
            // RLabel
            // 
            this.RLabel.AutoSize = true;
            this.RLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RLabel.Location = new System.Drawing.Point(702, 59);
            this.RLabel.Name = "RLabel";
            this.RLabel.Size = new System.Drawing.Size(21, 20);
            this.RLabel.TabIndex = 10;
            this.RLabel.Text = "R";
            // 
            // GLabel
            // 
            this.GLabel.AutoSize = true;
            this.GLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GLabel.Location = new System.Drawing.Point(702, 98);
            this.GLabel.Name = "GLabel";
            this.GLabel.Size = new System.Drawing.Size(22, 20);
            this.GLabel.TabIndex = 11;
            this.GLabel.Text = "G";
            // 
            // BLabel
            // 
            this.BLabel.AutoSize = true;
            this.BLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLabel.Location = new System.Drawing.Point(704, 140);
            this.BLabel.Name = "BLabel";
            this.BLabel.Size = new System.Drawing.Size(20, 20);
            this.BLabel.TabIndex = 12;
            this.BLabel.Text = "B";
            // 
            // ChangeColorTimer
            // 
            this.ChangeColorTimer.Enabled = true;
            this.ChangeColorTimer.Interval = 1;
            this.ChangeColorTimer.Tick += new System.EventHandler(this.ChangeColorTimer_Tick);
            // 
            // defaultColorButton
            // 
            this.defaultColorButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defaultColorButton.ForeColor = System.Drawing.Color.Black;
            this.defaultColorButton.Location = new System.Drawing.Point(617, 182);
            this.defaultColorButton.Name = "defaultColorButton";
            this.defaultColorButton.Size = new System.Drawing.Size(95, 36);
            this.defaultColorButton.TabIndex = 13;
            this.defaultColorButton.Text = "Domyślny";
            this.defaultColorButton.UseVisualStyleBackColor = true;
            this.defaultColorButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.defaultColorButton);
            this.Controls.Add(this.BLabel);
            this.Controls.Add(this.GLabel);
            this.Controls.Add(this.RLabel);
            this.Controls.Add(this.BtextBox);
            this.Controls.Add(this.GtextBox);
            this.Controls.Add(this.RtextBox);
            this.Controls.Add(this.BtrackBar);
            this.Controls.Add(this.GtrackBar);
            this.Controls.Add(this.RtrackBar);
            this.Controls.Add(this.settingChangeColorLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SettingsForm";
            this.Text = "UstawieniaForm";
            this.Deactivate += new System.EventHandler(this.SettingsForm_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
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
        private System.Windows.Forms.TrackBar GtrackBar;
        private System.Windows.Forms.TrackBar BtrackBar;
        private System.Windows.Forms.TextBox RtextBox;
        private System.Windows.Forms.TextBox GtextBox;
        private System.Windows.Forms.TextBox BtextBox;
        private System.Windows.Forms.Label RLabel;
        private System.Windows.Forms.Label GLabel;
        private System.Windows.Forms.Label BLabel;
        private System.Windows.Forms.Timer ChangeColorTimer;
        private System.Windows.Forms.TrackBar RtrackBar;
        private System.Windows.Forms.Button defaultColorButton;
    }
}