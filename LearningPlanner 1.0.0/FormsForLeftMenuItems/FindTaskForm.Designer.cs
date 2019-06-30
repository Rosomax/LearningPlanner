namespace LearningPlanner
{
    partial class FindTaskForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FindTaskTextBox = new System.Windows.Forms.TextBox();
            this.FindTaskDataGrid = new System.Windows.Forms.DataGridView();
            this.FindTaskLabel = new System.Windows.Forms.Label();
            this.FilterComboBox = new System.Windows.Forms.ComboBox();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.FilterFrom = new System.Windows.Forms.DateTimePicker();
            this.FilterTo = new System.Windows.Forms.DateTimePicker();
            this.FilterFromLabel = new System.Windows.Forms.Label();
            this.FilterToLabel = new System.Windows.Forms.Label();
            this.FindPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FindTaskDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FindPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FindTaskTextBox
            // 
            this.FindTaskTextBox.Location = new System.Drawing.Point(28, 61);
            this.FindTaskTextBox.Name = "FindTaskTextBox";
            this.FindTaskTextBox.Size = new System.Drawing.Size(192, 20);
            this.FindTaskTextBox.TabIndex = 0;
            this.FindTaskTextBox.TextChanged += new System.EventHandler(this.FindTaskTextBox_TextChanged);
            // 
            // FindTaskDataGrid
            // 
            this.FindTaskDataGrid.AllowUserToResizeColumns = false;
            this.FindTaskDataGrid.AllowUserToResizeRows = false;
            this.FindTaskDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FindTaskDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.FindTaskDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FindTaskDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.FindTaskDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FindTaskDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.FindTaskDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FindTaskDataGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FindTaskDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.FindTaskDataGrid.Dock = System.Windows.Forms.DockStyle.Right;
            this.FindTaskDataGrid.EnableHeadersVisualStyles = false;
            this.FindTaskDataGrid.GridColor = System.Drawing.SystemColors.HotTrack;
            this.FindTaskDataGrid.Location = new System.Drawing.Point(262, 0);
            this.FindTaskDataGrid.Name = "FindTaskDataGrid";
            this.FindTaskDataGrid.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SteelBlue;
            this.FindTaskDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.FindTaskDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FindTaskDataGrid.Size = new System.Drawing.Size(488, 500);
            this.FindTaskDataGrid.TabIndex = 1;
            this.FindTaskDataGrid.DoubleClick += new System.EventHandler(this.FindTaskDataGrid_DoubleClick);
            // 
            // FindTaskLabel
            // 
            this.FindTaskLabel.AutoSize = true;
            this.FindTaskLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FindTaskLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FindTaskLabel.Location = new System.Drawing.Point(24, 39);
            this.FindTaskLabel.Name = "FindTaskLabel";
            this.FindTaskLabel.Size = new System.Drawing.Size(190, 19);
            this.FindTaskLabel.TabIndex = 3;
            this.FindTaskLabel.Text = "Wpisz szukane zadanie:";
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.FormattingEnabled = true;
            this.FilterComboBox.Items.AddRange(new object[] {
            "Nazwa",
            "Opis",
            "Kategoria"});
            this.FilterComboBox.Location = new System.Drawing.Point(28, 135);
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(192, 21);
            this.FilterComboBox.TabIndex = 4;
            this.FilterComboBox.Text = "wybierz...";
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FilterLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FilterLabel.Location = new System.Drawing.Point(24, 113);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(38, 19);
            this.FilterLabel.TabIndex = 5;
            this.FilterLabel.Text = "Filtr:";
            // 
            // FilterFrom
            // 
            this.FilterFrom.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterFrom.Location = new System.Drawing.Point(12, 210);
            this.FilterFrom.Name = "FilterFrom";
            this.FilterFrom.Size = new System.Drawing.Size(232, 22);
            this.FilterFrom.TabIndex = 6;
            this.FilterFrom.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // FilterTo
            // 
            this.FilterTo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterTo.Location = new System.Drawing.Point(12, 265);
            this.FilterTo.Name = "FilterTo";
            this.FilterTo.Size = new System.Drawing.Size(232, 22);
            this.FilterTo.TabIndex = 7;
            // 
            // FilterFromLabel
            // 
            this.FilterFromLabel.AutoSize = true;
            this.FilterFromLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FilterFromLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FilterFromLabel.Location = new System.Drawing.Point(8, 188);
            this.FilterFromLabel.Name = "FilterFromLabel";
            this.FilterFromLabel.Size = new System.Drawing.Size(77, 19);
            this.FilterFromLabel.TabIndex = 8;
            this.FilterFromLabel.Text = "Filtruj od:";
            // 
            // FilterToLabel
            // 
            this.FilterToLabel.AutoSize = true;
            this.FilterToLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FilterToLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FilterToLabel.Location = new System.Drawing.Point(8, 243);
            this.FilterToLabel.Name = "FilterToLabel";
            this.FilterToLabel.Size = new System.Drawing.Size(77, 19);
            this.FilterToLabel.TabIndex = 9;
            this.FilterToLabel.Text = "Filtruj do:";
            // 
            // FindPictureBox
            // 
            this.FindPictureBox.Image = global::LearningPlanner.Properties.Resources.FindPicture;
            this.FindPictureBox.Location = new System.Drawing.Point(44, 358);
            this.FindPictureBox.Name = "FindPictureBox";
            this.FindPictureBox.Size = new System.Drawing.Size(176, 99);
            this.FindPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FindPictureBox.TabIndex = 0;
            this.FindPictureBox.TabStop = false;
            // 
            // FindTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.FindPictureBox);
            this.Controls.Add(this.FilterToLabel);
            this.Controls.Add(this.FilterFromLabel);
            this.Controls.Add(this.FilterTo);
            this.Controls.Add(this.FilterFrom);
            this.Controls.Add(this.FilterLabel);
            this.Controls.Add(this.FilterComboBox);
            this.Controls.Add(this.FindTaskLabel);
            this.Controls.Add(this.FindTaskDataGrid);
            this.Controls.Add(this.FindTaskTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FindTaskForm";
            this.Text = "ZnajdzZadanieForm";
            this.Load += new System.EventHandler(this.FindTaskForm_Load);
            this.SizeChanged += new System.EventHandler(this.FindTaskForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.FindTaskDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FindPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox FindPictureBox;
        public System.Windows.Forms.TextBox FindTaskTextBox;
        public System.Windows.Forms.Label FindTaskLabel;
        public System.Windows.Forms.ComboBox FilterComboBox;
        public System.Windows.Forms.Label FilterLabel;
        public System.Windows.Forms.DateTimePicker FilterFrom;
        public System.Windows.Forms.DateTimePicker FilterTo;
        public System.Windows.Forms.Label FilterFromLabel;
        public System.Windows.Forms.Label FilterToLabel;
        public System.Windows.Forms.DataGridView FindTaskDataGrid;
    }
}