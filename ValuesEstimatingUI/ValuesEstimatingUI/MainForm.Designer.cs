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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.errorRate = new System.Windows.Forms.ToolStripMenuItem();
            this.accuracyClass = new System.Windows.Forms.ToolStripMenuItem();
            this.mainErrorRateTextBox = new System.Windows.Forms.TextBox();
            this.mainErrorRateLabel = new System.Windows.Forms.Label();
            this.probabilityLabel = new System.Windows.Forms.Label();
            this.additionalErrorLabel = new System.Windows.Forms.Label();
            this.additionalErrorTextBox = new System.Windows.Forms.TextBox();
            this.accuracyClassLabel = new System.Windows.Forms.Label();
            this.errorCharacterLabel = new System.Windows.Forms.Label();
            this.errorCharacterComboBox = new System.Windows.Forms.ComboBox();
            this.processButton = new System.Windows.Forms.Button();
            this.measurementLabel = new System.Windows.Forms.Label();
            this.missesLabel = new System.Windows.Forms.Label();
            this.errorLimitLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.accuracyClassComboBox = new System.Windows.Forms.ComboBox();
            this.probabilityComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MeasurementTextBox
            // 
            this.MeasurementTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MeasurementTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MeasurementTextBox.Location = new System.Drawing.Point(12, 75);
            this.MeasurementTextBox.Multiline = true;
            this.MeasurementTextBox.Name = "MeasurementTextBox";
            this.MeasurementTextBox.Size = new System.Drawing.Size(372, 474);
            this.MeasurementTextBox.TabIndex = 0;
            this.MeasurementTextBox.TextChanged += new System.EventHandler(this.MeasurementTextBox_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuToolStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuToolStrip
            // 
            this.MenuToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.errorRate,
            this.accuracyClass});
            this.MenuToolStrip.Name = "MenuToolStrip";
            this.MenuToolStrip.Size = new System.Drawing.Size(187, 20);
            this.MenuToolStrip.Text = "Способ обработки измерений";
            // 
            // errorRate
            // 
            this.errorRate.Name = "errorRate";
            this.errorRate.Size = new System.Drawing.Size(357, 22);
            this.errorRate.Text = "Основная инструментальная погрешность";
            this.errorRate.Click += new System.EventHandler(this.основнаяИнструментальнаяПогрешностьToolStripMenuItem_Click);
            // 
            // accuracyClass
            // 
            this.accuracyClass.Name = "accuracyClass";
            this.accuracyClass.Size = new System.Drawing.Size(357, 22);
            this.accuracyClass.Text = "Класс точности и характер основной погрешности";
            this.accuracyClass.Click += new System.EventHandler(this.accuracyClass_Click);
            // 
            // mainErrorRateTextBox
            // 
            this.mainErrorRateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mainErrorRateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainErrorRateTextBox.Location = new System.Drawing.Point(689, 131);
            this.mainErrorRateTextBox.Name = "mainErrorRateTextBox";
            this.mainErrorRateTextBox.Size = new System.Drawing.Size(283, 22);
            this.mainErrorRateTextBox.TabIndex = 2;
            this.mainErrorRateTextBox.TextChanged += new System.EventHandler(this.mainErrorRateTextBox_TextChanged);
            // 
            // mainErrorRateLabel
            // 
            this.mainErrorRateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mainErrorRateLabel.AutoSize = true;
            this.mainErrorRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainErrorRateLabel.Location = new System.Drawing.Point(397, 134);
            this.mainErrorRateLabel.Name = "mainErrorRateLabel";
            this.mainErrorRateLabel.Size = new System.Drawing.Size(286, 16);
            this.mainErrorRateLabel.TabIndex = 3;
            this.mainErrorRateLabel.Text = "Основная инструментальная погрешность";
            // 
            // probabilityLabel
            // 
            this.probabilityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.probabilityLabel.AutoSize = true;
            this.probabilityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.probabilityLabel.Location = new System.Drawing.Point(487, 78);
            this.probabilityLabel.Name = "probabilityLabel";
            this.probabilityLabel.Size = new System.Drawing.Size(196, 16);
            this.probabilityLabel.TabIndex = 4;
            this.probabilityLabel.Text = "Доверительная вероятность";
            // 
            // additionalErrorLabel
            // 
            this.additionalErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.additionalErrorLabel.AutoSize = true;
            this.additionalErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.additionalErrorLabel.Location = new System.Drawing.Point(478, 106);
            this.additionalErrorLabel.Name = "additionalErrorLabel";
            this.additionalErrorLabel.Size = new System.Drawing.Size(205, 16);
            this.additionalErrorLabel.TabIndex = 6;
            this.additionalErrorLabel.Text = "Дополнительная погрешность";
            // 
            // additionalErrorTextBox
            // 
            this.additionalErrorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.additionalErrorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.additionalErrorTextBox.Location = new System.Drawing.Point(689, 103);
            this.additionalErrorTextBox.Name = "additionalErrorTextBox";
            this.additionalErrorTextBox.Size = new System.Drawing.Size(283, 22);
            this.additionalErrorTextBox.TabIndex = 7;
            this.additionalErrorTextBox.TextChanged += new System.EventHandler(this.additionalErrorTextBox_TextChanged);
            // 
            // accuracyClassLabel
            // 
            this.accuracyClassLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.accuracyClassLabel.AutoSize = true;
            this.accuracyClassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accuracyClassLabel.Location = new System.Drawing.Point(573, 134);
            this.accuracyClassLabel.Name = "accuracyClassLabel";
            this.accuracyClassLabel.Size = new System.Drawing.Size(110, 16);
            this.accuracyClassLabel.TabIndex = 8;
            this.accuracyClassLabel.Text = "Класс точности";
            // 
            // errorCharacterLabel
            // 
            this.errorCharacterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.errorCharacterLabel.AutoSize = true;
            this.errorCharacterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorCharacterLabel.Location = new System.Drawing.Point(459, 162);
            this.errorCharacterLabel.Name = "errorCharacterLabel";
            this.errorCharacterLabel.Size = new System.Drawing.Size(224, 16);
            this.errorCharacterLabel.TabIndex = 10;
            this.errorCharacterLabel.Text = "Характер основной погрешности";
            // 
            // errorCharacterComboBox
            // 
            this.errorCharacterComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.errorCharacterComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorCharacterComboBox.FormattingEnabled = true;
            this.errorCharacterComboBox.Location = new System.Drawing.Point(689, 159);
            this.errorCharacterComboBox.Name = "errorCharacterComboBox";
            this.errorCharacterComboBox.Size = new System.Drawing.Size(283, 24);
            this.errorCharacterComboBox.TabIndex = 11;
            // 
            // processButton
            // 
            this.processButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.processButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.processButton.Location = new System.Drawing.Point(866, 189);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(106, 38);
            this.processButton.TabIndex = 12;
            this.processButton.Text = "Обработать";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // measurementLabel
            // 
            this.measurementLabel.AutoSize = true;
            this.measurementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.measurementLabel.Location = new System.Drawing.Point(12, 53);
            this.measurementLabel.Name = "measurementLabel";
            this.measurementLabel.Size = new System.Drawing.Size(127, 16);
            this.measurementLabel.TabIndex = 13;
            this.measurementLabel.Text = "Серия измерений ";
            // 
            // missesLabel
            // 
            this.missesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.missesLabel.AutoSize = true;
            this.missesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.missesLabel.Location = new System.Drawing.Point(390, 447);
            this.missesLabel.Name = "missesLabel";
            this.missesLabel.Size = new System.Drawing.Size(68, 16);
            this.missesLabel.TabIndex = 15;
            this.missesLabel.Text = "Промахи:";
            // 
            // errorLimitLabel
            // 
            this.errorLimitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.errorLimitLabel.AutoSize = true;
            this.errorLimitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLimitLabel.Location = new System.Drawing.Point(390, 489);
            this.errorLimitLabel.Name = "errorLimitLabel";
            this.errorLimitLabel.Size = new System.Drawing.Size(261, 16);
            this.errorLimitLabel.TabIndex = 16;
            this.errorLimitLabel.Text = "Доверительная граница погрешности: ";
            // 
            // resultLabel
            // 
            this.resultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.Location = new System.Drawing.Point(390, 533);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(156, 16);
            this.resultLabel.TabIndex = 17;
            this.resultLabel.Text = "Результат измерения:";
            // 
            // accuracyClassComboBox
            // 
            this.accuracyClassComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.accuracyClassComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accuracyClassComboBox.FormattingEnabled = true;
            this.accuracyClassComboBox.Location = new System.Drawing.Point(689, 129);
            this.accuracyClassComboBox.Name = "accuracyClassComboBox";
            this.accuracyClassComboBox.Size = new System.Drawing.Size(283, 24);
            this.accuracyClassComboBox.TabIndex = 18;
            // 
            // probabilityComboBox
            // 
            this.probabilityComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.probabilityComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.probabilityComboBox.FormattingEnabled = true;
            this.probabilityComboBox.Location = new System.Drawing.Point(689, 73);
            this.probabilityComboBox.Name = "probabilityComboBox";
            this.probabilityComboBox.Size = new System.Drawing.Size(283, 24);
            this.probabilityComboBox.TabIndex = 19;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.probabilityComboBox);
            this.Controls.Add(this.accuracyClassComboBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.errorLimitLabel);
            this.Controls.Add(this.missesLabel);
            this.Controls.Add(this.measurementLabel);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.errorCharacterComboBox);
            this.Controls.Add(this.errorCharacterLabel);
            this.Controls.Add(this.accuracyClassLabel);
            this.Controls.Add(this.additionalErrorTextBox);
            this.Controls.Add(this.additionalErrorLabel);
            this.Controls.Add(this.probabilityLabel);
            this.Controls.Add(this.mainErrorRateLabel);
            this.Controls.Add(this.mainErrorRateTextBox);
            this.Controls.Add(this.MeasurementTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "MainForm";
            this.Text = "ValuesEstimating";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MeasurementTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuToolStrip;
        private System.Windows.Forms.ToolStripMenuItem errorRate;
        private System.Windows.Forms.ToolStripMenuItem accuracyClass;
        private System.Windows.Forms.TextBox mainErrorRateTextBox;
        private System.Windows.Forms.Label mainErrorRateLabel;
        private System.Windows.Forms.Label probabilityLabel;
        private System.Windows.Forms.Label additionalErrorLabel;
        private System.Windows.Forms.TextBox additionalErrorTextBox;
        private System.Windows.Forms.Label accuracyClassLabel;
        private System.Windows.Forms.Label errorCharacterLabel;
        private System.Windows.Forms.ComboBox errorCharacterComboBox;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Label measurementLabel;
        private System.Windows.Forms.Label missesLabel;
        private System.Windows.Forms.Label errorLimitLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.ComboBox accuracyClassComboBox;
        private System.Windows.Forms.ComboBox probabilityComboBox;
    }
}

