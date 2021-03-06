﻿namespace LearningPlanner
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
            this.SettingsChangeColorLabel = new System.Windows.Forms.Label();
            this.ChangeColorTimer = new System.Windows.Forms.Timer(this.components);
            this.DefaultColorButton = new System.Windows.Forms.Button();
            this.SaveColorChangesButton = new System.Windows.Forms.Button();
            this.RtextBox = new System.Windows.Forms.TextBox();
            this.RtrackBar = new System.Windows.Forms.TrackBar();
            this.GtextBox = new System.Windows.Forms.TextBox();
            this.GtrackBar = new System.Windows.Forms.TrackBar();
            this.BtextBox = new System.Windows.Forms.TextBox();
            this.BtrackBar = new System.Windows.Forms.TrackBar();
            this.BLabel = new System.Windows.Forms.Label();
            this.GLabel = new System.Windows.Forms.Label();
            this.RLabel = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.PlayMusicLabel = new System.Windows.Forms.Label();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ReportErrorButttom = new System.Windows.Forms.Button();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.ChangeFontLabel = new System.Windows.Forms.Label();
            this.AuthorsButton = new System.Windows.Forms.Button();
            this.VerdanaRadioButton = new System.Windows.Forms.RadioButton();
            this.CourierRadioButton = new System.Windows.Forms.RadioButton();
            this.CalibriRadioButton = new System.Windows.Forms.RadioButton();
            this.TimesNewRomanRadioButton = new System.Windows.Forms.RadioButton();
            this.ArialBlackRadioButton = new System.Windows.Forms.RadioButton();
            this.BoldCheckBox = new System.Windows.Forms.CheckBox();
            this.RelaxMusicRadioButton = new System.Windows.Forms.RadioButton();
            this.ClassicMusicRadioButton = new System.Windows.Forms.RadioButton();
            this.CalmMusicRadioButton = new System.Windows.Forms.RadioButton();
            this.BackgroundMusicCheckBox = new System.Windows.Forms.CheckBox();
            this.SoundsPanel = new System.Windows.Forms.Panel();
            this.ChangeFontPanel = new System.Windows.Forms.Panel();
            this.GeneralSettingsLabel = new System.Windows.Forms.Label();
            this.SettingTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RtrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GtrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtrackBar)).BeginInit();
            this.Panel3.SuspendLayout();
            this.SoundsPanel.SuspendLayout();
            this.ChangeFontPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // SettingsChangeColorLabel
            // 
            this.SettingsChangeColorLabel.AutoSize = true;
            this.SettingsChangeColorLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsChangeColorLabel.ForeColor = System.Drawing.Color.Black;
            this.SettingsChangeColorLabel.Location = new System.Drawing.Point(533, 9);
            this.SettingsChangeColorLabel.Name = "SettingsChangeColorLabel";
            this.SettingsChangeColorLabel.Size = new System.Drawing.Size(147, 23);
            this.SettingsChangeColorLabel.TabIndex = 3;
            this.SettingsChangeColorLabel.Text = "Zmiana koloru:";
            // 
            // ChangeColorTimer
            // 
            this.ChangeColorTimer.Enabled = true;
            this.ChangeColorTimer.Interval = 30;
            this.ChangeColorTimer.Tick += new System.EventHandler(this.ChangeColorTimer_Tick);
            // 
            // DefaultColorButton
            // 
            this.DefaultColorButton.BackColor = System.Drawing.Color.RosyBrown;
            this.DefaultColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DefaultColorButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DefaultColorButton.ForeColor = System.Drawing.Color.Black;
            this.DefaultColorButton.Location = new System.Drawing.Point(51, 382);
            this.DefaultColorButton.Name = "DefaultColorButton";
            this.DefaultColorButton.Size = new System.Drawing.Size(136, 62);
            this.DefaultColorButton.TabIndex = 13;
            this.DefaultColorButton.Text = "Ustawienia domyślne";
            this.DefaultColorButton.UseVisualStyleBackColor = false;
            this.DefaultColorButton.Click += new System.EventHandler(this.RestoreDefaultButton_Click);
            // 
            // SaveColorChangesButton
            // 
            this.SaveColorChangesButton.BackColor = System.Drawing.Color.RosyBrown;
            this.SaveColorChangesButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveColorChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveColorChangesButton.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SaveColorChangesButton.ForeColor = System.Drawing.Color.Black;
            this.SaveColorChangesButton.Location = new System.Drawing.Point(504, 191);
            this.SaveColorChangesButton.Name = "SaveColorChangesButton";
            this.SaveColorChangesButton.Size = new System.Drawing.Size(191, 46);
            this.SaveColorChangesButton.TabIndex = 14;
            this.SaveColorChangesButton.Text = "Zapisz";
            this.SaveColorChangesButton.UseVisualStyleBackColor = false;
            this.SaveColorChangesButton.Click += new System.EventHandler(this.SaveColorChangesButton_Click);
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
            this.BLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLabel.ForeColor = System.Drawing.Color.Black;
            this.BLabel.Location = new System.Drawing.Point(690, 131);
            this.BLabel.Name = "BLabel";
            this.BLabel.Size = new System.Drawing.Size(18, 19);
            this.BLabel.TabIndex = 12;
            this.BLabel.Text = "B";
            // 
            // GLabel
            // 
            this.GLabel.AutoSize = true;
            this.GLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GLabel.ForeColor = System.Drawing.Color.Black;
            this.GLabel.Location = new System.Drawing.Point(690, 87);
            this.GLabel.Name = "GLabel";
            this.GLabel.Size = new System.Drawing.Size(22, 19);
            this.GLabel.TabIndex = 11;
            this.GLabel.Text = "G";
            // 
            // RLabel
            // 
            this.RLabel.AutoSize = true;
            this.RLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RLabel.ForeColor = System.Drawing.Color.Black;
            this.RLabel.Location = new System.Drawing.Point(690, 49);
            this.RLabel.Name = "RLabel";
            this.RLabel.Size = new System.Drawing.Size(18, 19);
            this.RLabel.TabIndex = 10;
            this.RLabel.Text = "R";
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.White;
            this.Panel2.Location = new System.Drawing.Point(3, 269);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(750, 3);
            this.Panel2.TabIndex = 16;
            // 
            // PlayMusicLabel
            // 
            this.PlayMusicLabel.AutoSize = true;
            this.PlayMusicLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayMusicLabel.ForeColor = System.Drawing.Color.Black;
            this.PlayMusicLabel.Location = new System.Drawing.Point(80, 7);
            this.PlayMusicLabel.Name = "PlayMusicLabel";
            this.PlayMusicLabel.Size = new System.Drawing.Size(85, 23);
            this.PlayMusicLabel.TabIndex = 17;
            this.PlayMusicLabel.Text = "Dzwięki:";
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.Color.White;
            this.Panel4.Location = new System.Drawing.Point(479, 1);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(3, 540);
            this.Panel4.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(0, 497);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(540, 3);
            this.panel5.TabIndex = 17;
            // 
            // ReportErrorButttom
            // 
            this.ReportErrorButttom.BackColor = System.Drawing.Color.RosyBrown;
            this.ReportErrorButttom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportErrorButttom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportErrorButttom.ForeColor = System.Drawing.Color.Black;
            this.ReportErrorButttom.Location = new System.Drawing.Point(51, 450);
            this.ReportErrorButttom.Name = "ReportErrorButttom";
            this.ReportErrorButttom.Size = new System.Drawing.Size(136, 35);
            this.ReportErrorButttom.TabIndex = 19;
            this.ReportErrorButttom.Text = "Zgłoś błąd";
            this.ReportErrorButttom.UseVisualStyleBackColor = false;
            this.ReportErrorButttom.Click += new System.EventHandler(this.ReportErrorButton_Click);
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.White;
            this.Panel3.Controls.Add(this.panel5);
            this.Panel3.Location = new System.Drawing.Point(233, 1);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(3, 540);
            this.Panel3.TabIndex = 16;
            // 
            // ChangeFontLabel
            // 
            this.ChangeFontLabel.AutoSize = true;
            this.ChangeFontLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeFontLabel.ForeColor = System.Drawing.Color.Black;
            this.ChangeFontLabel.Location = new System.Drawing.Point(31, 10);
            this.ChangeFontLabel.Name = "ChangeFontLabel";
            this.ChangeFontLabel.Size = new System.Drawing.Size(167, 23);
            this.ChangeFontLabel.TabIndex = 23;
            this.ChangeFontLabel.Text = "Zmiana czcionki:";
            // 
            // AuthorsButton
            // 
            this.AuthorsButton.BackColor = System.Drawing.Color.RosyBrown;
            this.AuthorsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthorsButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorsButton.ForeColor = System.Drawing.Color.Black;
            this.AuthorsButton.Location = new System.Drawing.Point(51, 491);
            this.AuthorsButton.Name = "AuthorsButton";
            this.AuthorsButton.Size = new System.Drawing.Size(136, 35);
            this.AuthorsButton.TabIndex = 24;
            this.AuthorsButton.Text = "O autorach";
            this.AuthorsButton.UseVisualStyleBackColor = false;
            this.AuthorsButton.Click += new System.EventHandler(this.AuthorsButton_Click);
            // 
            // VerdanaRadioButton
            // 
            this.VerdanaRadioButton.AutoSize = true;
            this.VerdanaRadioButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerdanaRadioButton.ForeColor = System.Drawing.Color.Black;
            this.VerdanaRadioButton.Location = new System.Drawing.Point(3, 205);
            this.VerdanaRadioButton.Name = "VerdanaRadioButton";
            this.VerdanaRadioButton.Size = new System.Drawing.Size(82, 21);
            this.VerdanaRadioButton.TabIndex = 25;
            this.VerdanaRadioButton.TabStop = true;
            this.VerdanaRadioButton.Text = "Verdana";
            this.VerdanaRadioButton.UseVisualStyleBackColor = true;
            this.VerdanaRadioButton.Click += new System.EventHandler(this.VerdanaRadioButton_Click);
            // 
            // CourierRadioButton
            // 
            this.CourierRadioButton.AutoSize = true;
            this.CourierRadioButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourierRadioButton.ForeColor = System.Drawing.Color.Black;
            this.CourierRadioButton.Location = new System.Drawing.Point(3, 128);
            this.CourierRadioButton.Name = "CourierRadioButton";
            this.CourierRadioButton.Size = new System.Drawing.Size(73, 21);
            this.CourierRadioButton.TabIndex = 26;
            this.CourierRadioButton.TabStop = true;
            this.CourierRadioButton.Text = "Courier";
            this.CourierRadioButton.UseVisualStyleBackColor = true;
            this.CourierRadioButton.Click += new System.EventHandler(this.CourierRadioButton_Click);
            // 
            // CalibriRadioButton
            // 
            this.CalibriRadioButton.AutoSize = true;
            this.CalibriRadioButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalibriRadioButton.ForeColor = System.Drawing.Color.Black;
            this.CalibriRadioButton.Location = new System.Drawing.Point(3, 90);
            this.CalibriRadioButton.Name = "CalibriRadioButton";
            this.CalibriRadioButton.Size = new System.Drawing.Size(68, 21);
            this.CalibriRadioButton.TabIndex = 27;
            this.CalibriRadioButton.TabStop = true;
            this.CalibriRadioButton.Text = "Calibri";
            this.CalibriRadioButton.UseVisualStyleBackColor = true;
            this.CalibriRadioButton.Click += new System.EventHandler(this.CalibriRadioButton_Click);
            // 
            // TimesNewRomanRadioButton
            // 
            this.TimesNewRomanRadioButton.AutoSize = true;
            this.TimesNewRomanRadioButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimesNewRomanRadioButton.ForeColor = System.Drawing.Color.Black;
            this.TimesNewRomanRadioButton.Location = new System.Drawing.Point(3, 165);
            this.TimesNewRomanRadioButton.Name = "TimesNewRomanRadioButton";
            this.TimesNewRomanRadioButton.Size = new System.Drawing.Size(145, 21);
            this.TimesNewRomanRadioButton.TabIndex = 28;
            this.TimesNewRomanRadioButton.TabStop = true;
            this.TimesNewRomanRadioButton.Text = "Times New Roman";
            this.TimesNewRomanRadioButton.UseVisualStyleBackColor = true;
            this.TimesNewRomanRadioButton.Click += new System.EventHandler(this.TimesNewRomanRadioButton_Click);
            // 
            // ArialBlackRadioButton
            // 
            this.ArialBlackRadioButton.AutoSize = true;
            this.ArialBlackRadioButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArialBlackRadioButton.ForeColor = System.Drawing.Color.Black;
            this.ArialBlackRadioButton.Location = new System.Drawing.Point(3, 54);
            this.ArialBlackRadioButton.Name = "ArialBlackRadioButton";
            this.ArialBlackRadioButton.Size = new System.Drawing.Size(54, 21);
            this.ArialBlackRadioButton.TabIndex = 29;
            this.ArialBlackRadioButton.TabStop = true;
            this.ArialBlackRadioButton.Text = "Arial";
            this.ArialBlackRadioButton.UseVisualStyleBackColor = true;
            this.ArialBlackRadioButton.Click += new System.EventHandler(this.ArialBlackRadioButton_Click);
            // 
            // BoldCheckBox
            // 
            this.BoldCheckBox.AutoSize = true;
            this.BoldCheckBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoldCheckBox.ForeColor = System.Drawing.Color.Black;
            this.BoldCheckBox.Location = new System.Drawing.Point(126, 54);
            this.BoldCheckBox.Name = "BoldCheckBox";
            this.BoldCheckBox.Size = new System.Drawing.Size(102, 20);
            this.BoldCheckBox.TabIndex = 30;
            this.BoldCheckBox.Text = "Pogrubiona";
            this.BoldCheckBox.UseVisualStyleBackColor = true;
            this.BoldCheckBox.Click += new System.EventHandler(this.BoldCheckBox_Click);
            // 
            // RelaxMusicRadioButton
            // 
            this.RelaxMusicRadioButton.AutoSize = true;
            this.RelaxMusicRadioButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RelaxMusicRadioButton.ForeColor = System.Drawing.Color.Black;
            this.RelaxMusicRadioButton.Location = new System.Drawing.Point(16, 193);
            this.RelaxMusicRadioButton.Name = "RelaxMusicRadioButton";
            this.RelaxMusicRadioButton.Size = new System.Drawing.Size(109, 21);
            this.RelaxMusicRadioButton.TabIndex = 22;
            this.RelaxMusicRadioButton.TabStop = true;
            this.RelaxMusicRadioButton.Text = "Relaksacyjna";
            this.RelaxMusicRadioButton.UseVisualStyleBackColor = true;
            this.RelaxMusicRadioButton.Visible = false;
            this.RelaxMusicRadioButton.Click += new System.EventHandler(this.RelaxMusicRadioButton_Click);
            // 
            // ClassicMusicRadioButton
            // 
            this.ClassicMusicRadioButton.AutoSize = true;
            this.ClassicMusicRadioButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassicMusicRadioButton.ForeColor = System.Drawing.Color.Black;
            this.ClassicMusicRadioButton.Location = new System.Drawing.Point(16, 145);
            this.ClassicMusicRadioButton.Name = "ClassicMusicRadioButton";
            this.ClassicMusicRadioButton.Size = new System.Drawing.Size(88, 21);
            this.ClassicMusicRadioButton.TabIndex = 21;
            this.ClassicMusicRadioButton.TabStop = true;
            this.ClassicMusicRadioButton.Text = "Klasyczna";
            this.ClassicMusicRadioButton.UseVisualStyleBackColor = true;
            this.ClassicMusicRadioButton.Visible = false;
            this.ClassicMusicRadioButton.Click += new System.EventHandler(this.ClassicMusicRadioButton_Click);
            // 
            // CalmMusicRadioButton
            // 
            this.CalmMusicRadioButton.AutoSize = true;
            this.CalmMusicRadioButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalmMusicRadioButton.ForeColor = System.Drawing.Color.Black;
            this.CalmMusicRadioButton.Location = new System.Drawing.Point(16, 96);
            this.CalmMusicRadioButton.Name = "CalmMusicRadioButton";
            this.CalmMusicRadioButton.Size = new System.Drawing.Size(86, 21);
            this.CalmMusicRadioButton.TabIndex = 20;
            this.CalmMusicRadioButton.TabStop = true;
            this.CalmMusicRadioButton.Text = "Spokojna";
            this.CalmMusicRadioButton.UseVisualStyleBackColor = true;
            this.CalmMusicRadioButton.Visible = false;
            this.CalmMusicRadioButton.Click += new System.EventHandler(this.CalmMusicRadioButton_Click);
            // 
            // BackgroundMusicCheckBox
            // 
            this.BackgroundMusicCheckBox.AutoSize = true;
            this.BackgroundMusicCheckBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackgroundMusicCheckBox.ForeColor = System.Drawing.Color.Black;
            this.BackgroundMusicCheckBox.Location = new System.Drawing.Point(15, 52);
            this.BackgroundMusicCheckBox.Name = "BackgroundMusicCheckBox";
            this.BackgroundMusicCheckBox.Size = new System.Drawing.Size(110, 21);
            this.BackgroundMusicCheckBox.TabIndex = 18;
            this.BackgroundMusicCheckBox.Text = "Muzyka w tle";
            this.BackgroundMusicCheckBox.UseVisualStyleBackColor = true;
            this.BackgroundMusicCheckBox.Click += new System.EventHandler(this.BackgroundMusicCheckBox_Click);
            // 
            // SoundsPanel
            // 
            this.SoundsPanel.Controls.Add(this.BackgroundMusicCheckBox);
            this.SoundsPanel.Controls.Add(this.RelaxMusicRadioButton);
            this.SoundsPanel.Controls.Add(this.CalmMusicRadioButton);
            this.SoundsPanel.Controls.Add(this.ClassicMusicRadioButton);
            this.SoundsPanel.Controls.Add(this.PlayMusicLabel);
            this.SoundsPanel.Location = new System.Drawing.Point(488, 278);
            this.SoundsPanel.Name = "SoundsPanel";
            this.SoundsPanel.Size = new System.Drawing.Size(224, 250);
            this.SoundsPanel.TabIndex = 32;
            // 
            // ChangeFontPanel
            // 
            this.ChangeFontPanel.Controls.Add(this.BoldCheckBox);
            this.ChangeFontPanel.Controls.Add(this.ChangeFontLabel);
            this.ChangeFontPanel.Controls.Add(this.VerdanaRadioButton);
            this.ChangeFontPanel.Controls.Add(this.CalibriRadioButton);
            this.ChangeFontPanel.Controls.Add(this.TimesNewRomanRadioButton);
            this.ChangeFontPanel.Controls.Add(this.CourierRadioButton);
            this.ChangeFontPanel.Controls.Add(this.ArialBlackRadioButton);
            this.ChangeFontPanel.Location = new System.Drawing.Point(242, 278);
            this.ChangeFontPanel.Name = "ChangeFontPanel";
            this.ChangeFontPanel.Size = new System.Drawing.Size(231, 253);
            this.ChangeFontPanel.TabIndex = 33;
            // 
            // GeneralSettingsLabel
            // 
            this.GeneralSettingsLabel.AutoSize = true;
            this.GeneralSettingsLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneralSettingsLabel.ForeColor = System.Drawing.Color.Black;
            this.GeneralSettingsLabel.Location = new System.Drawing.Point(75, 285);
            this.GeneralSettingsLabel.Name = "GeneralSettingsLabel";
            this.GeneralSettingsLabel.Size = new System.Drawing.Size(84, 23);
            this.GeneralSettingsLabel.TabIndex = 23;
            this.GeneralSettingsLabel.Text = "Ogólne:";
            // 
            // SettingTimer
            // 
            this.SettingTimer.Enabled = true;
            this.SettingTimer.Interval = 30;
            this.SettingTimer.Tick += new System.EventHandler(this.SettingTimer_Tick);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(750, 540);
            this.Controls.Add(this.GeneralSettingsLabel);
            this.Controls.Add(this.ChangeFontPanel);
            this.Controls.Add(this.SoundsPanel);
            this.Controls.Add(this.AuthorsButton);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.ReportErrorButttom);
            this.Controls.Add(this.Panel4);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.BLabel);
            this.Controls.Add(this.GLabel);
            this.Controls.Add(this.RLabel);
            this.Controls.Add(this.SaveColorChangesButton);
            this.Controls.Add(this.DefaultColorButton);
            this.Controls.Add(this.BtextBox);
            this.Controls.Add(this.BtrackBar);
            this.Controls.Add(this.GtextBox);
            this.Controls.Add(this.SettingsChangeColorLabel);
            this.Controls.Add(this.RtextBox);
            this.Controls.Add(this.RtrackBar);
            this.Controls.Add(this.GtrackBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "UstawieniaForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SettingsForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.RtrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GtrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtrackBar)).EndInit();
            this.Panel3.ResumeLayout(false);
            this.SoundsPanel.ResumeLayout(false);
            this.SoundsPanel.PerformLayout();
            this.ChangeFontPanel.ResumeLayout(false);
            this.ChangeFontPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label SettingsChangeColorLabel;
        private System.Windows.Forms.Timer ChangeColorTimer;
        private System.Windows.Forms.Button DefaultColorButton;
        private System.Windows.Forms.Button SaveColorChangesButton;
        private System.Windows.Forms.TextBox RtextBox;
        private System.Windows.Forms.TrackBar RtrackBar;
        private System.Windows.Forms.TextBox GtextBox;
        private System.Windows.Forms.TrackBar GtrackBar;
        private System.Windows.Forms.TextBox BtextBox;
        private System.Windows.Forms.TrackBar BtrackBar;
        private System.Windows.Forms.Label BLabel;
        private System.Windows.Forms.Label GLabel;
        private System.Windows.Forms.Label RLabel;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Label PlayMusicLabel;
        private System.Windows.Forms.Panel Panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button ReportErrorButttom;
        private System.Windows.Forms.Label ChangeFontLabel;
        private System.Windows.Forms.Button AuthorsButton;
        private System.Windows.Forms.RadioButton VerdanaRadioButton;
        private System.Windows.Forms.RadioButton CourierRadioButton;
        private System.Windows.Forms.RadioButton CalibriRadioButton;
        private System.Windows.Forms.RadioButton TimesNewRomanRadioButton;
        private System.Windows.Forms.RadioButton ArialBlackRadioButton;
        private System.Windows.Forms.CheckBox BoldCheckBox;
        private System.Windows.Forms.RadioButton RelaxMusicRadioButton;
        private System.Windows.Forms.RadioButton ClassicMusicRadioButton;
        private System.Windows.Forms.RadioButton CalmMusicRadioButton;
        private System.Windows.Forms.CheckBox BackgroundMusicCheckBox;
        public System.Windows.Forms.Panel SoundsPanel;
        private System.Windows.Forms.Panel ChangeFontPanel;
        private System.Windows.Forms.Label GeneralSettingsLabel;
        private System.Windows.Forms.Timer SettingTimer;
        public System.Windows.Forms.Panel Panel3;
    }
}