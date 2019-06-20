namespace LearningPlanner_1._0._0
{
    partial class ReportErrorForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.MailLabel = new System.Windows.Forms.Label();
            this.CategoryErrorLabel = new System.Windows.Forms.Label();
            this.ErrorDescribeLabel = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.categoryErrorComboBox = new System.Windows.Forms.ComboBox();
            this.describeErrorRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SendErrorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NameLabel.Location = new System.Drawing.Point(154, 27);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(130, 25);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Imię (Nick):";
            // 
            // MailLabel
            // 
            this.MailLabel.AutoSize = true;
            this.MailLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MailLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MailLabel.Location = new System.Drawing.Point(9, 75);
            this.MailLabel.Name = "MailLabel";
            this.MailLabel.Size = new System.Drawing.Size(275, 25);
            this.MailLabel.TabIndex = 2;
            this.MailLabel.Text = "Adres E-mail do kontaktu:";
            // 
            // CategoryErrorLabel
            // 
            this.CategoryErrorLabel.AutoSize = true;
            this.CategoryErrorLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryErrorLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CategoryErrorLabel.Location = new System.Drawing.Point(93, 129);
            this.CategoryErrorLabel.Name = "CategoryErrorLabel";
            this.CategoryErrorLabel.Size = new System.Drawing.Size(191, 25);
            this.CategoryErrorLabel.TabIndex = 3;
            this.CategoryErrorLabel.Text = "Rodzaj problemu:";
            // 
            // ErrorDescribeLabel
            // 
            this.ErrorDescribeLabel.AutoSize = true;
            this.ErrorDescribeLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorDescribeLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ErrorDescribeLabel.Location = new System.Drawing.Point(174, 186);
            this.ErrorDescribeLabel.Name = "ErrorDescribeLabel";
            this.ErrorDescribeLabel.Size = new System.Drawing.Size(169, 25);
            this.ErrorDescribeLabel.TabIndex = 4;
            this.ErrorDescribeLabel.Text = "Opis problemu:";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameTextbox.Location = new System.Drawing.Point(313, 27);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(170, 27);
            this.nameTextbox.TabIndex = 5;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailTextBox.Location = new System.Drawing.Point(313, 75);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(170, 27);
            this.emailTextBox.TabIndex = 6;
            // 
            // categoryErrorComboBox
            // 
            this.categoryErrorComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.categoryErrorComboBox.FormattingEnabled = true;
            this.categoryErrorComboBox.Items.AddRange(new object[] {
            "Awaria\\Błąd",
            "Złe działanie aplikacji",
            "Pytanie techniczne",
            "Współpraca biznesowa",
            "Inne"});
            this.categoryErrorComboBox.Location = new System.Drawing.Point(313, 129);
            this.categoryErrorComboBox.Name = "categoryErrorComboBox";
            this.categoryErrorComboBox.Size = new System.Drawing.Size(170, 29);
            this.categoryErrorComboBox.TabIndex = 7;
            this.categoryErrorComboBox.Text = "Wybierz";
            // 
            // describeErrorRichTextBox
            // 
            this.describeErrorRichTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.describeErrorRichTextBox.Location = new System.Drawing.Point(14, 214);
            this.describeErrorRichTextBox.Name = "describeErrorRichTextBox";
            this.describeErrorRichTextBox.Size = new System.Drawing.Size(469, 155);
            this.describeErrorRichTextBox.TabIndex = 8;
            this.describeErrorRichTextBox.Text = "";
            // 
            // SendErrorButton
            // 
            this.SendErrorButton.BackColor = System.Drawing.Color.RosyBrown;
            this.SendErrorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendErrorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendErrorButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendErrorButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SendErrorButton.Location = new System.Drawing.Point(179, 399);
            this.SendErrorButton.Name = "SendErrorButton";
            this.SendErrorButton.Size = new System.Drawing.Size(147, 44);
            this.SendErrorButton.TabIndex = 12;
            this.SendErrorButton.Text = "Wyślij";
            this.SendErrorButton.UseVisualStyleBackColor = false;
            this.SendErrorButton.Click += new System.EventHandler(this.SendErrorButton_Click);
            // 
            // ReportErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(499, 475);
            this.Controls.Add(this.SendErrorButton);
            this.Controls.Add(this.describeErrorRichTextBox);
            this.Controls.Add(this.categoryErrorComboBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.ErrorDescribeLabel);
            this.Controls.Add(this.CategoryErrorLabel);
            this.Controls.Add(this.MailLabel);
            this.Controls.Add(this.NameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReportErrorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zgłoś Błąd";
            this.Load += new System.EventHandler(this.ReportErrorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label MailLabel;
        private System.Windows.Forms.Label CategoryErrorLabel;
        private System.Windows.Forms.Label ErrorDescribeLabel;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ComboBox categoryErrorComboBox;
        private System.Windows.Forms.RichTextBox describeErrorRichTextBox;
        public System.Windows.Forms.Button SendErrorButton;
    }
}