namespace LearningPlanner_1._0._0
{
    partial class CompletedTasksForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CompletedTaskDataGridView1 = new System.Windows.Forms.DataGridView();
            this.CSVExportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CompletedTaskDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CompletedTaskDataGridView1
            // 
            this.CompletedTaskDataGridView1.AllowUserToResizeColumns = false;
            this.CompletedTaskDataGridView1.AllowUserToResizeRows = false;
            this.CompletedTaskDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CompletedTaskDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.CompletedTaskDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompletedTaskDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.CompletedTaskDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CompletedTaskDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.CompletedTaskDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompletedTaskDataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CompletedTaskDataGridView1.DefaultCellStyle = dataGridViewCellStyle22;
            this.CompletedTaskDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompletedTaskDataGridView1.EnableHeadersVisualStyles = false;
            this.CompletedTaskDataGridView1.GridColor = System.Drawing.SystemColors.HotTrack;
            this.CompletedTaskDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.CompletedTaskDataGridView1.Name = "CompletedTaskDataGridView1";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CompletedTaskDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.CompletedTaskDataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.SteelBlue;
            this.CompletedTaskDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.CompletedTaskDataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CompletedTaskDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CompletedTaskDataGridView1.ShowCellToolTips = false;
            this.CompletedTaskDataGridView1.Size = new System.Drawing.Size(750, 500);
            this.CompletedTaskDataGridView1.TabIndex = 8;
            this.CompletedTaskDataGridView1.DoubleClick += new System.EventHandler(this.CompletedTaskDataGridView1_DoubleClick);
            // 
            // CSVExportButton
            // 
            this.CSVExportButton.BackColor = System.Drawing.Color.RosyBrown;
            this.CSVExportButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CSVExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CSVExportButton.Font = new System.Drawing.Font("Arial", 9.75F);
            this.CSVExportButton.ForeColor = System.Drawing.Color.Black;
            this.CSVExportButton.Location = new System.Drawing.Point(606, 452);
            this.CSVExportButton.Name = "CSVExportButton";
            this.CSVExportButton.Size = new System.Drawing.Size(95, 48);
            this.CSVExportButton.TabIndex = 20;
            this.CSVExportButton.Text = "Export do CSV";
            this.CSVExportButton.UseVisualStyleBackColor = false;
            this.CSVExportButton.Click += new System.EventHandler(this.CSVExportButton_Click);
            // 
            // CompletedTasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.CSVExportButton);
            this.Controls.Add(this.CompletedTaskDataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CompletedTasksForm";
            this.Text = "ZakonczoneZadaniaForm";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.CompletedTasksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CompletedTaskDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView CompletedTaskDataGridView1;
        private System.Windows.Forms.Button CSVExportButton;
    }
}