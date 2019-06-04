namespace LearningPlanner_1._0._0
{
    partial class TaskForm
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
            this.TaskNameTextBox = new System.Windows.Forms.TextBox();
            this.NazwaZadaniaLabel = new System.Windows.Forms.Label();
            this.KategoriaLabel = new System.Windows.Forms.Label();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.OpisLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.TaskDataGridView1 = new System.Windows.Forms.DataGridView();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TaskDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // NazwaZadaniaTextBox
            // 
            this.TaskNameTextBox.BackColor = System.Drawing.Color.White;
            this.TaskNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskNameTextBox.Location = new System.Drawing.Point(65, 66);
            this.TaskNameTextBox.Name = "NazwaZadaniaTextBox";
            this.TaskNameTextBox.Size = new System.Drawing.Size(220, 35);
            this.TaskNameTextBox.TabIndex = 0;
            // 
            // NazwaZadaniaLabel
            // 
            this.NazwaZadaniaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NazwaZadaniaLabel.AutoSize = true;
            this.NazwaZadaniaLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NazwaZadaniaLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NazwaZadaniaLabel.Location = new System.Drawing.Point(59, 32);
            this.NazwaZadaniaLabel.Name = "NazwaZadaniaLabel";
            this.NazwaZadaniaLabel.Size = new System.Drawing.Size(226, 33);
            this.NazwaZadaniaLabel.TabIndex = 1;
            this.NazwaZadaniaLabel.Text = "Nazwa zadania:";
            // 
            // KategoriaLabel
            // 
            this.KategoriaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KategoriaLabel.AutoSize = true;
            this.KategoriaLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KategoriaLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KategoriaLabel.Location = new System.Drawing.Point(59, 117);
            this.KategoriaLabel.Name = "KategoriaLabel";
            this.KategoriaLabel.Size = new System.Drawing.Size(152, 33);
            this.KategoriaLabel.TabIndex = 2;
            this.KategoriaLabel.Text = "Kategoria:";
            // 
            // KategoriaTextBox
            // 
            this.CategoryTextBox.BackColor = System.Drawing.Color.White;
            this.CategoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryTextBox.Location = new System.Drawing.Point(65, 151);
            this.CategoryTextBox.Name = "KategoriaTextBox";
            this.CategoryTextBox.Size = new System.Drawing.Size(220, 35);
            this.CategoryTextBox.TabIndex = 3;
            // 
            // OpisLabel
            // 
            this.OpisLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpisLabel.AutoSize = true;
            this.OpisLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpisLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OpisLabel.Location = new System.Drawing.Point(59, 199);
            this.OpisLabel.Name = "OpisLabel";
            this.OpisLabel.Size = new System.Drawing.Size(79, 33);
            this.OpisLabel.TabIndex = 4;
            this.OpisLabel.Text = "Opis:";
            // 
            // OpisTextBox
            // 
            this.DescriptionTextBox.BackColor = System.Drawing.Color.White;
            this.DescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(65, 233);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "OpisTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(220, 85);
            this.DescriptionTextBox.TabIndex = 5;
            // 
            // ZapiszButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SaveButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SaveButton.Location = new System.Drawing.Point(11, 392);
            this.SaveButton.Name = "ZapiszButton";
            this.SaveButton.Size = new System.Drawing.Size(108, 50);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Zapisz";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ZadaniaDataGridView1
            // 
            this.TaskDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TaskDataGridView1.BackgroundColor = System.Drawing.Color.DarkRed;
            this.TaskDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TaskDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TaskDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TaskDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TaskDataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TaskDataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.TaskDataGridView1.GridColor = System.Drawing.SystemColors.HotTrack;
            this.TaskDataGridView1.Location = new System.Drawing.Point(406, 0);
            this.TaskDataGridView1.Name = "ZadaniaDataGridView1";
            this.TaskDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TaskDataGridView1.Size = new System.Drawing.Size(344, 500);
            this.TaskDataGridView1.TabIndex = 7;
            this.TaskDataGridView1.Click += new System.EventHandler(this.TaskDataGridView1_Click);
            this.TaskDataGridView1.DoubleClick += new System.EventHandler(this.TaskDataGridView1_DoubleClick);
            // 
            // UsunButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.DeleteButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteButton.Location = new System.Drawing.Point(125, 392);
            this.DeleteButton.Name = "UsunButton";
            this.DeleteButton.Size = new System.Drawing.Size(108, 50);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Usuń";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AnulujButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.CancelButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelButton.Location = new System.Drawing.Point(239, 392);
            this.CancelButton.Name = "AnulujButton";
            this.CancelButton.Size = new System.Drawing.Size(108, 50);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Anuluj";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ZadanieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.TaskDataGridView1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.OpisLabel);
            this.Controls.Add(this.CategoryTextBox);
            this.Controls.Add(this.KategoriaLabel);
            this.Controls.Add(this.NazwaZadaniaLabel);
            this.Controls.Add(this.TaskNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ZadanieForm";
            this.Text = "ZadanieForm";
            this.Load += new System.EventHandler(this.TaskForm_Load);
            this.SizeChanged += new System.EventHandler(this.TaskForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.TaskDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TaskNameTextBox;
        private System.Windows.Forms.Label NazwaZadaniaLabel;
        private System.Windows.Forms.Label KategoriaLabel;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.Label OpisLabel;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridView TaskDataGridView1;
        private System.Windows.Forms.Button DeleteButton;
        private new System.Windows.Forms.Button CancelButton;
    }
}