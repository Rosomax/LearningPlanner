namespace LearningPlanner_1._0._0
{
    partial class ZeSwiataIt
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
            this.addUrlButton = new System.Windows.Forms.Button();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.urlGroupBox = new System.Windows.Forms.GroupBox();
            this.rssImage = new System.Windows.Forms.PictureBox();
            this.channelsTitleLabel = new System.Windows.Forms.Label();
            this.channelsListBox = new System.Windows.Forms.ListBox();
            this.displayForNewsTabControl = new System.Windows.Forms.TabControl();
            this.urlGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rssImage)).BeginInit();
            this.SuspendLayout();
            // 
            // addUrlButton
            // 
            this.addUrlButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addUrlButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.addUrlButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addUrlButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addUrlButton.Location = new System.Drawing.Point(6, 62);
            this.addUrlButton.MaximumSize = new System.Drawing.Size(188, 100);
            this.addUrlButton.Name = "addUrlButton";
            this.addUrlButton.Padding = new System.Windows.Forms.Padding(5);
            this.addUrlButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addUrlButton.Size = new System.Drawing.Size(188, 50);
            this.addUrlButton.TabIndex = 0;
            this.addUrlButton.Text = "Dodaj";
            this.addUrlButton.UseVisualStyleBackColor = false;
            this.addUrlButton.Click += new System.EventHandler(this.addUrlButton_Click);
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(6, 34);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(188, 22);
            this.urlTextBox.TabIndex = 1;
            // 
            // urlGroupBox
            // 
            this.urlGroupBox.Controls.Add(this.rssImage);
            this.urlGroupBox.Controls.Add(this.channelsTitleLabel);
            this.urlGroupBox.Controls.Add(this.channelsListBox);
            this.urlGroupBox.Controls.Add(this.addUrlButton);
            this.urlGroupBox.Controls.Add(this.urlTextBox);
            this.urlGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.urlGroupBox.Location = new System.Drawing.Point(0, 0);
            this.urlGroupBox.Name = "urlGroupBox";
            this.urlGroupBox.Size = new System.Drawing.Size(200, 544);
            this.urlGroupBox.TabIndex = 3;
            this.urlGroupBox.TabStop = false;
            this.urlGroupBox.Text = "RSS URL";
            // 
            // rssImage
            // 
            this.rssImage.Image = global::LearningPlanner_1._0._0.Properties.Resources.RssImagePNG;
            this.rssImage.Location = new System.Drawing.Point(6, 109);
            this.rssImage.Name = "rssImage";
            this.rssImage.Size = new System.Drawing.Size(188, 133);
            this.rssImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rssImage.TabIndex = 4;
            this.rssImage.TabStop = false;
            // 
            // channelsTitleLabel
            // 
            this.channelsTitleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.channelsTitleLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.channelsTitleLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.channelsTitleLabel.Location = new System.Drawing.Point(6, 245);
            this.channelsTitleLabel.MaximumSize = new System.Drawing.Size(188, 0);
            this.channelsTitleLabel.Name = "channelsTitleLabel";
            this.channelsTitleLabel.Padding = new System.Windows.Forms.Padding(5);
            this.channelsTitleLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.channelsTitleLabel.Size = new System.Drawing.Size(188, 34);
            this.channelsTitleLabel.TabIndex = 3;
            this.channelsTitleLabel.Text = "Polecane Kanały";
            this.channelsTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // channelsListBox
            // 
            this.channelsListBox.FormattingEnabled = true;
            this.channelsListBox.ItemHeight = 16;
            this.channelsListBox.Location = new System.Drawing.Point(12, 287);
            this.channelsListBox.Name = "channelsListBox";
            this.channelsListBox.Size = new System.Drawing.Size(171, 228);
            this.channelsListBox.TabIndex = 2;
            this.channelsListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.channelsListBox_MouseClick);
            // 
            // displayForNewsTabControl
            // 
            this.displayForNewsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayForNewsTabControl.Location = new System.Drawing.Point(200, 0);
            this.displayForNewsTabControl.Name = "displayForNewsTabControl";
            this.displayForNewsTabControl.SelectedIndex = 0;
            this.displayForNewsTabControl.Size = new System.Drawing.Size(523, 544);
            this.displayForNewsTabControl.TabIndex = 4;
            // 
            // ZeSwiataIt
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(723, 544);
            this.Controls.Add(this.displayForNewsTabControl);
            this.Controls.Add(this.urlGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ZeSwiataIt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ZeSwiataIt";
            this.Load += new System.EventHandler(this.ZeSwiataIt_Load);
            this.urlGroupBox.ResumeLayout(false);
            this.urlGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rssImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addUrlButton;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.GroupBox urlGroupBox;
        private System.Windows.Forms.TabControl displayForNewsTabControl;
        private System.Windows.Forms.ListBox channelsListBox;
        private System.Windows.Forms.Label channelsTitleLabel;
        private System.Windows.Forms.PictureBox rssImage;
    }
}