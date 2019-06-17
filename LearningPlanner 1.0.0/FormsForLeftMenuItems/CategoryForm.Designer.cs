namespace LearningPlanner_1._0._0
{
    partial class CategoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chooseCategoryLabel = new System.Windows.Forms.Label();
            this.chooseCategoryDataGrid = new System.Windows.Forms.DataGridView();
            this.chooseTaskDataGrid = new System.Windows.Forms.DataGridView();
            this.chooseTaskLabel = new System.Windows.Forms.Label();
            this.describeTaskLabel = new System.Windows.Forms.Label();
            this.describeTaskRichTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chooseCategoryDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseTaskDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseCategoryLabel
            // 
            this.chooseCategoryLabel.AutoSize = true;
            this.chooseCategoryLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chooseCategoryLabel.ForeColor = System.Drawing.Color.Black;
            this.chooseCategoryLabel.Location = new System.Drawing.Point(12, 9);
            this.chooseCategoryLabel.Name = "chooseCategoryLabel";
            this.chooseCategoryLabel.Size = new System.Drawing.Size(184, 23);
            this.chooseCategoryLabel.TabIndex = 0;
            this.chooseCategoryLabel.Text = "Wybierz Kategorie:";
            // 
            // chooseCategoryDataGrid
            // 
            this.chooseCategoryDataGrid.AllowUserToResizeColumns = false;
            this.chooseCategoryDataGrid.AllowUserToResizeRows = false;
            this.chooseCategoryDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.chooseCategoryDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.chooseCategoryDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chooseCategoryDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.chooseCategoryDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.chooseCategoryDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.chooseCategoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chooseCategoryDataGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.chooseCategoryDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.chooseCategoryDataGrid.EnableHeadersVisualStyles = false;
            this.chooseCategoryDataGrid.GridColor = System.Drawing.SystemColors.HotTrack;
            this.chooseCategoryDataGrid.Location = new System.Drawing.Point(16, 35);
            this.chooseCategoryDataGrid.Name = "chooseCategoryDataGrid";
            this.chooseCategoryDataGrid.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SteelBlue;
            this.chooseCategoryDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.chooseCategoryDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.chooseCategoryDataGrid.Size = new System.Drawing.Size(180, 453);
            this.chooseCategoryDataGrid.TabIndex = 8;
            this.chooseCategoryDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.chooseCategoryDataGrid_CellClick);
            // 
            // chooseTaskDataGrid
            // 
            this.chooseTaskDataGrid.AllowUserToResizeColumns = false;
            this.chooseTaskDataGrid.AllowUserToResizeRows = false;
            this.chooseTaskDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.chooseTaskDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.chooseTaskDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chooseTaskDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.chooseTaskDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.chooseTaskDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.chooseTaskDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chooseTaskDataGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.chooseTaskDataGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.chooseTaskDataGrid.EnableHeadersVisualStyles = false;
            this.chooseTaskDataGrid.GridColor = System.Drawing.SystemColors.HotTrack;
            this.chooseTaskDataGrid.Location = new System.Drawing.Point(252, 35);
            this.chooseTaskDataGrid.Name = "chooseTaskDataGrid";
            this.chooseTaskDataGrid.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SteelBlue;
            this.chooseTaskDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.chooseTaskDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.chooseTaskDataGrid.Size = new System.Drawing.Size(180, 453);
            this.chooseTaskDataGrid.TabIndex = 9;
            this.chooseTaskDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.chooseTaskDataGrid_CellClick);
            // 
            // chooseTaskLabel
            // 
            this.chooseTaskLabel.AutoSize = true;
            this.chooseTaskLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chooseTaskLabel.ForeColor = System.Drawing.Color.Black;
            this.chooseTaskLabel.Location = new System.Drawing.Point(248, 9);
            this.chooseTaskLabel.Name = "chooseTaskLabel";
            this.chooseTaskLabel.Size = new System.Drawing.Size(170, 23);
            this.chooseTaskLabel.TabIndex = 10;
            this.chooseTaskLabel.Text = "Wybierz Zadanie:";
            // 
            // describeTaskLabel
            // 
            this.describeTaskLabel.AutoSize = true;
            this.describeTaskLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.describeTaskLabel.ForeColor = System.Drawing.Color.Black;
            this.describeTaskLabel.Location = new System.Drawing.Point(498, 9);
            this.describeTaskLabel.Name = "describeTaskLabel";
            this.describeTaskLabel.Size = new System.Drawing.Size(140, 23);
            this.describeTaskLabel.TabIndex = 11;
            this.describeTaskLabel.Text = "Opis Zadania:";
            // 
            // describeTaskRichTextBox
            // 
            this.describeTaskRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.describeTaskRichTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.describeTaskRichTextBox.ForeColor = System.Drawing.Color.White;
            this.describeTaskRichTextBox.Location = new System.Drawing.Point(502, 35);
            this.describeTaskRichTextBox.Name = "describeTaskRichTextBox";
            this.describeTaskRichTextBox.ReadOnly = true;
            this.describeTaskRichTextBox.Size = new System.Drawing.Size(166, 453);
            this.describeTaskRichTextBox.TabIndex = 12;
            this.describeTaskRichTextBox.Text = "";
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.describeTaskRichTextBox);
            this.Controls.Add(this.describeTaskLabel);
            this.Controls.Add(this.chooseTaskLabel);
            this.Controls.Add(this.chooseTaskDataGrid);
            this.Controls.Add(this.chooseCategoryDataGrid);
            this.Controls.Add(this.chooseCategoryLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CategoryForm";
            this.Text = "KategorieForm";
            this.Load += new System.EventHandler(this.Category_Load);
            this.SizeChanged += new System.EventHandler(this.CategoryForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.chooseCategoryDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseTaskDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chooseCategoryLabel;
        public System.Windows.Forms.DataGridView chooseCategoryDataGrid;
        public System.Windows.Forms.DataGridView chooseTaskDataGrid;
        private System.Windows.Forms.Label chooseTaskLabel;
        private System.Windows.Forms.Label describeTaskLabel;
        private System.Windows.Forms.RichTextBox describeTaskRichTextBox;
    }
}