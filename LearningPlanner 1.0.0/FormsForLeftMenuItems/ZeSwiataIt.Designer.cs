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
            this.panelHide = new System.Windows.Forms.Panel();
            this.channelsTitleLabel = new System.Windows.Forms.Label();
            this.rssImage = new System.Windows.Forms.PictureBox();
            this.channelsListBox = new System.Windows.Forms.ListBox();
            this.displayForNewsTabControl = new System.Windows.Forms.TabControl();
            this.WebBrowserForXml = new System.Windows.Forms.WebBrowser();
            this.urlGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rssImage)).BeginInit();
            this.SuspendLayout();
            // 
            // addUrlButton
            // 
            this.addUrlButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addUrlButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(222)))));
            this.addUrlButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addUrlButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.addUrlButton.FlatAppearance.BorderSize = 3;
            this.addUrlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUrlButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addUrlButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addUrlButton.Location = new System.Drawing.Point(10, 34);
            this.addUrlButton.Margin = new System.Windows.Forms.Padding(8);
            this.addUrlButton.MaximumSize = new System.Drawing.Size(185, 100);
            this.addUrlButton.Name = "addUrlButton";
            this.addUrlButton.Padding = new System.Windows.Forms.Padding(5);
            this.addUrlButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addUrlButton.Size = new System.Drawing.Size(180, 53);
            this.addUrlButton.TabIndex = 0;
            this.addUrlButton.Text = "Dodaj";
            this.addUrlButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.addUrlButton.UseVisualStyleBackColor = false;
            this.addUrlButton.Click += new System.EventHandler(this.addUrlButton_Click);
            // 
            // urlTextBox
            // 
            this.urlTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(222)))));
            this.urlTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.urlTextBox.Location = new System.Drawing.Point(13, 13);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(175, 15);
            this.urlTextBox.TabIndex = 1;
            // 
            // urlGroupBox
            // 
            this.urlGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.urlGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.urlGroupBox.Controls.Add(this.panelHide);
            this.urlGroupBox.Controls.Add(this.channelsTitleLabel);
            this.urlGroupBox.Controls.Add(this.rssImage);
            this.urlGroupBox.Controls.Add(this.addUrlButton);
            this.urlGroupBox.Controls.Add(this.urlTextBox);
            this.urlGroupBox.Controls.Add(this.channelsListBox);
            this.urlGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.urlGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.urlGroupBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.urlGroupBox.Location = new System.Drawing.Point(0, 0);
            this.urlGroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.urlGroupBox.Name = "urlGroupBox";
            this.urlGroupBox.Padding = new System.Windows.Forms.Padding(0);
            this.urlGroupBox.Size = new System.Drawing.Size(203, 544);
            this.urlGroupBox.TabIndex = 3;
            this.urlGroupBox.TabStop = false;
            // 
            // panelHide
            // 
            this.panelHide.Location = new System.Drawing.Point(2, 2);
            this.panelHide.Name = "panelHide";
            this.panelHide.Size = new System.Drawing.Size(198, 4);
            this.panelHide.TabIndex = 5;
            // 
            // channelsTitleLabel
            // 
            this.channelsTitleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(222)))));
            this.channelsTitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.channelsTitleLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.channelsTitleLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.channelsTitleLabel.Location = new System.Drawing.Point(14, 94);
            this.channelsTitleLabel.MaximumSize = new System.Drawing.Size(200, 87);
            this.channelsTitleLabel.Name = "channelsTitleLabel";
            this.channelsTitleLabel.Padding = new System.Windows.Forms.Padding(5);
            this.channelsTitleLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.channelsTitleLabel.Size = new System.Drawing.Size(175, 74);
            this.channelsTitleLabel.TabIndex = 3;
            this.channelsTitleLabel.Text = "Polecane Kanały";
            this.channelsTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rssImage
            // 
            this.rssImage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rssImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.rssImage.Image = global::LearningPlanner_1._0._0.Properties.Resources.RssImagePNG;
            this.rssImage.Location = new System.Drawing.Point(11, 444);
            this.rssImage.Name = "rssImage";
            this.rssImage.Size = new System.Drawing.Size(184, 92);
            this.rssImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rssImage.TabIndex = 4;
            this.rssImage.TabStop = false;
            // 
            // channelsListBox
            // 
            this.channelsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(197)))), ((int)(((byte)(222)))));
            this.channelsListBox.FormattingEnabled = true;
            this.channelsListBox.ItemHeight = 16;
            this.channelsListBox.Location = new System.Drawing.Point(12, 182);
            this.channelsListBox.Name = "channelsListBox";
            this.channelsListBox.Size = new System.Drawing.Size(176, 212);
            this.channelsListBox.TabIndex = 2;
            this.channelsListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.channelsListBox_MouseClick);
            // 
            // displayForNewsTabControl
            // 
            this.displayForNewsTabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.displayForNewsTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.displayForNewsTabControl.Location = new System.Drawing.Point(203, 0);
            this.displayForNewsTabControl.Name = "displayForNewsTabControl";
            this.displayForNewsTabControl.SelectedIndex = 0;
            this.displayForNewsTabControl.Size = new System.Drawing.Size(520, 276);
            this.displayForNewsTabControl.TabIndex = 4;
            // 
            // WebBrowserForXml
            // 
            this.WebBrowserForXml.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WebBrowserForXml.Location = new System.Drawing.Point(203, 276);
            this.WebBrowserForXml.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowserForXml.Name = "WebBrowserForXml";
            this.WebBrowserForXml.Size = new System.Drawing.Size(520, 268);
            this.WebBrowserForXml.TabIndex = 5;
            // 
            // ZeSwiataIt
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(723, 544);
            this.Controls.Add(this.WebBrowserForXml);
            this.Controls.Add(this.displayForNewsTabControl);
            this.Controls.Add(this.urlGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ZeSwiataIt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ZeSwiataIt";
            this.Load += new System.EventHandler(this.ZeSwiataIt_Load);
            this.SizeChanged += new System.EventHandler(this.ZeSwiataIt_SizeChanged);
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
        private System.Windows.Forms.PictureBox rssImage;
        private System.Windows.Forms.Label channelsTitleLabel;
        private System.Windows.Forms.Panel panelHide;
        private System.Windows.Forms.WebBrowser WebBrowserForXml;
    }
}