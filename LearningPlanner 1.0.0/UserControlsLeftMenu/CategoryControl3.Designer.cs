namespace LearningPlanner
{
    partial class categoryControl3
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
            this.CategoryPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoryPictureBox
            // 
            this.CategoryPictureBox.Enabled = false;
            this.CategoryPictureBox.Image = global::LearningPlanner.Properties.Resources.Category_icon;
            this.CategoryPictureBox.Location = new System.Drawing.Point(4, 28);
            this.CategoryPictureBox.Name = "CategoryPictureBox";
            this.CategoryPictureBox.Size = new System.Drawing.Size(41, 37);
            this.CategoryPictureBox.TabIndex = 1;
            this.CategoryPictureBox.TabStop = false;
            // 
            // categoryControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.CategoryPictureBox);
            this.Name = "categoryControl3";
            this.Size = new System.Drawing.Size(185, 97);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CategoryControl3_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox CategoryPictureBox;
    }
}
