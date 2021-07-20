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
            this.infoMiddleLabel = new System.Windows.Forms.Label();
            this.infoBottomLabel = new System.Windows.Forms.Label();
            this.normalizingValueTextBox = new System.Windows.Forms.TextBox();
            this.normalizingValueLabel = new System.Windows.Forms.Label();
            this.reducedErrorLabel = new System.Windows.Forms.Label();
            this.reducedErrorEndTextBox = new System.Windows.Forms.TextBox();
            this.reducedErrorBeginningTextBox = new System.Windows.Forms.TextBox();
            this.reducedErrorSeparatorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainErrorLabel
            // 
            this.MainErrorLabel.AutoSize = true;
            this.MainErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainErrorLabel.Location = new System.Drawing.Point(194, 76);
            this.MainErrorLabel.Name = "MainErrorLabel";
            this.MainErrorLabel.Size = new System.Drawing.Size(285, 16);
            this.MainErrorLabel.TabIndex = 0;
            this.MainErrorLabel.Text = "Введите значение основной погрешности";
            // 
            // mainErrorTextBox
            // 
            this.mainErrorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainErrorTextBox.Location = new System.Drawing.Point(17, 73);
            this.mainErrorTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.mainErrorTextBox.Name = "mainErrorTextBox";
            this.mainErrorTextBox.Size = new System.Drawing.Size(171, 22);
            this.mainErrorTextBox.TabIndex = 1;
            this.mainErrorTextBox.TextChanged += new System.EventHandler(this.mainErrorTextBox_TextChanged);
            this.mainErrorTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCut);
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orLabel.Location = new System.Drawing.Point(228, 95);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(42, 24);
            this.orLabel.TabIndex = 2;
            this.orLabel.Text = "или";
            // 
            // accuracyClassLabel
            // 
            this.accuracyClassLabel.AutoSize = true;
            this.accuracyClassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accuracyClassLabel.Location = new System.Drawing.Point(194, 123);
            this.accuracyClassLabel.Name = "accuracyClassLabel";
            this.accuracyClassLabel.Size = new System.Drawing.Size(177, 16);
            this.accuracyClassLabel.TabIndex = 3;
            this.accuracyClassLabel.Text = "Выберете класс точности";
            // 
            // errorCharacterLabel
            // 
            this.errorCharacterLabel.AutoSize = true;
            this.errorCharacterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorCharacterLabel.Location = new System.Drawing.Point(194, 157);
            this.errorCharacterLabel.Name = "errorCharacterLabel";
            this.errorCharacterLabel.Size = new System.Drawing.Size(290, 16);
            this.errorCharacterLabel.TabIndex = 4;
            this.errorCharacterLabel.Text = "Выберете характер основной погрешности";
            // 
            // errorCharacterComboBox
            // 
            this.errorCharacterComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorCharacterComboBox.FormattingEnabled = true;
            this.errorCharacterComboBox.Location = new System.Drawing.Point(17, 154);
            this.errorCharacterComboBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.errorCharacterComboBox.Name = "errorCharacterComboBox";
            this.errorCharacterComboBox.Size = new System.Drawing.Size(171, 24);
            this.errorCharacterComboBox.TabIndex = 5;
            this.errorCharacterComboBox.SelectedIndexChanged += new System.EventHandler(this.errorCharacterComboBox_SelectedIndexChanged);
            this.errorCharacterComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCut);
            // 
            // accuracyClassComboBox
            // 
            this.accuracyClassComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accuracyClassComboBox.FormattingEnabled = true;
            this.accuracyClassComboBox.Location = new System.Drawing.Point(17, 120);
            this.accuracyClassComboBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.accuracyClassComboBox.Name = "accuracyClassComboBox";
            this.accuracyClassComboBox.Size = new System.Drawing.Size(171, 24);
            this.accuracyClassComboBox.TabIndex = 6;
            this.accuracyClassComboBox.SelectedIndexChanged += new System.EventHandler(this.accuracyClassComboBox_SelectedIndexChanged);
            this.accuracyClassComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCut);
            // 
            // OKbutton
            // 
            this.OKbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.OKbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OKbutton.Location = new System.Drawing.Point(17, 290);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(100, 27);
            this.OKbutton.TabIndex = 7;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            this.OKbutton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCut);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(125, 290);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(5, 5, 3, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 27);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            this.cancelButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCut);
            // 
            // infoTopLabel
            // 
            this.infoTopLabel.AutoSize = true;
            this.infoTopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoTopLabel.Location = new System.Drawing.Point(14, 9);
            this.infoTopLabel.Name = "infoTopLabel";
            this.infoTopLabel.Size = new System.Drawing.Size(430, 16);
            this.infoTopLabel.TabIndex = 9;
            this.infoTopLabel.Text = "Укажите метрологические характеристики средства измерения";
            // 
            // infoMiddleLabel
            // 
            this.infoMiddleLabel.AutoSize = true;
            this.infoMiddleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoMiddleLabel.Location = new System.Drawing.Point(14, 25);
            this.infoMiddleLabel.Name = "infoMiddleLabel";
            this.infoMiddleLabel.Size = new System.Drawing.Size(426, 16);
            this.infoMiddleLabel.TabIndex = 10;
            this.infoMiddleLabel.Text = "для автоматического расчёта значения основной погрешности";
            // 
            // infoBottomLabel
            // 
            this.infoBottomLabel.AutoSize = true;
            this.infoBottomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoBottomLabel.Location = new System.Drawing.Point(14, 41);
            this.infoBottomLabel.Name = "infoBottomLabel";
            this.infoBottomLabel.Size = new System.Drawing.Size(179, 16);
            this.infoBottomLabel.TabIndex = 11;
            this.infoBottomLabel.Text = "или введите его вручную.";
            // 
            // normalizingValueTextBox
            // 
            this.normalizingValueTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.normalizingValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.normalizingValueTextBox.Location = new System.Drawing.Point(17, 188);
            this.normalizingValueTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.normalizingValueTextBox.Name = "normalizingValueTextBox";
            this.normalizingValueTextBox.Size = new System.Drawing.Size(171, 22);
            this.normalizingValueTextBox.TabIndex = 12;
            this.normalizingValueTextBox.TextChanged += new System.EventHandler(this.normalizingValueTextBox_TextChanged);
            this.normalizingValueTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCut);
            // 
            // normalizingValueLabel
            // 
            this.normalizingValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.normalizingValueLabel.AutoSize = true;
            this.normalizingValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.normalizingValueLabel.Location = new System.Drawing.Point(194, 191);
            this.normalizingValueLabel.Name = "normalizingValueLabel";
            this.normalizingValueLabel.Size = new System.Drawing.Size(294, 16);
            this.normalizingValueLabel.TabIndex = 13;
            this.normalizingValueLabel.Text = "Введите значение нормирующей величины";
            // 
            // reducedErrorLabel
            // 
            this.reducedErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.reducedErrorLabel.AutoSize = true;
            this.reducedErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reducedErrorLabel.Location = new System.Drawing.Point(14, 236);
            this.reducedErrorLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.reducedErrorLabel.Name = "reducedErrorLabel";
            this.reducedErrorLabel.Size = new System.Drawing.Size(480, 16);
            this.reducedErrorLabel.TabIndex = 14;
            this.reducedErrorLabel.Text = "Введите значение приведённой погрешности в начале и в конце шкалы";
            // 
            // reducedErrorEndTextBox
            // 
            this.reducedErrorEndTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.reducedErrorEndTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reducedErrorEndTextBox.Location = new System.Drawing.Point(113, 258);
            this.reducedErrorEndTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.reducedErrorEndTextBox.Name = "reducedErrorEndTextBox";
            this.reducedErrorEndTextBox.Size = new System.Drawing.Size(75, 22);
            this.reducedErrorEndTextBox.TabIndex = 17;
            this.reducedErrorEndTextBox.TextChanged += new System.EventHandler(this.reducedErrorEndTextBox_TextChanged);
            this.reducedErrorEndTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCut);
            // 
            // reducedErrorBeginningTextBox
            // 
            this.reducedErrorBeginningTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.reducedErrorBeginningTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reducedErrorBeginningTextBox.Location = new System.Drawing.Point(17, 258);
            this.reducedErrorBeginningTextBox.Name = "reducedErrorBeginningTextBox";
            this.reducedErrorBeginningTextBox.Size = new System.Drawing.Size(75, 22);
            this.reducedErrorBeginningTextBox.TabIndex = 18;
            this.reducedErrorBeginningTextBox.TextChanged += new System.EventHandler(this.reducedErrorBeginningTextBox_TextChanged);
            this.reducedErrorBeginningTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCut);
            // 
            // reducedErrorSeparatorLabel
            // 
            this.reducedErrorSeparatorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.reducedErrorSeparatorLabel.AutoSize = true;
            this.reducedErrorSeparatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reducedErrorSeparatorLabel.Location = new System.Drawing.Point(93, 255);
            this.reducedErrorSeparatorLabel.Name = "reducedErrorSeparatorLabel";
            this.reducedErrorSeparatorLabel.Size = new System.Drawing.Size(20, 29);
            this.reducedErrorSeparatorLabel.TabIndex = 19;
            this.reducedErrorSeparatorLabel.Text = "/";
            // 
            // MainErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 331);
            this.Controls.Add(this.reducedErrorSeparatorLabel);
            this.Controls.Add(this.reducedErrorBeginningTextBox);
            this.Controls.Add(this.reducedErrorEndTextBox);
            this.Controls.Add(this.reducedErrorLabel);
            this.Controls.Add(this.normalizingValueLabel);
            this.Controls.Add(this.normalizingValueTextBox);
            this.Controls.Add(this.infoBottomLabel);
            this.Controls.Add(this.infoMiddleLabel);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainErrorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Основная погрешность";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCut);
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
        private System.Windows.Forms.Label infoMiddleLabel;
        private System.Windows.Forms.Label infoBottomLabel;
        private System.Windows.Forms.TextBox normalizingValueTextBox;
        private System.Windows.Forms.Label normalizingValueLabel;
        private System.Windows.Forms.Label reducedErrorLabel;
        private System.Windows.Forms.TextBox reducedErrorEndTextBox;
        private System.Windows.Forms.TextBox reducedErrorBeginningTextBox;
        private System.Windows.Forms.Label reducedErrorSeparatorLabel;
    }
}