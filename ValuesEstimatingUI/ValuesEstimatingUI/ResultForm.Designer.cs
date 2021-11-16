namespace ValuesEstimatingUI
{
    partial class ResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm));
            this.resultLabel = new MaterialSkin.Controls.MaterialLabel();
            this.resultInfoLabel = new MaterialSkin.Controls.MaterialLabel();
            this.missesLabel = new MaterialSkin.Controls.MaterialLabel();
            this.missesInfoLabel = new MaterialSkin.Controls.MaterialLabel();
            this.saveButton = new MaterialSkin.Controls.MaterialButton();
            this.OKbutton = new MaterialSkin.Controls.MaterialButton();
            this.hintLabel = new MaterialSkin.Controls.MaterialLabel();
            this.hintLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.hintLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Depth = 0;
            this.resultLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.resultLabel.Location = new System.Drawing.Point(12, 82);
            this.resultLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(167, 19);
            this.resultLabel.TabIndex = 8;
            this.resultLabel.Text = "Результат измерений:";
            // 
            // resultInfoLabel
            // 
            this.resultInfoLabel.AutoSize = true;
            this.resultInfoLabel.Depth = 0;
            this.resultInfoLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.resultInfoLabel.Location = new System.Drawing.Point(180, 82);
            this.resultInfoLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.resultInfoLabel.Name = "resultInfoLabel";
            this.resultInfoLabel.Size = new System.Drawing.Size(19, 19);
            this.resultInfoLabel.TabIndex = 9;
            this.resultInfoLabel.Text = "00";
            // 
            // missesLabel
            // 
            this.missesLabel.AutoSize = true;
            this.missesLabel.Depth = 0;
            this.missesLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.missesLabel.Location = new System.Drawing.Point(12, 138);
            this.missesLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.missesLabel.Name = "missesLabel";
            this.missesLabel.Size = new System.Drawing.Size(72, 19);
            this.missesLabel.TabIndex = 10;
            this.missesLabel.Text = "Промахи:";
            // 
            // missesInfoLabel
            // 
            this.missesInfoLabel.AutoSize = true;
            this.missesInfoLabel.Depth = 0;
            this.missesInfoLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.missesInfoLabel.Location = new System.Drawing.Point(86, 138);
            this.missesInfoLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.missesInfoLabel.Name = "missesInfoLabel";
            this.missesInfoLabel.Size = new System.Drawing.Size(19, 19);
            this.missesInfoLabel.TabIndex = 11;
            this.missesInfoLabel.Text = "00";
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveButton.Depth = 0;
            this.saveButton.DrawShadows = true;
            this.saveButton.HighEmphasis = true;
            this.saveButton.Icon = null;
            this.saveButton.Location = new System.Drawing.Point(288, 301);
            this.saveButton.Margin = new System.Windows.Forms.Padding(6);
            this.saveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(176, 36);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Сохранить в файле";
            this.saveButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveButton.UseAccentColor = false;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // OKbutton
            // 
            this.OKbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.OKbutton.AutoSize = false;
            this.OKbutton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OKbutton.Depth = 0;
            this.OKbutton.DrawShadows = true;
            this.OKbutton.HighEmphasis = true;
            this.OKbutton.Icon = null;
            this.OKbutton.Location = new System.Drawing.Point(476, 301);
            this.OKbutton.Margin = new System.Windows.Forms.Padding(6);
            this.OKbutton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(100, 36);
            this.OKbutton.TabIndex = 15;
            this.OKbutton.Text = "ОК";
            this.OKbutton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.OKbutton.UseAccentColor = false;
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // hintLabel
            // 
            this.hintLabel.AutoSize = true;
            this.hintLabel.Depth = 0;
            this.hintLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.hintLabel.Location = new System.Drawing.Point(12, 196);
            this.hintLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(570, 19);
            this.hintLabel.TabIndex = 16;
            this.hintLabel.Text = "X - результат измерений с указанием доверительной границы погрешности";
            // 
            // hintLabel2
            // 
            this.hintLabel2.AutoSize = true;
            this.hintLabel2.Depth = 0;
            this.hintLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.hintLabel2.Location = new System.Drawing.Point(12, 229);
            this.hintLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.hintLabel2.Name = "hintLabel2";
            this.hintLabel2.Size = new System.Drawing.Size(237, 19);
            this.hintLabel2.TabIndex = 17;
            this.hintLabel2.Text = "P - доверительная вероятность";
            // 
            // hintLabel3
            // 
            this.hintLabel3.AutoSize = true;
            this.hintLabel3.Depth = 0;
            this.hintLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.hintLabel3.Location = new System.Drawing.Point(12, 261);
            this.hintLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.hintLabel3.Name = "hintLabel3";
            this.hintLabel3.Size = new System.Drawing.Size(361, 19);
            this.hintLabel3.TabIndex = 18;
            this.hintLabel3.Text = "n - количество измерений в серии без промахов";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 352);
            this.Controls.Add(this.hintLabel3);
            this.Controls.Add(this.hintLabel2);
            this.Controls.Add(this.hintLabel);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.missesInfoLabel);
            this.Controls.Add(this.missesLabel);
            this.Controls.Add(this.resultInfoLabel);
            this.Controls.Add(this.resultLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ResultForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результат";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel resultLabel;
        private MaterialSkin.Controls.MaterialLabel resultInfoLabel;
        private MaterialSkin.Controls.MaterialLabel missesLabel;
        private MaterialSkin.Controls.MaterialLabel missesInfoLabel;
        private MaterialSkin.Controls.MaterialButton saveButton;
        private MaterialSkin.Controls.MaterialButton OKbutton;
        private MaterialSkin.Controls.MaterialLabel hintLabel;
        private MaterialSkin.Controls.MaterialLabel hintLabel2;
        private MaterialSkin.Controls.MaterialLabel hintLabel3;
    }
}