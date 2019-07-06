namespace LearningPlanner
{
    partial class SettingsControl6
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
            this.SettingsPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SettingsPictureBox
            // 
            this.SettingsPictureBox.Enabled = false;
            this.SettingsPictureBox.Image = global::LearningPlanner.Properties.Resources.Settings_icon;
            this.SettingsPictureBox.Location = new System.Drawing.Point(4, 26);
            this.SettingsPictureBox.Name = "SettingsPictureBox";
            this.SettingsPictureBox.Size = new System.Drawing.Size(42, 47);
            this.SettingsPictureBox.TabIndex = 1;
            this.SettingsPictureBox.TabStop = false;
            // 
            // SettingsControl6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.SettingsPictureBox);
            this.Name = "SettingsControl6";
            this.Size = new System.Drawing.Size(185, 97);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SettingsControl6_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.SettingsPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox SettingsPictureBox;
    }
}
