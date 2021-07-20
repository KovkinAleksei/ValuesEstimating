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
            this.measurementTopLabel = new System.Windows.Forms.Label();
            this.probabilityComboBox = new System.Windows.Forms.ComboBox();
            this.additionalErrorButton = new System.Windows.Forms.Button();
            this.mainErrorButton = new System.Windows.Forms.Button();
            this.measurementBottomLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MeasurementTextBox
            // 
            this.MeasurementTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.MeasurementTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MeasurementTextBox.ForeColor = System.Drawing.Color.White;
            this.MeasurementTextBox.Location = new System.Drawing.Point(12, 67);
            this.MeasurementTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MeasurementTextBox.Multiline = true;
            this.MeasurementTextBox.Name = "MeasurementTextBox";
            this.MeasurementTextBox.Size = new System.Drawing.Size(555, 65);
            this.MeasurementTextBox.TabIndex = 0;
            this.MeasurementTextBox.TextChanged += new System.EventHandler(this.MeasurementTextBox_TextChanged);
            this.MeasurementTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCut);
            // 
            // probabilityLabel
            // 
            this.probabilityLabel.AutoSize = true;
            this.probabilityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.probabilityLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.probabilityLabel.Location = new System.Drawing.Point(12, 142);
            this.probabilityLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.probabilityLabel.Name = "probabilityLabel";
            this.probabilityLabel.Size = new System.Drawing.Size(196, 16);
            this.probabilityLabel.TabIndex = 4;
            this.probabilityLabel.Text = "Доверительная вероятность";
            // 
            // processButton
            // 
            this.processButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.processButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.processButton.Location = new System.Drawing.Point(12, 272);
            this.processButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(100, 27);
            this.processButton.TabIndex = 12;
            this.processButton.Text = "Ввод";
            this.processButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            this.processButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCut);
            // 
            // measurementTopLabel
            // 
            this.measurementTopLabel.AutoSize = true;
            this.measurementTopLabel.BackColor = System.Drawing.SystemColors.Control;
            this.measurementTopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.measurementTopLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.measurementTopLabel.Location = new System.Drawing.Point(12, 30);
            this.measurementTopLabel.Name = "measurementTopLabel";
            this.measurementTopLabel.Size = new System.Drawing.Size(500, 16);
            this.measurementTopLabel.TabIndex = 13;
            this.measurementTopLabel.Text = "Введите значения результатов измерений. Числа вводятся через пробел,";
            // 
            // probabilityComboBox
            // 
            this.probabilityComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.probabilityComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.probabilityComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.probabilityComboBox.FormattingEnabled = true;
            this.probabilityComboBox.Location = new System.Drawing.Point(12, 164);
            this.probabilityComboBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.probabilityComboBox.Name = "probabilityComboBox";
            this.probabilityComboBox.Size = new System.Drawing.Size(100, 24);
            this.probabilityComboBox.TabIndex = 19;
            this.probabilityComboBox.SelectedIndexChanged += new System.EventHandler(this.probabilityComboBox_SelectedIndexChanged);
            this.probabilityComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCut);
            // 
            // additionalErrorButton
            // 
            this.additionalErrorButton.BackColor = System.Drawing.SystemColors.Control;
            this.additionalErrorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.additionalErrorButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.additionalErrorButton.Location = new System.Drawing.Point(12, 198);
            this.additionalErrorButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.additionalErrorButton.Name = "additionalErrorButton";
            this.additionalErrorButton.Size = new System.Drawing.Size(220, 27);
            this.additionalErrorButton.TabIndex = 22;
            this.additionalErrorButton.Text = "Дополнительная погрешность";
            this.additionalErrorButton.UseVisualStyleBackColor = false;
            this.additionalErrorButton.Click += new System.EventHandler(this.additionalErrorButton_Click);
            this.additionalErrorButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCut);
            // 
            // mainErrorButton
            // 
            this.mainErrorButton.BackColor = System.Drawing.SystemColors.Control;
            this.mainErrorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainErrorButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mainErrorButton.Location = new System.Drawing.Point(12, 235);
            this.mainErrorButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.mainErrorButton.Name = "mainErrorButton";
            this.mainErrorButton.Size = new System.Drawing.Size(220, 27);
            this.mainErrorButton.TabIndex = 23;
            this.mainErrorButton.Text = "Основная погрешность";
            this.mainErrorButton.UseVisualStyleBackColor = false;
            this.mainErrorButton.Click += new System.EventHandler(this.mainErrorButton_Click);
            this.mainErrorButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCut);
            // 
            // measurementBottomLabel
            // 
            this.measurementBottomLabel.AutoSize = true;
            this.measurementBottomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.measurementBottomLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.measurementBottomLabel.Location = new System.Drawing.Point(9, 46);
            this.measurementBottomLabel.Name = "measurementBottomLabel";
            this.measurementBottomLabel.Size = new System.Drawing.Size(244, 16);
            this.measurementBottomLabel.TabIndex = 24;
            this.measurementBottomLabel.Text = " дробная часть отделяется запятой.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.помощьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(576, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(576, 311);
            this.Controls.Add(this.measurementBottomLabel);
            this.Controls.Add(this.mainErrorButton);
            this.Controls.Add(this.additionalErrorButton);
            this.Controls.Add(this.probabilityComboBox);
            this.Controls.Add(this.measurementTopLabel);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.probabilityLabel);
            this.Controls.Add(this.MeasurementTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(592, 350);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ValuesEstimating";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCut);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MeasurementTextBox;
        private System.Windows.Forms.Label probabilityLabel;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Label measurementTopLabel;
        private System.Windows.Forms.ComboBox probabilityComboBox;
        private System.Windows.Forms.Button additionalErrorButton;
        private System.Windows.Forms.Button mainErrorButton;
        private System.Windows.Forms.Label measurementBottomLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}

