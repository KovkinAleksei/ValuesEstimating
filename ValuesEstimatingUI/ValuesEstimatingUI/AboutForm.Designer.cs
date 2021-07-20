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
            this.valuesEstimatingLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.eMailLabel = new System.Windows.Forms.Label();
            this.gitHubLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.eMailLinkLabel = new System.Windows.Forms.LinkLabel();
            this.gitHubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // valuesEstimatingLabel
            // 
            this.valuesEstimatingLabel.AutoSize = true;
            this.valuesEstimatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valuesEstimatingLabel.Location = new System.Drawing.Point(12, 9);
            this.valuesEstimatingLabel.Name = "valuesEstimatingLabel";
            this.valuesEstimatingLabel.Size = new System.Drawing.Size(240, 31);
            this.valuesEstimatingLabel.TabIndex = 0;
            this.valuesEstimatingLabel.Text = "ValuesEstimating";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.versionLabel.Location = new System.Drawing.Point(15, 48);
            this.versionLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(45, 16);
            this.versionLabel.TabIndex = 1;
            this.versionLabel.Text = "v 1.0.0";
            // 
            // eMailLabel
            // 
            this.eMailLabel.AutoSize = true;
            this.eMailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eMailLabel.Location = new System.Drawing.Point(15, 94);
            this.eMailLabel.Name = "eMailLabel";
            this.eMailLabel.Size = new System.Drawing.Size(126, 16);
            this.eMailLabel.TabIndex = 2;
            this.eMailLabel.Text = "E-mail для отзыва:";
            // 
            // gitHubLabel
            // 
            this.gitHubLabel.AutoSize = true;
            this.gitHubLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gitHubLabel.Location = new System.Drawing.Point(15, 139);
            this.gitHubLabel.Name = "gitHubLabel";
            this.gitHubLabel.Size = new System.Drawing.Size(52, 16);
            this.gitHubLabel.TabIndex = 3;
            this.gitHubLabel.Text = "GitHub:";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearLabel.Location = new System.Drawing.Point(12, 216);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(36, 16);
            this.yearLabel.TabIndex = 4;
            this.yearLabel.Text = "2021";
            // 
            // eMailLinkLabel
            // 
            this.eMailLinkLabel.AutoSize = true;
            this.eMailLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eMailLinkLabel.Location = new System.Drawing.Point(136, 94);
            this.eMailLinkLabel.Name = "eMailLinkLabel";
            this.eMailLinkLabel.Size = new System.Drawing.Size(138, 16);
            this.eMailLinkLabel.TabIndex = 5;
            this.eMailLinkLabel.TabStop = true;
            this.eMailLinkLabel.Text = "akovkin6@gmail.com";
            this.eMailLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.eMailLinkLabel_LinkClicked);
            // 
            // gitHubLinkLabel
            // 
            this.gitHubLinkLabel.AutoSize = true;
            this.gitHubLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gitHubLinkLabel.Location = new System.Drawing.Point(62, 139);
            this.gitHubLinkLabel.Name = "gitHubLinkLabel";
            this.gitHubLinkLabel.Size = new System.Drawing.Size(201, 16);
            this.gitHubLinkLabel.TabIndex = 6;
            this.gitHubLinkLabel.TabStop = true;
            this.gitHubLinkLabel.Text = "KovkinAleksei/ValuesEstimating";
            this.gitHubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gitHubLinkLabel_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 241);
            this.Controls.Add(this.gitHubLinkLabel);
            this.Controls.Add(this.eMailLinkLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.gitHubLabel);
            this.Controls.Add(this.eMailLabel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.valuesEstimatingLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label valuesEstimatingLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label eMailLabel;
        private System.Windows.Forms.Label gitHubLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.LinkLabel eMailLinkLabel;
        private System.Windows.Forms.LinkLabel gitHubLinkLabel;
    }
}