﻿namespace LearningPlanner_1._0._0
{
    partial class mainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.LeftMainPanel = new System.Windows.Forms.Panel();
            this.TopMainPanel = new System.Windows.Forms.Panel();
            this.learningPlannerLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            this.zakonczoneZadaniaControl21 = new LearningPlanner_1._0._0.zakonczoneZadaniaControl2();
            this.leftActiveControl6 = new LearningPlanner_1._0._0.LeftActiveControl();
            this.leftActiveControl5 = new LearningPlanner_1._0._0.LeftActiveControl();
            this.leftActiveControl4 = new LearningPlanner_1._0._0.LeftActiveControl();
            this.leftActiveControl3 = new LearningPlanner_1._0._0.LeftActiveControl();
            this.leftActiveControl2 = new LearningPlanner_1._0._0.LeftActiveControl();
            this.leftActiveControl1 = new LearningPlanner_1._0._0.LeftActiveControl();
            this.zadaniaControl11 = new LearningPlanner_1._0._0.ZadaniaControl1();
            this.ustawieniaControl61 = new LearningPlanner_1._0._0.ustawieniaControl6();
            this.ciekawoskiControl51 = new LearningPlanner_1._0._0.ciekawoskiControl5();
            this.znajdzZadanieControl41 = new LearningPlanner_1._0._0.znajdzZadanieControl4();
            this.kategorieControl31 = new LearningPlanner_1._0._0.kategorieControl3();
            this.LeftMainPanel.SuspendLayout();
            this.TopMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftMainPanel
            // 
            this.LeftMainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.LeftMainPanel.Controls.Add(this.zakonczoneZadaniaControl21);
            this.LeftMainPanel.Controls.Add(this.leftActiveControl6);
            this.LeftMainPanel.Controls.Add(this.leftActiveControl5);
            this.LeftMainPanel.Controls.Add(this.leftActiveControl4);
            this.LeftMainPanel.Controls.Add(this.leftActiveControl3);
            this.LeftMainPanel.Controls.Add(this.leftActiveControl2);
            this.LeftMainPanel.Controls.Add(this.leftActiveControl1);
            this.LeftMainPanel.Controls.Add(this.zadaniaControl11);
            this.LeftMainPanel.Controls.Add(this.ustawieniaControl61);
            this.LeftMainPanel.Controls.Add(this.ciekawoskiControl51);
            this.LeftMainPanel.Controls.Add(this.znajdzZadanieControl41);
            this.LeftMainPanel.Controls.Add(this.kategorieControl31);
            this.LeftMainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftMainPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftMainPanel.Name = "LeftMainPanel";
            this.LeftMainPanel.Size = new System.Drawing.Size(197, 586);
            this.LeftMainPanel.TabIndex = 0;
            // 
            // TopMainPanel
            // 
            this.TopMainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.TopMainPanel.Controls.Add(this.learningPlannerLabel);
            this.TopMainPanel.Controls.Add(this.pictureBox2);
            this.TopMainPanel.Controls.Add(this.pictureBox1);
            this.TopMainPanel.Controls.Add(this.closePictureBox);
            this.TopMainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopMainPanel.Location = new System.Drawing.Point(197, 0);
            this.TopMainPanel.Name = "TopMainPanel";
            this.TopMainPanel.Size = new System.Drawing.Size(723, 42);
            this.TopMainPanel.TabIndex = 1;
            // 
            // learningPlannerLabel
            // 
            this.learningPlannerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.learningPlannerLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.learningPlannerLabel.ForeColor = System.Drawing.Color.Black;
            this.learningPlannerLabel.Location = new System.Drawing.Point(0, 0);
            this.learningPlannerLabel.Name = "learningPlannerLabel";
            this.learningPlannerLabel.Size = new System.Drawing.Size(600, 42);
            this.learningPlannerLabel.TabIndex = 4;
            this.learningPlannerLabel.Text = "Learning Planner";
            this.learningPlannerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.learningPlannerLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.learningPlannerLabel_MouseDown);
            this.learningPlannerLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.learningPlannerLabel_MouseMove);
            this.learningPlannerLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.learningPlannerLabel_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::LearningPlanner_1._0._0.Properties.Resources.stronaGlowna_icon;
            this.pictureBox2.Location = new System.Drawing.Point(600, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 42);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::LearningPlanner_1._0._0.Properties.Resources.info_icon;
            this.pictureBox1.Location = new System.Drawing.Point(641, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 42);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // closePictureBox
            // 
            this.closePictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.closePictureBox.Image = global::LearningPlanner_1._0._0.Properties.Resources.delete_icon;
            this.closePictureBox.Location = new System.Drawing.Point(682, 0);
            this.closePictureBox.Margin = new System.Windows.Forms.Padding(5);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Size = new System.Drawing.Size(41, 42);
            this.closePictureBox.TabIndex = 0;
            this.closePictureBox.TabStop = false;
            this.closePictureBox.Click += new System.EventHandler(this.closePictureBox_Click);
            // 
            // zakonczoneZadaniaControl21
            // 
            this.zakonczoneZadaniaControl21.AutoSize = true;
            this.zakonczoneZadaniaControl21.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.zakonczoneZadaniaControl21.BackColor = System.Drawing.Color.Transparent;
            this.zakonczoneZadaniaControl21.Location = new System.Drawing.Point(12, 97);
            this.zakonczoneZadaniaControl21.Margin = new System.Windows.Forms.Padding(4);
            this.zakonczoneZadaniaControl21.Name = "zakonczoneZadaniaControl21";
            this.zakonczoneZadaniaControl21.Size = new System.Drawing.Size(185, 97);
            this.zakonczoneZadaniaControl21.TabIndex = 1;
            this.zakonczoneZadaniaControl21.MouseClick += new System.Windows.Forms.MouseEventHandler(this.zakonczoneZadaniaControl21_MouseClick);
            this.zakonczoneZadaniaControl21.MouseEnter += new System.EventHandler(this.zakonczoneZadaniaControl21_MouseEnter);
            this.zakonczoneZadaniaControl21.MouseLeave += new System.EventHandler(this.zakonczoneZadaniaControl21_MouseLeave);
            // 
            // leftActiveControl6
            // 
            this.leftActiveControl6.BackColor = System.Drawing.Color.Transparent;
            this.leftActiveControl6.Location = new System.Drawing.Point(0, 477);
            this.leftActiveControl6.Margin = new System.Windows.Forms.Padding(4);
            this.leftActiveControl6.Name = "leftActiveControl6";
            this.leftActiveControl6.Size = new System.Drawing.Size(12, 109);
            this.leftActiveControl6.TabIndex = 13;
            // 
            // leftActiveControl5
            // 
            this.leftActiveControl5.BackColor = System.Drawing.Color.Transparent;
            this.leftActiveControl5.Location = new System.Drawing.Point(0, 388);
            this.leftActiveControl5.Margin = new System.Windows.Forms.Padding(4);
            this.leftActiveControl5.Name = "leftActiveControl5";
            this.leftActiveControl5.Size = new System.Drawing.Size(12, 97);
            this.leftActiveControl5.TabIndex = 12;
            // 
            // leftActiveControl4
            // 
            this.leftActiveControl4.BackColor = System.Drawing.Color.Transparent;
            this.leftActiveControl4.Location = new System.Drawing.Point(0, 291);
            this.leftActiveControl4.Margin = new System.Windows.Forms.Padding(4);
            this.leftActiveControl4.Name = "leftActiveControl4";
            this.leftActiveControl4.Size = new System.Drawing.Size(12, 97);
            this.leftActiveControl4.TabIndex = 11;
            // 
            // leftActiveControl3
            // 
            this.leftActiveControl3.BackColor = System.Drawing.Color.Transparent;
            this.leftActiveControl3.Location = new System.Drawing.Point(0, 194);
            this.leftActiveControl3.Margin = new System.Windows.Forms.Padding(4);
            this.leftActiveControl3.Name = "leftActiveControl3";
            this.leftActiveControl3.Size = new System.Drawing.Size(12, 97);
            this.leftActiveControl3.TabIndex = 10;
            // 
            // leftActiveControl2
            // 
            this.leftActiveControl2.BackColor = System.Drawing.Color.Transparent;
            this.leftActiveControl2.Location = new System.Drawing.Point(0, 97);
            this.leftActiveControl2.Margin = new System.Windows.Forms.Padding(4);
            this.leftActiveControl2.Name = "leftActiveControl2";
            this.leftActiveControl2.Size = new System.Drawing.Size(12, 97);
            this.leftActiveControl2.TabIndex = 9;
            // 
            // leftActiveControl1
            // 
            this.leftActiveControl1.BackColor = System.Drawing.Color.Transparent;
            this.leftActiveControl1.Location = new System.Drawing.Point(0, 0);
            this.leftActiveControl1.Margin = new System.Windows.Forms.Padding(4);
            this.leftActiveControl1.Name = "leftActiveControl1";
            this.leftActiveControl1.Size = new System.Drawing.Size(12, 97);
            this.leftActiveControl1.TabIndex = 8;
            // 
            // zadaniaControl11
            // 
            this.zadaniaControl11.BackColor = System.Drawing.Color.Transparent;
            this.zadaniaControl11.Location = new System.Drawing.Point(12, 0);
            this.zadaniaControl11.Margin = new System.Windows.Forms.Padding(4);
            this.zadaniaControl11.Name = "zadaniaControl11";
            this.zadaniaControl11.Size = new System.Drawing.Size(185, 97);
            this.zadaniaControl11.TabIndex = 7;
            this.zadaniaControl11.MouseClick += new System.Windows.Forms.MouseEventHandler(this.zadaniaControl11_MouseClick);
            this.zadaniaControl11.MouseEnter += new System.EventHandler(this.zadaniaControl11_MouseEnter_1);
            this.zadaniaControl11.MouseLeave += new System.EventHandler(this.zadaniaControl11_MouseLeave);
            // 
            // ustawieniaControl61
            // 
            this.ustawieniaControl61.BackColor = System.Drawing.Color.Transparent;
            this.ustawieniaControl61.Location = new System.Drawing.Point(12, 485);
            this.ustawieniaControl61.Margin = new System.Windows.Forms.Padding(4);
            this.ustawieniaControl61.Name = "ustawieniaControl61";
            this.ustawieniaControl61.Size = new System.Drawing.Size(185, 101);
            this.ustawieniaControl61.TabIndex = 5;
            this.ustawieniaControl61.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ustawieniaControl61_MouseClick);
            this.ustawieniaControl61.MouseEnter += new System.EventHandler(this.ustawieniaControl61_MouseEnter);
            this.ustawieniaControl61.MouseLeave += new System.EventHandler(this.ustawieniaControl61_MouseLeave);
            // 
            // ciekawoskiControl51
            // 
            this.ciekawoskiControl51.BackColor = System.Drawing.Color.Transparent;
            this.ciekawoskiControl51.Location = new System.Drawing.Point(12, 388);
            this.ciekawoskiControl51.Margin = new System.Windows.Forms.Padding(4);
            this.ciekawoskiControl51.Name = "ciekawoskiControl51";
            this.ciekawoskiControl51.Size = new System.Drawing.Size(185, 97);
            this.ciekawoskiControl51.TabIndex = 4;
            this.ciekawoskiControl51.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ciekawoskiControl51_MouseClick);
            this.ciekawoskiControl51.MouseEnter += new System.EventHandler(this.ciekawoskiControl51_MouseEnter);
            this.ciekawoskiControl51.MouseLeave += new System.EventHandler(this.ciekawoskiControl51_MouseLeave);
            // 
            // znajdzZadanieControl41
            // 
            this.znajdzZadanieControl41.BackColor = System.Drawing.Color.Transparent;
            this.znajdzZadanieControl41.Location = new System.Drawing.Point(12, 291);
            this.znajdzZadanieControl41.Margin = new System.Windows.Forms.Padding(4);
            this.znajdzZadanieControl41.Name = "znajdzZadanieControl41";
            this.znajdzZadanieControl41.Size = new System.Drawing.Size(185, 97);
            this.znajdzZadanieControl41.TabIndex = 3;
            this.znajdzZadanieControl41.MouseClick += new System.Windows.Forms.MouseEventHandler(this.znajdzZadanieControl41_MouseClick);
            this.znajdzZadanieControl41.MouseEnter += new System.EventHandler(this.znajdzZadanieControl41_MouseEnter);
            this.znajdzZadanieControl41.MouseLeave += new System.EventHandler(this.znajdzZadanieControl41_MouseLeave);
            // 
            // kategorieControl31
            // 
            this.kategorieControl31.BackColor = System.Drawing.Color.Transparent;
            this.kategorieControl31.Location = new System.Drawing.Point(12, 194);
            this.kategorieControl31.Margin = new System.Windows.Forms.Padding(4);
            this.kategorieControl31.Name = "kategorieControl31";
            this.kategorieControl31.Size = new System.Drawing.Size(185, 97);
            this.kategorieControl31.TabIndex = 2;
            this.kategorieControl31.MouseClick += new System.Windows.Forms.MouseEventHandler(this.kategorieControl31_MouseClick);
            this.kategorieControl31.MouseEnter += new System.EventHandler(this.kategorieControl31_MouseEnter);
            this.kategorieControl31.MouseLeave += new System.EventHandler(this.kategorieControl31_MouseLeave);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(920, 586);
            this.Controls.Add(this.TopMainPanel);
            this.Controls.Add(this.LeftMainPanel);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LearningPlanner";
            this.LeftMainPanel.ResumeLayout(false);
            this.LeftMainPanel.PerformLayout();
            this.TopMainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftMainPanel;
        private System.Windows.Forms.Panel TopMainPanel;
        private zakonczoneZadaniaControl2 zakonczoneZadaniaControl21;
        private kategorieControl3 kategorieControl31;
        private znajdzZadanieControl4 znajdzZadanieControl41;
        private ciekawoskiControl5 ciekawoskiControl51;
        private ustawieniaControl6 ustawieniaControl61;
        private System.Windows.Forms.PictureBox closePictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label learningPlannerLabel;
        private ZadaniaControl1 zadaniaControl11;
        private LeftActiveControl leftActiveControl6;
        private LeftActiveControl leftActiveControl5;
        private LeftActiveControl leftActiveControl4;
        private LeftActiveControl leftActiveControl3;
        private LeftActiveControl leftActiveControl2;
        private LeftActiveControl leftActiveControl1;
    }
}

