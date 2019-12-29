namespace LearningPlanner
{
    partial class FindTaskControl4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindTaskControl4));
            this.FindTaskPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FindTaskPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FindTaskPictureBox
            // 
            this.FindTaskPictureBox.Enabled = false;
            this.FindTaskPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("FindTaskPictureBox.Image")));
            this.FindTaskPictureBox.Location = new System.Drawing.Point(3, 23);
            this.FindTaskPictureBox.Name = "FindTaskPictureBox";
            this.FindTaskPictureBox.Size = new System.Drawing.Size(45, 46);
            this.FindTaskPictureBox.TabIndex = 1;
            this.FindTaskPictureBox.TabStop = false;
            // 
            // FindTaskControl4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.FindTaskPictureBox);
            this.Name = "FindTaskControl4";
            this.Size = new System.Drawing.Size(185, 97);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FindTaskControl4_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.FindTaskPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox FindTaskPictureBox;
    }
}
