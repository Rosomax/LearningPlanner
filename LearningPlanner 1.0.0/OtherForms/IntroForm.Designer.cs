namespace LearningPlanner
{
    partial class IntroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroForm));
            this.introUserControl1 = new LearningPlanner.QuotationControl();
            this.OkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // introUserControl1
            // 
            this.introUserControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("introUserControl1.BackgroundImage")));
            this.introUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.introUserControl1.Location = new System.Drawing.Point(0, 0);
            this.introUserControl1.Name = "introUserControl1";
            this.introUserControl1.Size = new System.Drawing.Size(904, 478);
            this.introUserControl1.TabIndex = 0;
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.Color.DimGray;
            this.OkButton.FlatAppearance.BorderSize = 0;
            this.OkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OkButton.Location = new System.Drawing.Point(403, 395);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(112, 40);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK!";
            this.OkButton.UseCompatibleTextRendering = true;
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.Visible = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // IntroForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 478);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.introUserControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IntroForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IntroForm1";
            this.ResumeLayout(false);

        }

        #endregion

        private QuotationControl introUserControl1;
        private System.Windows.Forms.Button OkButton;
    }
}