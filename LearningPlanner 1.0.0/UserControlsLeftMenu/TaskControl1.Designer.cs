namespace LearningPlanner
{
    partial class TaskControl1
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.TaskPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TaskPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TaskPictureBox
            // 
            this.TaskPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TaskPictureBox.Enabled = false;
            this.TaskPictureBox.Image = global::LearningPlanner.Properties.Resources.Task_icon;
            this.TaskPictureBox.Location = new System.Drawing.Point(4, 30);
            this.TaskPictureBox.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.TaskPictureBox.Name = "TaskPictureBox";
            this.TaskPictureBox.Size = new System.Drawing.Size(45, 38);
            this.TaskPictureBox.TabIndex = 1;
            this.TaskPictureBox.TabStop = false;
            // 
            // TaskControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.TaskPictureBox);
            this.Name = "TaskControl1";
            this.Size = new System.Drawing.Size(185, 97);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TaskControl1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.TaskPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox TaskPictureBox;
    }
}
