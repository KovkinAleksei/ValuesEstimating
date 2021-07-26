namespace ValuesEstimatingUI
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.eMailLabel = new System.Windows.Forms.Label();
            this.gitHubLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.eMailLinkLabel = new System.Windows.Forms.LinkLabel();
            this.gitHubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.valuesEstimatingLabel = new MaterialSkin.Controls.MaterialLabel();
            this.versionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.closeButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // eMailLabel
            // 
            this.eMailLabel.AutoSize = true;
            this.eMailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eMailLabel.Location = new System.Drawing.Point(11, 179);
            this.eMailLabel.Name = "eMailLabel";
            this.eMailLabel.Size = new System.Drawing.Size(150, 20);
            this.eMailLabel.TabIndex = 2;
            this.eMailLabel.Text = "E-mail для отзыва:";
            // 
            // gitHubLabel
            // 
            this.gitHubLabel.AutoSize = true;
            this.gitHubLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gitHubLabel.Location = new System.Drawing.Point(11, 240);
            this.gitHubLabel.Name = "gitHubLabel";
            this.gitHubLabel.Size = new System.Drawing.Size(64, 20);
            this.gitHubLabel.TabIndex = 3;
            this.gitHubLabel.Text = "GitHub:";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearLabel.Location = new System.Drawing.Point(11, 331);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(45, 20);
            this.yearLabel.TabIndex = 4;
            this.yearLabel.Text = "2021";
            // 
            // eMailLinkLabel
            // 
            this.eMailLinkLabel.AutoSize = true;
            this.eMailLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eMailLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.eMailLinkLabel.Location = new System.Drawing.Point(133, 179);
            this.eMailLinkLabel.Name = "eMailLinkLabel";
            this.eMailLinkLabel.Size = new System.Drawing.Size(158, 20);
            this.eMailLinkLabel.TabIndex = 5;
            this.eMailLinkLabel.TabStop = true;
            this.eMailLinkLabel.Text = "akovkin6@gmail.com";
            this.eMailLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.eMailLinkLabel_LinkClicked);
            // 
            // gitHubLinkLabel
            // 
            this.gitHubLinkLabel.AutoSize = true;
            this.gitHubLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gitHubLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gitHubLinkLabel.Location = new System.Drawing.Point(58, 240);
            this.gitHubLinkLabel.Name = "gitHubLinkLabel";
            this.gitHubLinkLabel.Size = new System.Drawing.Size(234, 20);
            this.gitHubLinkLabel.TabIndex = 6;
            this.gitHubLinkLabel.TabStop = true;
            this.gitHubLinkLabel.Text = "KovkinAleksei/ValuesEstimating";
            this.gitHubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gitHubLinkLabel_LinkClicked);
            // 
            // valuesEstimatingLabel
            // 
            this.valuesEstimatingLabel.AutoSize = true;
            this.valuesEstimatingLabel.Depth = 0;
            this.valuesEstimatingLabel.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.valuesEstimatingLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.valuesEstimatingLabel.Location = new System.Drawing.Point(12, 74);
            this.valuesEstimatingLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.valuesEstimatingLabel.Name = "valuesEstimatingLabel";
            this.valuesEstimatingLabel.Size = new System.Drawing.Size(267, 41);
            this.valuesEstimatingLabel.TabIndex = 7;
            this.valuesEstimatingLabel.Text = "ValuesEstimating";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Depth = 0;
            this.versionLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.versionLabel.Location = new System.Drawing.Point(12, 115);
            this.versionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(52, 19);
            this.versionLabel.TabIndex = 8;
            this.versionLabel.Text = "v. 1.0.0";
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = false;
            this.closeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeButton.Depth = 0;
            this.closeButton.DrawShadows = true;
            this.closeButton.HighEmphasis = true;
            this.closeButton.Icon = null;
            this.closeButton.Location = new System.Drawing.Point(356, 315);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.closeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(100, 36);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "Закрыть";
            this.closeButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.closeButton.UseAccentColor = false;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 360);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.valuesEstimatingLabel);
            this.Controls.Add(this.gitHubLinkLabel);
            this.Controls.Add(this.eMailLinkLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.gitHubLabel);
            this.Controls.Add(this.eMailLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label eMailLabel;
        private System.Windows.Forms.Label gitHubLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.LinkLabel eMailLinkLabel;
        private System.Windows.Forms.LinkLabel gitHubLinkLabel;
        private MaterialSkin.Controls.MaterialLabel valuesEstimatingLabel;
        private MaterialSkin.Controls.MaterialLabel versionLabel;
        private MaterialSkin.Controls.MaterialButton closeButton;
    }
}