namespace LearningPlanner
{
    partial class CompletedTaskControl2
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
            this.CompletedTaskPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CompletedTaskPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CompletedTaskPictureBox
            // 
            this.CompletedTaskPictureBox.Enabled = false;
            this.CompletedTaskPictureBox.Image = global::LearningPlanner.Properties.Resources.Completed_Task_icon;
            this.CompletedTaskPictureBox.Location = new System.Drawing.Point(4, 28);
            this.CompletedTaskPictureBox.Name = "CompletedTaskPictureBox";
            this.CompletedTaskPictureBox.Size = new System.Drawing.Size(44, 39);
            this.CompletedTaskPictureBox.TabIndex = 1;
            this.CompletedTaskPictureBox.TabStop = false;
            // 
            // CompletedTaskControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.CompletedTaskPictureBox);
            this.Name = "CompletedTaskControl2";
            this.Size = new System.Drawing.Size(185, 97);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CompletedTaskControl2_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.CompletedTaskPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox CompletedTaskPictureBox;
    }
}
