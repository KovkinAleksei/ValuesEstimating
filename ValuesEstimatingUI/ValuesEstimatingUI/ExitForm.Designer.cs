namespace ValuesEstimatingUI
{
    partial class ExitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExitForm));
            this.exitLabel = new MaterialSkin.Controls.MaterialLabel();
            this.OKbutton = new MaterialSkin.Controls.MaterialButton();
            this.cancelButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.Depth = 0;
            this.exitLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.exitLabel.Location = new System.Drawing.Point(12, 74);
            this.exitLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(253, 19);
            this.exitLabel.TabIndex = 0;
            this.exitLabel.Text = "Вы действительно хотите выйти?";
            // 
            // OKbutton
            // 
            this.OKbutton.AutoSize = false;
            this.OKbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OKbutton.Depth = 0;
            this.OKbutton.DrawShadows = true;
            this.OKbutton.HighEmphasis = true;
            this.OKbutton.Icon = null;
            this.OKbutton.Location = new System.Drawing.Point(179, 119);
            this.OKbutton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OKbutton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(100, 36);
            this.OKbutton.TabIndex = 1;
            this.OKbutton.Text = "Да";
            this.OKbutton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.OKbutton.UseAccentColor = false;
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = false;
            this.cancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelButton.Depth = 0;
            this.cancelButton.DrawShadows = true;
            this.cancelButton.HighEmphasis = true;
            this.cancelButton.Icon = null;
            this.cancelButton.Location = new System.Drawing.Point(287, 119);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 36);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Нет";
            this.cancelButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cancelButton.UseAccentColor = false;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ExitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 170);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.exitLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ExitForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel exitLabel;
        private MaterialSkin.Controls.MaterialButton OKbutton;
        private MaterialSkin.Controls.MaterialButton cancelButton;
    }
}