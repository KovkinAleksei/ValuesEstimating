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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainErrorForm));
            this.infoTopLabel = new MaterialSkin.Controls.MaterialLabel();
            this.infoMiddleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.infoBottomLabel = new MaterialSkin.Controls.MaterialLabel();
            this.mainErrorTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.errorCharacterComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.accuracyClassLabel = new MaterialSkin.Controls.MaterialLabel();
            this.accuracyClassComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.errorCharacterLabel = new MaterialSkin.Controls.MaterialLabel();
            this.orLabel = new MaterialSkin.Controls.MaterialLabel();
            this.normalizingValueTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.mainErrorLabel = new MaterialSkin.Controls.MaterialLabel();
            this.normalizingValueLabel = new MaterialSkin.Controls.MaterialLabel();
            this.reducedErrorBeginningTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.reducedErrorEndTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.reducedErrorSeparatorLabel = new MaterialSkin.Controls.MaterialLabel();
            this.reducedErrorLabel = new MaterialSkin.Controls.MaterialLabel();
            this.OKbutton = new MaterialSkin.Controls.MaterialButton();
            this.cancelButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // infoTopLabel
            // 
            this.infoTopLabel.AutoSize = true;
            this.infoTopLabel.Depth = 0;
            this.infoTopLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.infoTopLabel.Location = new System.Drawing.Point(12, 73);
            this.infoTopLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.infoTopLabel.Name = "infoTopLabel";
            this.infoTopLabel.Size = new System.Drawing.Size(484, 19);
            this.infoTopLabel.TabIndex = 20;
            this.infoTopLabel.Text = "Укажите метрологические характеристики средства измерения";
            // 
            // infoMiddleLabel
            // 
            this.infoMiddleLabel.AutoSize = true;
            this.infoMiddleLabel.Depth = 0;
            this.infoMiddleLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.infoMiddleLabel.Location = new System.Drawing.Point(12, 92);
            this.infoMiddleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.infoMiddleLabel.Name = "infoMiddleLabel";
            this.infoMiddleLabel.Size = new System.Drawing.Size(480, 19);
            this.infoMiddleLabel.TabIndex = 21;
            this.infoMiddleLabel.Text = "для автоматического расчёта значения основной погрешности";
            // 
            // infoBottomLabel
            // 
            this.infoBottomLabel.AutoSize = true;
            this.infoBottomLabel.Depth = 0;
            this.infoBottomLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.infoBottomLabel.Location = new System.Drawing.Point(12, 111);
            this.infoBottomLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.infoBottomLabel.Name = "infoBottomLabel";
            this.infoBottomLabel.Size = new System.Drawing.Size(194, 19);
            this.infoBottomLabel.TabIndex = 22;
            this.infoBottomLabel.Text = "или введите его вручную.";
            // 
            // mainErrorTextBox
            // 
            this.mainErrorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainErrorTextBox.Depth = 0;
            this.mainErrorTextBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.mainErrorTextBox.Location = new System.Drawing.Point(15, 141);
            this.mainErrorTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.mainErrorTextBox.MaxLength = 50;
            this.mainErrorTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.mainErrorTextBox.Multiline = false;
            this.mainErrorTextBox.Name = "mainErrorTextBox";
            this.mainErrorTextBox.Size = new System.Drawing.Size(217, 50);
            this.mainErrorTextBox.TabIndex = 23;
            this.mainErrorTextBox.Text = "";
            this.mainErrorTextBox.TextChanged += new System.EventHandler(this.mainErrorTextBox_TextChanged);
            this.mainErrorTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCut);
            // 
            // errorCharacterComboBox
            // 
            this.errorCharacterComboBox.AutoResize = false;
            this.errorCharacterComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.errorCharacterComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.errorCharacterComboBox.Depth = 0;
            this.errorCharacterComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.errorCharacterComboBox.DropDownHeight = 174;
            this.errorCharacterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.errorCharacterComboBox.DropDownWidth = 121;
            this.errorCharacterComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.errorCharacterComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorCharacterComboBox.FormattingEnabled = true;
            this.errorCharacterComboBox.IntegralHeight = false;
            this.errorCharacterComboBox.ItemHeight = 43;
            this.errorCharacterComboBox.Location = new System.Drawing.Point(15, 295);
            this.errorCharacterComboBox.MaxDropDownItems = 4;
            this.errorCharacterComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.errorCharacterComboBox.Name = "errorCharacterComboBox";
            this.errorCharacterComboBox.Size = new System.Drawing.Size(217, 49);
            this.errorCharacterComboBox.TabIndex = 24;
            this.errorCharacterComboBox.SelectedIndexChanged += new System.EventHandler(this.errorCharacterComboBox_SelectedIndexChanged);
            this.errorCharacterComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCut);
            // 
            // accuracyClassLabel
            // 
            this.accuracyClassLabel.AutoSize = true;
            this.accuracyClassLabel.Depth = 0;
            this.accuracyClassLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.accuracyClassLabel.Location = new System.Drawing.Point(241, 252);
            this.accuracyClassLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.accuracyClassLabel.Name = "accuracyClassLabel";
            this.accuracyClassLabel.Size = new System.Drawing.Size(193, 19);
            this.accuracyClassLabel.TabIndex = 25;
            this.accuracyClassLabel.Text = "Выберете класс точности";
            // 
            // accuracyClassComboBox
            // 
            this.accuracyClassComboBox.AutoResize = false;
            this.accuracyClassComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.accuracyClassComboBox.Depth = 0;
            this.accuracyClassComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.accuracyClassComboBox.DropDownHeight = 174;
            this.accuracyClassComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accuracyClassComboBox.DropDownWidth = 121;
            this.accuracyClassComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.accuracyClassComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.accuracyClassComboBox.FormattingEnabled = true;
            this.accuracyClassComboBox.IntegralHeight = false;
            this.accuracyClassComboBox.ItemHeight = 43;
            this.accuracyClassComboBox.Location = new System.Drawing.Point(15, 237);
            this.accuracyClassComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.accuracyClassComboBox.MaxDropDownItems = 4;
            this.accuracyClassComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.accuracyClassComboBox.Name = "accuracyClassComboBox";
            this.accuracyClassComboBox.Size = new System.Drawing.Size(217, 49);
            this.accuracyClassComboBox.TabIndex = 26;
            this.accuracyClassComboBox.SelectedIndexChanged += new System.EventHandler(this.accuracyClassComboBox_SelectedIndexChanged);
            this.accuracyClassComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCut);
            // 
            // errorCharacterLabel
            // 
            this.errorCharacterLabel.AutoSize = true;
            this.errorCharacterLabel.Depth = 0;
            this.errorCharacterLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.errorCharacterLabel.Location = new System.Drawing.Point(241, 311);
            this.errorCharacterLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.errorCharacterLabel.Name = "errorCharacterLabel";
            this.errorCharacterLabel.Size = new System.Drawing.Size(323, 19);
            this.errorCharacterLabel.TabIndex = 27;
            this.errorCharacterLabel.Text = "Выберете характер основной погрешности";
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Depth = 0;
            this.orLabel.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.orLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.orLabel.Location = new System.Drawing.Point(277, 190);
            this.orLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(61, 41);
            this.orLabel.TabIndex = 28;
            this.orLabel.Text = "или";
            // 
            // normalizingValueTextBox
            // 
            this.normalizingValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.normalizingValueTextBox.Depth = 0;
            this.normalizingValueTextBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.normalizingValueTextBox.Location = new System.Drawing.Point(14, 353);
            this.normalizingValueTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.normalizingValueTextBox.MaxLength = 50;
            this.normalizingValueTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.normalizingValueTextBox.Multiline = false;
            this.normalizingValueTextBox.Name = "normalizingValueTextBox";
            this.normalizingValueTextBox.Size = new System.Drawing.Size(217, 50);
            this.normalizingValueTextBox.TabIndex = 29;
            this.normalizingValueTextBox.Text = "";
            this.normalizingValueTextBox.TextChanged += new System.EventHandler(this.normalizingValueTextBox_TextChanged);
            this.normalizingValueTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCut);
            // 
            // mainErrorLabel
            // 
            this.mainErrorLabel.AutoSize = true;
            this.mainErrorLabel.Depth = 0;
            this.mainErrorLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mainErrorLabel.Location = new System.Drawing.Point(240, 156);
            this.mainErrorLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainErrorLabel.Name = "mainErrorLabel";
            this.mainErrorLabel.Size = new System.Drawing.Size(313, 19);
            this.mainErrorLabel.TabIndex = 30;
            this.mainErrorLabel.Text = "Введите значение основной погрешности";
            // 
            // normalizingValueLabel
            // 
            this.normalizingValueLabel.AutoSize = true;
            this.normalizingValueLabel.Depth = 0;
            this.normalizingValueLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.normalizingValueLabel.Location = new System.Drawing.Point(240, 368);
            this.normalizingValueLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.normalizingValueLabel.Name = "normalizingValueLabel";
            this.normalizingValueLabel.Size = new System.Drawing.Size(326, 19);
            this.normalizingValueLabel.TabIndex = 31;
            this.normalizingValueLabel.Text = "Введите значение нормирующей величины";
            // 
            // reducedErrorBeginningTextBox
            // 
            this.reducedErrorBeginningTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reducedErrorBeginningTextBox.Depth = 0;
            this.reducedErrorBeginningTextBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.reducedErrorBeginningTextBox.Location = new System.Drawing.Point(14, 444);
            this.reducedErrorBeginningTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.reducedErrorBeginningTextBox.MaxLength = 50;
            this.reducedErrorBeginningTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.reducedErrorBeginningTextBox.Multiline = false;
            this.reducedErrorBeginningTextBox.Name = "reducedErrorBeginningTextBox";
            this.reducedErrorBeginningTextBox.Size = new System.Drawing.Size(93, 50);
            this.reducedErrorBeginningTextBox.TabIndex = 32;
            this.reducedErrorBeginningTextBox.Text = "";
            this.reducedErrorBeginningTextBox.TextChanged += new System.EventHandler(this.reducedErrorBeginningTextBox_TextChanged);
            this.reducedErrorBeginningTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCut);
            // 
            // reducedErrorEndTextBox
            // 
            this.reducedErrorEndTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reducedErrorEndTextBox.Depth = 0;
            this.reducedErrorEndTextBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.reducedErrorEndTextBox.Location = new System.Drawing.Point(138, 443);
            this.reducedErrorEndTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.reducedErrorEndTextBox.MaxLength = 50;
            this.reducedErrorEndTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.reducedErrorEndTextBox.Multiline = false;
            this.reducedErrorEndTextBox.Name = "reducedErrorEndTextBox";
            this.reducedErrorEndTextBox.Size = new System.Drawing.Size(93, 50);
            this.reducedErrorEndTextBox.TabIndex = 33;
            this.reducedErrorEndTextBox.Text = "";
            this.reducedErrorEndTextBox.VisibleChanged += new System.EventHandler(this.reducedErrorEndTextBox_TextChanged);
            this.reducedErrorEndTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCut);
            // 
            // reducedErrorSeparatorLabel
            // 
            this.reducedErrorSeparatorLabel.AutoSize = true;
            this.reducedErrorSeparatorLabel.Depth = 0;
            this.reducedErrorSeparatorLabel.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.reducedErrorSeparatorLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.reducedErrorSeparatorLabel.Location = new System.Drawing.Point(113, 438);
            this.reducedErrorSeparatorLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.reducedErrorSeparatorLabel.Name = "reducedErrorSeparatorLabel";
            this.reducedErrorSeparatorLabel.Size = new System.Drawing.Size(21, 58);
            this.reducedErrorSeparatorLabel.TabIndex = 34;
            this.reducedErrorSeparatorLabel.Text = "/";
            // 
            // reducedErrorLabel
            // 
            this.reducedErrorLabel.AutoSize = true;
            this.reducedErrorLabel.Depth = 0;
            this.reducedErrorLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.reducedErrorLabel.Location = new System.Drawing.Point(13, 419);
            this.reducedErrorLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.reducedErrorLabel.Name = "reducedErrorLabel";
            this.reducedErrorLabel.Size = new System.Drawing.Size(540, 19);
            this.reducedErrorLabel.TabIndex = 35;
            this.reducedErrorLabel.Text = "Введите значение приведённой погрешности в начале и в конце шкалы";
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
            this.OKbutton.Location = new System.Drawing.Point(385, 504);
            this.OKbutton.Margin = new System.Windows.Forms.Padding(6);
            this.OKbutton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(100, 36);
            this.OKbutton.TabIndex = 36;
            this.OKbutton.Text = "OK";
            this.OKbutton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.OKbutton.UseAccentColor = false;
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            this.OKbutton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCut);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelButton.AutoSize = false;
            this.cancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelButton.Depth = 0;
            this.cancelButton.DrawShadows = true;
            this.cancelButton.HighEmphasis = true;
            this.cancelButton.Icon = null;
            this.cancelButton.Location = new System.Drawing.Point(497, 504);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(6);
            this.cancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 36);
            this.cancelButton.TabIndex = 37;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cancelButton.UseAccentColor = false;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            this.cancelButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCut);
            // 
            // MainErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 555);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.reducedErrorLabel);
            this.Controls.Add(this.reducedErrorSeparatorLabel);
            this.Controls.Add(this.reducedErrorEndTextBox);
            this.Controls.Add(this.reducedErrorBeginningTextBox);
            this.Controls.Add(this.normalizingValueLabel);
            this.Controls.Add(this.mainErrorLabel);
            this.Controls.Add(this.normalizingValueTextBox);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.errorCharacterLabel);
            this.Controls.Add(this.accuracyClassComboBox);
            this.Controls.Add(this.accuracyClassLabel);
            this.Controls.Add(this.errorCharacterComboBox);
            this.Controls.Add(this.mainErrorTextBox);
            this.Controls.Add(this.infoBottomLabel);
            this.Controls.Add(this.infoMiddleLabel);
            this.Controls.Add(this.infoTopLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainErrorForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Основная погрешность";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCut);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel infoTopLabel;
        private MaterialSkin.Controls.MaterialLabel infoMiddleLabel;
        private MaterialSkin.Controls.MaterialLabel infoBottomLabel;
        private MaterialSkin.Controls.MaterialTextBox mainErrorTextBox;
        private MaterialSkin.Controls.MaterialComboBox errorCharacterComboBox;
        private MaterialSkin.Controls.MaterialLabel accuracyClassLabel;
        private MaterialSkin.Controls.MaterialComboBox accuracyClassComboBox;
        private MaterialSkin.Controls.MaterialLabel errorCharacterLabel;
        private MaterialSkin.Controls.MaterialLabel orLabel;
        private MaterialSkin.Controls.MaterialTextBox normalizingValueTextBox;
        private MaterialSkin.Controls.MaterialLabel mainErrorLabel;
        private MaterialSkin.Controls.MaterialLabel normalizingValueLabel;
        private MaterialSkin.Controls.MaterialTextBox reducedErrorBeginningTextBox;
        private MaterialSkin.Controls.MaterialTextBox reducedErrorEndTextBox;
        private MaterialSkin.Controls.MaterialLabel reducedErrorSeparatorLabel;
        private MaterialSkin.Controls.MaterialLabel reducedErrorLabel;
        private MaterialSkin.Controls.MaterialButton OKbutton;
        private MaterialSkin.Controls.MaterialButton cancelButton;
    }
}