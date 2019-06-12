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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CompletedTaskDataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CompletedTaskDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CompletedTaskDataGridView1
            // 
            this.CompletedTaskDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CompletedTaskDataGridView1.BackgroundColor = System.Drawing.Color.DarkRed;
            this.CompletedTaskDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CompletedTaskDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CompletedTaskDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CompletedTaskDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompletedTaskDataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CompletedTaskDataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.CompletedTaskDataGridView1.GridColor = System.Drawing.SystemColors.HotTrack;
            this.CompletedTaskDataGridView1.Location = new System.Drawing.Point(232, 0);
            this.CompletedTaskDataGridView1.Name = "CompletedTaskDataGridView1";
            this.CompletedTaskDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CompletedTaskDataGridView1.Size = new System.Drawing.Size(518, 500);
            this.CompletedTaskDataGridView1.TabIndex = 8;
            this.CompletedTaskDataGridView1.DoubleClick += new System.EventHandler(this.CompletedTaskDataGridView1_DoubleClick);
            // 
            // CompletedTasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(750, 500);
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
    }
}