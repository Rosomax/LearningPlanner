namespace LearningPlanner_1._0._0
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
            this.FindTaskTextBox = new System.Windows.Forms.TextBox();
            this.FindTaskDataGrid = new System.Windows.Forms.DataGridView();
            this.FIndTaskLabel = new System.Windows.Forms.Label();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.filtrLabel = new System.Windows.Forms.Label();
            this.filterFrom = new System.Windows.Forms.DateTimePicker();
            this.filterTo = new System.Windows.Forms.DateTimePicker();
            this.filterFromLabel = new System.Windows.Forms.Label();
            this.filterToLabel = new System.Windows.Forms.Label();
            this.findPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FindTaskDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findPictureBox)).BeginInit();
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
            this.FindTaskDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FindTaskDataGrid.BackgroundColor = System.Drawing.Color.DarkRed;
            this.FindTaskDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FindTaskDataGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FindTaskDataGrid.Dock = System.Windows.Forms.DockStyle.Right;
            this.FindTaskDataGrid.GridColor = System.Drawing.SystemColors.HotTrack;
            this.FindTaskDataGrid.Location = new System.Drawing.Point(262, 0);
            this.FindTaskDataGrid.Name = "FindTaskDataGrid";
            this.FindTaskDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FindTaskDataGrid.Size = new System.Drawing.Size(488, 500);
            this.FindTaskDataGrid.TabIndex = 1;
            // 
            // FIndTaskLabel
            // 
            this.FIndTaskLabel.AutoSize = true;
            this.FIndTaskLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FIndTaskLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FIndTaskLabel.Location = new System.Drawing.Point(24, 39);
            this.FIndTaskLabel.Name = "FIndTaskLabel";
            this.FIndTaskLabel.Size = new System.Drawing.Size(186, 19);
            this.FIndTaskLabel.TabIndex = 3;
            this.FIndTaskLabel.Text = "Wpisz szukane zadanie";
            // 
            // filterComboBox
            // 
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Items.AddRange(new object[] {
            "Nazwa",
            "Opis",
            "Kategoria"});
            this.filterComboBox.Location = new System.Drawing.Point(28, 135);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(192, 21);
            this.filterComboBox.TabIndex = 4;
            this.filterComboBox.Text = "                        wybierz...";
            // 
            // filtrLabel
            // 
            this.filtrLabel.AutoSize = true;
            this.filtrLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filtrLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.filtrLabel.Location = new System.Drawing.Point(24, 113);
            this.filtrLabel.Name = "filtrLabel";
            this.filtrLabel.Size = new System.Drawing.Size(38, 19);
            this.filtrLabel.TabIndex = 5;
            this.filtrLabel.Text = "Filtr:";
            // 
            // filterFrom
            // 
            this.filterFrom.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterFrom.Location = new System.Drawing.Point(12, 210);
            this.filterFrom.Name = "filterFrom";
            this.filterFrom.Size = new System.Drawing.Size(232, 22);
            this.filterFrom.TabIndex = 6;
            this.filterFrom.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // filterTo
            // 
            this.filterTo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterTo.Location = new System.Drawing.Point(12, 265);
            this.filterTo.Name = "filterTo";
            this.filterTo.Size = new System.Drawing.Size(232, 22);
            this.filterTo.TabIndex = 7;
            // 
            // filterFromLabel
            // 
            this.filterFromLabel.AutoSize = true;
            this.filterFromLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filterFromLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.filterFromLabel.Location = new System.Drawing.Point(8, 188);
            this.filterFromLabel.Name = "filterFromLabel";
            this.filterFromLabel.Size = new System.Drawing.Size(77, 19);
            this.filterFromLabel.TabIndex = 8;
            this.filterFromLabel.Text = "Filtruj od:";
            // 
            // filterToLabel
            // 
            this.filterToLabel.AutoSize = true;
            this.filterToLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filterToLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.filterToLabel.Location = new System.Drawing.Point(8, 243);
            this.filterToLabel.Name = "filterToLabel";
            this.filterToLabel.Size = new System.Drawing.Size(77, 19);
            this.filterToLabel.TabIndex = 9;
            this.filterToLabel.Text = "Filtruj do:";
            // 
            // findPictureBox
            // 
            this.findPictureBox.Image = global::LearningPlanner_1._0._0.Properties.Resources.FindPicture;
            this.findPictureBox.Location = new System.Drawing.Point(44, 358);
            this.findPictureBox.Name = "findPictureBox";
            this.findPictureBox.Size = new System.Drawing.Size(176, 99);
            this.findPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.findPictureBox.TabIndex = 0;
            this.findPictureBox.TabStop = false;
            // 
            // FindTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.findPictureBox);
            this.Controls.Add(this.filterToLabel);
            this.Controls.Add(this.filterFromLabel);
            this.Controls.Add(this.filterTo);
            this.Controls.Add(this.filterFrom);
            this.Controls.Add(this.filtrLabel);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.FIndTaskLabel);
            this.Controls.Add(this.FindTaskDataGrid);
            this.Controls.Add(this.FindTaskTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FindTaskForm";
            this.Text = "ZnajdzZadanieForm";
            this.Load += new System.EventHandler(this.FindTaskForm_Load);
            this.SizeChanged += new System.EventHandler(this.FindTaskForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.FindTaskDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FindTaskTextBox;
        private System.Windows.Forms.DataGridView FindTaskDataGrid;
        private System.Windows.Forms.Label FIndTaskLabel;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.Label filtrLabel;
        private System.Windows.Forms.DateTimePicker filterFrom;
        private System.Windows.Forms.DateTimePicker filterTo;
        private System.Windows.Forms.Label filterFromLabel;
        private System.Windows.Forms.Label filterToLabel;
        private System.Windows.Forms.PictureBox findPictureBox;
    }
}