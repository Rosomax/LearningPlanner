namespace LearningPlanner
{
    partial class ITNewsControl5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ITNewsControl5));
            this.ITNewsPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ITNewsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ITNewsPictureBox
            // 
            this.ITNewsPictureBox.Enabled = false;
            this.ITNewsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ITNewsPictureBox.Image")));
            this.ITNewsPictureBox.Location = new System.Drawing.Point(3, 23);
            this.ITNewsPictureBox.Name = "ITNewsPictureBox";
            this.ITNewsPictureBox.Size = new System.Drawing.Size(45, 50);
            this.ITNewsPictureBox.TabIndex = 1;
            this.ITNewsPictureBox.TabStop = false;
            // 
            // ITNewsControl5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ITNewsPictureBox);
            this.Name = "ITNewsControl5";
            this.Size = new System.Drawing.Size(192, 97);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ITNewsControl5_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.ITNewsPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox ITNewsPictureBox;
    }
}
