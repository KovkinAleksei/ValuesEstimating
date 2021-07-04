namespace ValuesEstimatingUI
{
    partial class MainErrorForm
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
            this.MainErrorLabel = new System.Windows.Forms.Label();
            this.mainErrorTextBox = new System.Windows.Forms.TextBox();
            this.orLabel = new System.Windows.Forms.Label();
            this.accuracyClassLabel = new System.Windows.Forms.Label();
            this.errorCharacterLabel = new System.Windows.Forms.Label();
            this.errorCharacterComboBox = new System.Windows.Forms.ComboBox();
            this.accuracyClassComboBox = new System.Windows.Forms.ComboBox();
            this.OKbutton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.infoTopLabel = new System.Windows.Forms.Label();
            this.infoBottomLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainErrorLabel
            // 
            this.MainErrorLabel.AutoSize = true;
            this.MainErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainErrorLabel.Location = new System.Drawing.Point(192, 62);
            this.MainErrorLabel.Name = "MainErrorLabel";
            this.MainErrorLabel.Size = new System.Drawing.Size(219, 16);
            this.MainErrorLabel.TabIndex = 0;
            this.MainErrorLabel.Text = "Введите основную погрешность";
            // 
            // mainErrorTextBox
            // 
            this.mainErrorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainErrorTextBox.Location = new System.Drawing.Point(12, 59);
            this.mainErrorTextBox.Name = "mainErrorTextBox";
            this.mainErrorTextBox.Size = new System.Drawing.Size(171, 22);
            this.mainErrorTextBox.TabIndex = 1;
            this.mainErrorTextBox.TextChanged += new System.EventHandler(this.mainErrorTextBox_TextChanged);
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orLabel.Location = new System.Drawing.Point(229, 92);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(42, 24);
            this.orLabel.TabIndex = 2;
            this.orLabel.Text = "или";
            // 
            // accuracyClassLabel
            // 
            this.accuracyClassLabel.AutoSize = true;
            this.accuracyClassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accuracyClassLabel.Location = new System.Drawing.Point(192, 127);
            this.accuracyClassLabel.Name = "accuracyClassLabel";
            this.accuracyClassLabel.Size = new System.Drawing.Size(177, 16);
            this.accuracyClassLabel.TabIndex = 3;
            this.accuracyClassLabel.Text = "Выберете класс точности";
            // 
            // errorCharacterLabel
            // 
            this.errorCharacterLabel.AutoSize = true;
            this.errorCharacterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorCharacterLabel.Location = new System.Drawing.Point(192, 157);
            this.errorCharacterLabel.Name = "errorCharacterLabel";
            this.errorCharacterLabel.Size = new System.Drawing.Size(290, 16);
            this.errorCharacterLabel.TabIndex = 4;
            this.errorCharacterLabel.Text = "Выберете характер основной погрешности";
            // 
            // errorCharacterComboBox
            // 
            this.errorCharacterComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorCharacterComboBox.FormattingEnabled = true;
            this.errorCharacterComboBox.Location = new System.Drawing.Point(15, 154);
            this.errorCharacterComboBox.Name = "errorCharacterComboBox";
            this.errorCharacterComboBox.Size = new System.Drawing.Size(171, 24);
            this.errorCharacterComboBox.TabIndex = 5;
            this.errorCharacterComboBox.SelectedIndexChanged += new System.EventHandler(this.errorCharacterComboBox_SelectedIndexChanged);
            // 
            // accuracyClassComboBox
            // 
            this.accuracyClassComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accuracyClassComboBox.FormattingEnabled = true;
            this.accuracyClassComboBox.Location = new System.Drawing.Point(15, 124);
            this.accuracyClassComboBox.Name = "accuracyClassComboBox";
            this.accuracyClassComboBox.Size = new System.Drawing.Size(171, 24);
            this.accuracyClassComboBox.TabIndex = 6;
            this.accuracyClassComboBox.SelectedIndexChanged += new System.EventHandler(this.accuracyClassComboBox_SelectedIndexChanged);
            // 
            // OKbutton
            // 
            this.OKbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OKbutton.Location = new System.Drawing.Point(12, 195);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(233, 23);
            this.OKbutton.TabIndex = 7;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(251, 195);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(231, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // infoTopLabel
            // 
            this.infoTopLabel.AutoSize = true;
            this.infoTopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoTopLabel.Location = new System.Drawing.Point(9, 9);
            this.infoTopLabel.Name = "infoTopLabel";
            this.infoTopLabel.Size = new System.Drawing.Size(430, 16);
            this.infoTopLabel.TabIndex = 9;
            this.infoTopLabel.Text = "Укажите метрологические характеристики средства измерения";
            // 
            // infoBottomLabel
            // 
            this.infoBottomLabel.AutoSize = true;
            this.infoBottomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoBottomLabel.Location = new System.Drawing.Point(9, 25);
            this.infoBottomLabel.Name = "infoBottomLabel";
            this.infoBottomLabel.Size = new System.Drawing.Size(314, 16);
            this.infoBottomLabel.TabIndex = 10;
            this.infoBottomLabel.Text = "или введите значение основной погрешности.";
            // 
            // MainErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 230);
            this.Controls.Add(this.infoBottomLabel);
            this.Controls.Add(this.infoTopLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.accuracyClassComboBox);
            this.Controls.Add(this.errorCharacterComboBox);
            this.Controls.Add(this.errorCharacterLabel);
            this.Controls.Add(this.accuracyClassLabel);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.mainErrorTextBox);
            this.Controls.Add(this.MainErrorLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(510, 269);
            this.MinimumSize = new System.Drawing.Size(510, 269);
            this.Name = "MainErrorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainError";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainErrorLabel;
        private System.Windows.Forms.TextBox mainErrorTextBox;
        private System.Windows.Forms.Label orLabel;
        private System.Windows.Forms.Label accuracyClassLabel;
        private System.Windows.Forms.Label errorCharacterLabel;
        private System.Windows.Forms.ComboBox errorCharacterComboBox;
        private System.Windows.Forms.ComboBox accuracyClassComboBox;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label infoTopLabel;
        private System.Windows.Forms.Label infoBottomLabel;
    }
}