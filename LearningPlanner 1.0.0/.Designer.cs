namespace LearningPlanner
{
    partial class QuotationControl
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
            this.QuotationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // QuotationLabel
            // 
            this.QuotationLabel.BackColor = System.Drawing.Color.Transparent;
            this.QuotationLabel.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuotationLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.QuotationLabel.Location = new System.Drawing.Point(125, 104);
            this.QuotationLabel.Margin = new System.Windows.Forms.Padding(100, 150, 100, 150);
            this.QuotationLabel.Name = "QuotationLabel";
            this.QuotationLabel.Size = new System.Drawing.Size(672, 292);
            this.QuotationLabel.TabIndex = 0;
            this.QuotationLabel.Text = "label1";
            this.QuotationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuotationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LearningPlanner.Properties.Resources.TloCytat;
            this.Controls.Add(this.QuotationLabel);
            this.Name = "QuotationControl";
            this.Size = new System.Drawing.Size(920, 517);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label QuotationLabel;
    }
}
