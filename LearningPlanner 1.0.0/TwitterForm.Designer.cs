namespace LearningPlanner
{
    partial class TwitterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TwitterForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.twitterTweetsTextBox = new System.Windows.Forms.RichTextBox();
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.twitterComboBox = new System.Windows.Forms.ComboBox();
            this.foundPersonPicture = new System.Windows.Forms.PictureBox();
            this.followersLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foundPersonPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LearningPlanner.Properties.Resources.Twitter_icon;
            this.pictureBox1.Location = new System.Drawing.Point(23, 536);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // twitterTweetsTextBox
            // 
            this.twitterTweetsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.twitterTweetsTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.twitterTweetsTextBox.ForeColor = System.Drawing.Color.White;
            this.twitterTweetsTextBox.Location = new System.Drawing.Point(211, 175);
            this.twitterTweetsTextBox.Name = "twitterTweetsTextBox";
            this.twitterTweetsTextBox.ReadOnly = true;
            this.twitterTweetsTextBox.Size = new System.Drawing.Size(661, 474);
            this.twitterTweetsTextBox.TabIndex = 1;
            this.twitterTweetsTextBox.Text = "";
            this.twitterTweetsTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.twitterTweetsTextBox_LinkClicked);
            // 
            // findTextBox
            // 
            this.findTextBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.findTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.findTextBox.ForeColor = System.Drawing.Color.White;
            this.findTextBox.Location = new System.Drawing.Point(476, 74);
            this.findTextBox.Multiline = true;
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(300, 30);
            this.findTextBox.TabIndex = 2;
            this.findTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // findButton
            // 
            this.findButton.BackColor = System.Drawing.Color.White;
            this.findButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.findButton.Location = new System.Drawing.Point(542, 120);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(183, 37);
            this.findButton.TabIndex = 3;
            this.findButton.Text = "Znajdź...";
            this.findButton.UseVisualStyleBackColor = false;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // twitterComboBox
            // 
            this.twitterComboBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.twitterComboBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.twitterComboBox.ForeColor = System.Drawing.Color.White;
            this.twitterComboBox.FormattingEnabled = true;
            this.twitterComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.twitterComboBox.Location = new System.Drawing.Point(813, 74);
            this.twitterComboBox.Name = "twitterComboBox";
            this.twitterComboBox.Size = new System.Drawing.Size(59, 28);
            this.twitterComboBox.TabIndex = 4;
            // 
            // foundPersonPicture
            // 
            this.foundPersonPicture.Location = new System.Drawing.Point(12, 175);
            this.foundPersonPicture.Name = "foundPersonPicture";
            this.foundPersonPicture.Size = new System.Drawing.Size(182, 193);
            this.foundPersonPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foundPersonPicture.TabIndex = 5;
            this.foundPersonPicture.TabStop = false;
            // 
            // followersLabel
            // 
            this.followersLabel.AutoSize = true;
            this.followersLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.followersLabel.Location = new System.Drawing.Point(19, 382);
            this.followersLabel.Name = "followersLabel";
            this.followersLabel.Size = new System.Drawing.Size(58, 19);
            this.followersLabel.TabIndex = 6;
            this.followersLabel.Text = "label1";
            this.followersLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 84);
            this.label1.TabIndex = 7;
            this.label1.Text = "Znajdź tweety!";
            // 
            // TwitterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.followersLabel);
            this.Controls.Add(this.foundPersonPicture);
            this.Controls.Add(this.twitterComboBox);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.findTextBox);
            this.Controls.Add(this.twitterTweetsTextBox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TwitterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tweety!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foundPersonPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox twitterTweetsTextBox;
        private System.Windows.Forms.TextBox findTextBox;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.ComboBox twitterComboBox;
        private System.Windows.Forms.PictureBox foundPersonPicture;
        private System.Windows.Forms.Label followersLabel;
        private System.Windows.Forms.Label label1;
    }
}