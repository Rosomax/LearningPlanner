namespace LearningPlanner_1._0._0
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
            this.LeftMainPanel = new System.Windows.Forms.Panel();
            this.PanelLeftDraw = new System.Windows.Forms.Panel();
            this.TopMainPanel = new System.Windows.Forms.Panel();
            this.learningPlannerLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            this.ustawieniaControl61 = new LearningPlanner_1._0._0.ustawieniaControl6();
            this.ciekawoskiControl51 = new LearningPlanner_1._0._0.ciekawoskiControl5();
            this.znajdzZadanieControl41 = new LearningPlanner_1._0._0.znajdzZadanieControl4();
            this.kategorieControl31 = new LearningPlanner_1._0._0.kategorieControl3();
            this.zakonczoneZadaniaControl21 = new LearningPlanner_1._0._0.zakonczoneZadaniaControl2();
            this.zadaniaControl11 = new LearningPlanner_1._0._0.ZadaniaControl1();
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
            this.LeftMainPanel.Controls.Add(this.zadaniaControl11);
            this.LeftMainPanel.Controls.Add(this.PanelLeftDraw);
            this.LeftMainPanel.Controls.Add(this.ustawieniaControl61);
            this.LeftMainPanel.Controls.Add(this.ciekawoskiControl51);
            this.LeftMainPanel.Controls.Add(this.znajdzZadanieControl41);
            this.LeftMainPanel.Controls.Add(this.kategorieControl31);
            this.LeftMainPanel.Controls.Add(this.zakonczoneZadaniaControl21);
            this.LeftMainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftMainPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftMainPanel.Name = "LeftMainPanel";
            this.LeftMainPanel.Size = new System.Drawing.Size(197, 586);
            this.LeftMainPanel.TabIndex = 0;
            this.LeftMainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LeftMainPanel_Paint);
            // 
            // PanelLeftDraw
            // 
            this.PanelLeftDraw.BackColor = System.Drawing.Color.White;
            this.PanelLeftDraw.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeftDraw.Location = new System.Drawing.Point(0, 0);
            this.PanelLeftDraw.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelLeftDraw.Name = "PanelLeftDraw";
            this.PanelLeftDraw.Size = new System.Drawing.Size(12, 586);
            this.PanelLeftDraw.TabIndex = 6;
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
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 42);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // closePictureBox
            // 
            this.closePictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.closePictureBox.Image = global::LearningPlanner_1._0._0.Properties.Resources.delete_icon;
            this.closePictureBox.Location = new System.Drawing.Point(682, 0);
            this.closePictureBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Size = new System.Drawing.Size(41, 42);
            this.closePictureBox.TabIndex = 0;
            this.closePictureBox.TabStop = false;
            this.closePictureBox.Click += new System.EventHandler(this.closePictureBox_Click);
            // 
            // ustawieniaControl61
            // 
            this.ustawieniaControl61.BackColor = System.Drawing.Color.Transparent;
            this.ustawieniaControl61.Location = new System.Drawing.Point(12, 491);
            this.ustawieniaControl61.Margin = new System.Windows.Forms.Padding(4);
            this.ustawieniaControl61.Name = "ustawieniaControl61";
            this.ustawieniaControl61.Size = new System.Drawing.Size(182, 92);
            this.ustawieniaControl61.TabIndex = 5;
            // 
            // ciekawoskiControl51
            // 
            this.ciekawoskiControl51.BackColor = System.Drawing.Color.Transparent;
            this.ciekawoskiControl51.Location = new System.Drawing.Point(12, 395);
            this.ciekawoskiControl51.Margin = new System.Windows.Forms.Padding(4);
            this.ciekawoskiControl51.Name = "ciekawoskiControl51";
            this.ciekawoskiControl51.Size = new System.Drawing.Size(185, 92);
            this.ciekawoskiControl51.TabIndex = 4;
           
            this.ciekawoskiControl51.Click += new System.EventHandler(this.ciekawoskiControl51_Click);
            // 
            // znajdzZadanieControl41
            // 
            this.znajdzZadanieControl41.BackColor = System.Drawing.Color.Transparent;
            this.znajdzZadanieControl41.Location = new System.Drawing.Point(12, 299);
            this.znajdzZadanieControl41.Margin = new System.Windows.Forms.Padding(4);
            this.znajdzZadanieControl41.Name = "znajdzZadanieControl41";
            this.znajdzZadanieControl41.Size = new System.Drawing.Size(185, 92);
            this.znajdzZadanieControl41.TabIndex = 3;
            // 
            // kategorieControl31
            // 
            this.kategorieControl31.BackColor = System.Drawing.Color.Transparent;
            this.kategorieControl31.Location = new System.Drawing.Point(12, 199);
            this.kategorieControl31.Margin = new System.Windows.Forms.Padding(4);
            this.kategorieControl31.Name = "kategorieControl31";
            this.kategorieControl31.Size = new System.Drawing.Size(185, 92);
            this.kategorieControl31.TabIndex = 2;
            // 
            // zakonczoneZadaniaControl21
            // 
            this.zakonczoneZadaniaControl21.BackColor = System.Drawing.Color.Transparent;
            this.zakonczoneZadaniaControl21.Location = new System.Drawing.Point(12, 101);
            this.zakonczoneZadaniaControl21.Margin = new System.Windows.Forms.Padding(4);
            this.zakonczoneZadaniaControl21.Name = "zakonczoneZadaniaControl21";
            this.zakonczoneZadaniaControl21.Size = new System.Drawing.Size(185, 92);
            this.zakonczoneZadaniaControl21.TabIndex = 1;
            // 
            // zadaniaControl11
            // 
            this.zadaniaControl11.BackColor = System.Drawing.Color.Transparent;
            this.zadaniaControl11.Location = new System.Drawing.Point(12, 0);
            this.zadaniaControl11.Name = "zadaniaControl11";
            this.zadaniaControl11.Size = new System.Drawing.Size(185, 92);
            this.zadaniaControl11.TabIndex = 7;
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
            this.IsMdiContainer = true;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LearningPlanner";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.mainForm_Paint);
            this.LeftMainPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Panel PanelLeftDraw;
        private ZadaniaControl1 zadaniaControl11;
    }
}

