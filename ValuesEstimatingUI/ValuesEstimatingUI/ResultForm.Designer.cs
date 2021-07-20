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
            this.resultLabel = new System.Windows.Forms.Label();
            this.missesLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resultInfoLabel = new System.Windows.Forms.Label();
            this.missesInfoLabel = new System.Windows.Forms.Label();
            this.resultErrorInfoLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.OKbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.Location = new System.Drawing.Point(12, 9);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(157, 16);
            this.resultLabel.TabIndex = 0;
            this.resultLabel.Text = "Результат измерений:";
            // 
            // missesLabel
            // 
            this.missesLabel.AutoSize = true;
            this.missesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.missesLabel.Location = new System.Drawing.Point(12, 56);
            this.missesLabel.Name = "missesLabel";
            this.missesLabel.Size = new System.Drawing.Size(68, 16);
            this.missesLabel.TabIndex = 1;
            this.missesLabel.Text = "Промахи:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Общая доверительная граница погрешности:";
            // 
            // resultInfoLabel
            // 
            this.resultInfoLabel.AutoSize = true;
            this.resultInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultInfoLabel.Location = new System.Drawing.Point(165, 9);
            this.resultInfoLabel.Name = "resultInfoLabel";
            this.resultInfoLabel.Size = new System.Drawing.Size(45, 16);
            this.resultInfoLabel.TabIndex = 3;
            this.resultInfoLabel.Text = "label2";
            // 
            // missesInfoLabel
            // 
            this.missesInfoLabel.AutoSize = true;
            this.missesInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.missesInfoLabel.Location = new System.Drawing.Point(76, 56);
            this.missesInfoLabel.Name = "missesInfoLabel";
            this.missesInfoLabel.Size = new System.Drawing.Size(45, 16);
            this.missesInfoLabel.TabIndex = 4;
            this.missesInfoLabel.Text = "label2";
            // 
            // resultErrorInfoLabel
            // 
            this.resultErrorInfoLabel.AutoSize = true;
            this.resultErrorInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultErrorInfoLabel.Location = new System.Drawing.Point(308, 104);
            this.resultErrorInfoLabel.Name = "resultErrorInfoLabel";
            this.resultErrorInfoLabel.Size = new System.Drawing.Size(45, 16);
            this.resultErrorInfoLabel.TabIndex = 5;
            this.resultErrorInfoLabel.Text = "label2";
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(14, 146);
            this.saveButton.Margin = new System.Windows.Forms.Padding(5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(154, 27);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Сохранить в файле";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // OKbutton
            // 
            this.OKbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.OKbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OKbutton.Location = new System.Drawing.Point(178, 146);
            this.OKbutton.Margin = new System.Windows.Forms.Padding(5);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(100, 27);
            this.OKbutton.TabIndex = 7;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 181);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.resultErrorInfoLabel);
            this.Controls.Add(this.missesInfoLabel);
            this.Controls.Add(this.resultInfoLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.missesLabel);
            this.Controls.Add(this.resultLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результат";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label missesLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultInfoLabel;
        private System.Windows.Forms.Label missesInfoLabel;
        private System.Windows.Forms.Label resultErrorInfoLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button OKbutton;
    }
}