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
            this.FindTaskButton = new System.Windows.Forms.Button();
            this.FIndTaskLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FindTaskDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // FindTaskTextBox
            // 
            this.FindTaskTextBox.Location = new System.Drawing.Point(24, 73);
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
            this.FindTaskDataGrid.Dock = System.Windows.Forms.DockStyle.Right;
            this.FindTaskDataGrid.Location = new System.Drawing.Point(262, 0);
            this.FindTaskDataGrid.Name = "FindTaskDataGrid";
            this.FindTaskDataGrid.Size = new System.Drawing.Size(488, 500);
            this.FindTaskDataGrid.TabIndex = 1;
            // 
            // FindTaskButton
            // 
            this.FindTaskButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FindTaskButton.Location = new System.Drawing.Point(65, 111);
            this.FindTaskButton.Name = "FindTaskButton";
            this.FindTaskButton.Size = new System.Drawing.Size(100, 29);
            this.FindTaskButton.TabIndex = 2;
            this.FindTaskButton.Text = "Znajdź";
            this.FindTaskButton.UseVisualStyleBackColor = true;
            this.FindTaskButton.Click += new System.EventHandler(this.FindTaskButton_Click);
            // 
            // FIndTaskLabel
            // 
            this.FIndTaskLabel.AutoSize = true;
            this.FIndTaskLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FIndTaskLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FIndTaskLabel.Location = new System.Drawing.Point(20, 40);
            this.FIndTaskLabel.Name = "FIndTaskLabel";
            this.FIndTaskLabel.Size = new System.Drawing.Size(186, 19);
            this.FIndTaskLabel.TabIndex = 3;
            this.FIndTaskLabel.Text = "Wpisz szukane zadanie";
            // 
            // FindTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.FIndTaskLabel);
            this.Controls.Add(this.FindTaskButton);
            this.Controls.Add(this.FindTaskDataGrid);
            this.Controls.Add(this.FindTaskTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FindTaskForm";
            this.Text = "ZnajdzZadanieForm";
            this.Load += new System.EventHandler(this.FindTaskForm_Load);
            this.SizeChanged += new System.EventHandler(this.FindTaskForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.FindTaskDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FindTaskTextBox;
        private System.Windows.Forms.DataGridView FindTaskDataGrid;
        private System.Windows.Forms.Button FindTaskButton;
        private System.Windows.Forms.Label FIndTaskLabel;
    }
}