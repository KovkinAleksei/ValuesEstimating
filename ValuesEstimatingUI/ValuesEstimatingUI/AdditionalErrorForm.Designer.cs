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
            this.additionalErrorLabel = new System.Windows.Forms.Label();
            this.additionalErrorTextBox = new System.Windows.Forms.TextBox();
            this.OKbutton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // additionalErrorLabel
            // 
            this.additionalErrorLabel.AutoSize = true;
            this.additionalErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.additionalErrorLabel.Location = new System.Drawing.Point(9, 9);
            this.additionalErrorLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.additionalErrorLabel.Name = "additionalErrorLabel";
            this.additionalErrorLabel.Size = new System.Drawing.Size(335, 16);
            this.additionalErrorLabel.TabIndex = 0;
            this.additionalErrorLabel.Text = "Введите значение дополнительной погрешности:";
            this.additionalErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // additionalErrorTextBox
            // 
            this.additionalErrorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.additionalErrorTextBox.Location = new System.Drawing.Point(12, 35);
            this.additionalErrorTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.additionalErrorTextBox.Name = "additionalErrorTextBox";
            this.additionalErrorTextBox.Size = new System.Drawing.Size(128, 22);
            this.additionalErrorTextBox.TabIndex = 1;
            this.additionalErrorTextBox.TextChanged += new System.EventHandler(this.additionalErrorTextBox_TextChanged);
            this.additionalErrorTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCut);
            // 
            // OKbutton
            // 
            this.OKbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OKbutton.Location = new System.Drawing.Point(12, 67);
            this.OKbutton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(100, 27);
            this.OKbutton.TabIndex = 2;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            this.OKbutton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCut);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(120, 67);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(5, 5, 3, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 27);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            this.cancelButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCut);
            // 
            // AdditionalErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 104);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.additionalErrorTextBox);
            this.Controls.Add(this.additionalErrorLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AdditionalErrorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дополнительная погрешность";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCut);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label additionalErrorLabel;
        private System.Windows.Forms.TextBox additionalErrorTextBox;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Button cancelButton;
    }
}