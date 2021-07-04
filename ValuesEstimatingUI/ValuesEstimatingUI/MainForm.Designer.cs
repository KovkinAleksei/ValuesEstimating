namespace ValuesEstimatingUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MeasurementTextBox = new System.Windows.Forms.TextBox();
            this.probabilityLabel = new System.Windows.Forms.Label();
            this.processButton = new System.Windows.Forms.Button();
            this.measurementLabel = new System.Windows.Forms.Label();
            this.probabilityComboBox = new System.Windows.Forms.ComboBox();
            this.additionalErrorButton = new System.Windows.Forms.Button();
            this.mainErrorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MeasurementTextBox
            // 
            this.MeasurementTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MeasurementTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MeasurementTextBox.Location = new System.Drawing.Point(12, 28);
            this.MeasurementTextBox.Multiline = true;
            this.MeasurementTextBox.Name = "MeasurementTextBox";
            this.MeasurementTextBox.Size = new System.Drawing.Size(763, 120);
            this.MeasurementTextBox.TabIndex = 0;
            this.MeasurementTextBox.TextChanged += new System.EventHandler(this.MeasurementTextBox_TextChanged);
            // 
            // probabilityLabel
            // 
            this.probabilityLabel.AutoSize = true;
            this.probabilityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.probabilityLabel.Location = new System.Drawing.Point(235, 157);
            this.probabilityLabel.Name = "probabilityLabel";
            this.probabilityLabel.Size = new System.Drawing.Size(196, 16);
            this.probabilityLabel.TabIndex = 4;
            this.probabilityLabel.Text = "Доверительная вероятность";
            // 
            // processButton
            // 
            this.processButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.processButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.processButton.Location = new System.Drawing.Point(12, 278);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(101, 37);
            this.processButton.TabIndex = 12;
            this.processButton.Text = "Ввод";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // measurementLabel
            // 
            this.measurementLabel.AutoSize = true;
            this.measurementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.measurementLabel.Location = new System.Drawing.Point(12, 9);
            this.measurementLabel.Name = "measurementLabel";
            this.measurementLabel.Size = new System.Drawing.Size(736, 16);
            this.measurementLabel.TabIndex = 13;
            this.measurementLabel.Text = "Введите значения результатов измерений. Числа вводятся через пробел, дробная част" +
    "ь отделяется запятой.";
            // 
            // probabilityComboBox
            // 
            this.probabilityComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.probabilityComboBox.FormattingEnabled = true;
            this.probabilityComboBox.Location = new System.Drawing.Point(12, 154);
            this.probabilityComboBox.Name = "probabilityComboBox";
            this.probabilityComboBox.Size = new System.Drawing.Size(217, 24);
            this.probabilityComboBox.TabIndex = 19;
            // 
            // additionalErrorButton
            // 
            this.additionalErrorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.additionalErrorButton.Location = new System.Drawing.Point(12, 184);
            this.additionalErrorButton.Name = "additionalErrorButton";
            this.additionalErrorButton.Size = new System.Drawing.Size(217, 24);
            this.additionalErrorButton.TabIndex = 22;
            this.additionalErrorButton.Text = "Дополнительная погрешность";
            this.additionalErrorButton.UseVisualStyleBackColor = true;
            this.additionalErrorButton.Click += new System.EventHandler(this.additionalErrorButton_Click);
            // 
            // mainErrorButton
            // 
            this.mainErrorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainErrorButton.Location = new System.Drawing.Point(12, 214);
            this.mainErrorButton.Name = "mainErrorButton";
            this.mainErrorButton.Size = new System.Drawing.Size(217, 24);
            this.mainErrorButton.TabIndex = 23;
            this.mainErrorButton.Text = "Основная погрешность";
            this.mainErrorButton.UseVisualStyleBackColor = true;
            this.mainErrorButton.Click += new System.EventHandler(this.mainErrorButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 327);
            this.Controls.Add(this.mainErrorButton);
            this.Controls.Add(this.additionalErrorButton);
            this.Controls.Add(this.probabilityComboBox);
            this.Controls.Add(this.measurementLabel);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.probabilityLabel);
            this.Controls.Add(this.MeasurementTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 366);
            this.MinimumSize = new System.Drawing.Size(800, 366);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ValuesEstimating";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MeasurementTextBox;
        private System.Windows.Forms.Label probabilityLabel;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Label measurementLabel;
        private System.Windows.Forms.ComboBox probabilityComboBox;
        private System.Windows.Forms.Button additionalErrorButton;
        private System.Windows.Forms.Button mainErrorButton;
    }
}

