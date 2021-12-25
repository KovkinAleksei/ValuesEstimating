namespace ValuesEstimatingUI
{
    partial class AdditionalErrorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdditionalErrorForm));
            this.additionalErrorLabel = new MaterialSkin.Controls.MaterialLabel();
            this.additionalErrorTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.OKbutton = new MaterialSkin.Controls.MaterialButton();
            this.cancelButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // additionalErrorLabel
            // 
            this.additionalErrorLabel.AutoSize = true;
            this.additionalErrorLabel.Depth = 0;
            this.additionalErrorLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.additionalErrorLabel.Location = new System.Drawing.Point(12, 73);
            this.additionalErrorLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.additionalErrorLabel.Name = "additionalErrorLabel";
            this.additionalErrorLabel.Size = new System.Drawing.Size(371, 19);
            this.additionalErrorLabel.TabIndex = 4;
            this.additionalErrorLabel.Text = "Введите значение дополнительной погрешности:";
            // 
            // additionalErrorTextBox
            // 
            this.additionalErrorTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.additionalErrorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.additionalErrorTextBox.Depth = 0;
            this.additionalErrorTextBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.additionalErrorTextBox.Location = new System.Drawing.Point(19, 104);
            this.additionalErrorTextBox.MaxLength = 50;
            this.additionalErrorTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.additionalErrorTextBox.Multiline = false;
            this.additionalErrorTextBox.Name = "additionalErrorTextBox";
            this.additionalErrorTextBox.Size = new System.Drawing.Size(144, 50);
            this.additionalErrorTextBox.TabIndex = 5;
            this.additionalErrorTextBox.Text = "";
            this.additionalErrorTextBox.TextChanged += new System.EventHandler(this.additionalErrorTextBox_TextChanged);
            this.additionalErrorTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCut);
            // 
            // OKbutton
            // 
            this.OKbutton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OKbutton.AutoSize = false;
            this.OKbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OKbutton.Depth = 0;
            this.OKbutton.DrawShadows = true;
            this.OKbutton.HighEmphasis = true;
            this.OKbutton.Icon = null;
            this.OKbutton.Location = new System.Drawing.Point(203, 180);
            this.OKbutton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OKbutton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(100, 36);
            this.OKbutton.TabIndex = 6;
            this.OKbutton.Text = "OK";
            this.OKbutton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.OKbutton.UseAccentColor = false;
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            this.OKbutton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCut);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cancelButton.AutoSize = false;
            this.cancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelButton.Depth = 0;
            this.cancelButton.DrawShadows = true;
            this.cancelButton.HighEmphasis = true;
            this.cancelButton.Icon = null;
            this.cancelButton.Location = new System.Drawing.Point(313, 180);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(6);
            this.cancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 36);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cancelButton.UseAccentColor = false;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            this.cancelButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCut);
            // 
            // AdditionalErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 228);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.additionalErrorTextBox);
            this.Controls.Add(this.additionalErrorLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdditionalErrorForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дополнительная погрешность";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCut);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel additionalErrorLabel;
        private MaterialSkin.Controls.MaterialTextBox additionalErrorTextBox;
        private MaterialSkin.Controls.MaterialButton OKbutton;
        private MaterialSkin.Controls.MaterialButton cancelButton;
    }
}