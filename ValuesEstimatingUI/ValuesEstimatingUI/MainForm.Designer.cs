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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.InfoLabel = new MaterialSkin.Controls.MaterialLabel();
            this.infoLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.probabiilityLabel = new MaterialSkin.Controls.MaterialLabel();
            this.probabilityComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.additionalErrorButton = new MaterialSkin.Controls.MaterialButton();
            this.mainErrorButton = new MaterialSkin.Controls.MaterialButton();
            this.processButton = new MaterialSkin.Controls.MaterialButton();
            this.aboutButton = new MaterialSkin.Controls.MaterialButton();
            this.helpButton = new MaterialSkin.Controls.MaterialButton();
            this.quitButton = new MaterialSkin.Controls.MaterialButton();
            this.MenuDevider = new MaterialSkin.Controls.MaterialDivider();
            this.MeasurementTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Depth = 0;
            this.InfoLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.InfoLabel.Location = new System.Drawing.Point(12, 109);
            this.InfoLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(670, 19);
            this.InfoLabel.TabIndex = 25;
            this.InfoLabel.Text = "Введите значения результатов измерений. Числа вводятся через пробел, дробная част" +
    "ь";
            // 
            // infoLabel2
            // 
            this.infoLabel2.AutoSize = true;
            this.infoLabel2.Depth = 0;
            this.infoLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.infoLabel2.Location = new System.Drawing.Point(14, 128);
            this.infoLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.infoLabel2.Name = "infoLabel2";
            this.infoLabel2.Size = new System.Drawing.Size(156, 19);
            this.infoLabel2.TabIndex = 26;
            this.infoLabel2.Text = "отделяется запятой.";
            // 
            // probabiilityLabel
            // 
            this.probabiilityLabel.AutoSize = true;
            this.probabiilityLabel.Depth = 0;
            this.probabiilityLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.probabiilityLabel.Location = new System.Drawing.Point(14, 208);
            this.probabiilityLabel.Margin = new System.Windows.Forms.Padding(5);
            this.probabiilityLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.probabiilityLabel.Name = "probabiilityLabel";
            this.probabiilityLabel.Size = new System.Drawing.Size(217, 19);
            this.probabiilityLabel.TabIndex = 29;
            this.probabiilityLabel.Text = "Доверительная вероятность";
            // 
            // probabilityComboBox
            // 
            this.probabilityComboBox.AutoResize = false;
            this.probabilityComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.probabilityComboBox.Depth = 0;
            this.probabilityComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.probabilityComboBox.DropDownHeight = 174;
            this.probabilityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.probabilityComboBox.DropDownWidth = 121;
            this.probabilityComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.probabilityComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.probabilityComboBox.FormattingEnabled = true;
            this.probabilityComboBox.IntegralHeight = false;
            this.probabilityComboBox.ItemHeight = 43;
            this.probabilityComboBox.Location = new System.Drawing.Point(15, 234);
            this.probabilityComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.probabilityComboBox.MaxDropDownItems = 4;
            this.probabilityComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.probabilityComboBox.Name = "probabilityComboBox";
            this.probabilityComboBox.Size = new System.Drawing.Size(121, 49);
            this.probabilityComboBox.TabIndex = 30;
            this.probabilityComboBox.SelectedIndexChanged += new System.EventHandler(this.probabilityComboBox_SelectedIndexChanged);
            this.probabilityComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCut);
            // 
            // additionalErrorButton
            // 
            this.additionalErrorButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.additionalErrorButton.Depth = 0;
            this.additionalErrorButton.DrawShadows = true;
            this.additionalErrorButton.HighEmphasis = true;
            this.additionalErrorButton.Icon = null;
            this.additionalErrorButton.Location = new System.Drawing.Point(15, 294);
            this.additionalErrorButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.additionalErrorButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.additionalErrorButton.Name = "additionalErrorButton";
            this.additionalErrorButton.Size = new System.Drawing.Size(275, 36);
            this.additionalErrorButton.TabIndex = 31;
            this.additionalErrorButton.Text = "Дополнительная погрешность";
            this.additionalErrorButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.additionalErrorButton.UseAccentColor = false;
            this.additionalErrorButton.UseVisualStyleBackColor = true;
            this.additionalErrorButton.Click += new System.EventHandler(this.additionalErrorButton_Click);
            this.additionalErrorButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCut);
            // 
            // mainErrorButton
            // 
            this.mainErrorButton.AutoSize = false;
            this.mainErrorButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainErrorButton.Depth = 0;
            this.mainErrorButton.DrawShadows = true;
            this.mainErrorButton.HighEmphasis = true;
            this.mainErrorButton.Icon = null;
            this.mainErrorButton.Location = new System.Drawing.Point(15, 342);
            this.mainErrorButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mainErrorButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainErrorButton.Name = "mainErrorButton";
            this.mainErrorButton.Size = new System.Drawing.Size(275, 36);
            this.mainErrorButton.TabIndex = 32;
            this.mainErrorButton.Text = "Основная погрешность";
            this.mainErrorButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mainErrorButton.UseAccentColor = false;
            this.mainErrorButton.UseVisualStyleBackColor = true;
            this.mainErrorButton.Click += new System.EventHandler(this.mainErrorButton_Click);
            this.mainErrorButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCut);
            // 
            // processButton
            // 
            this.processButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.processButton.AutoSize = false;
            this.processButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.processButton.Depth = 0;
            this.processButton.DrawShadows = true;
            this.processButton.HighEmphasis = true;
            this.processButton.Icon = null;
            this.processButton.Location = new System.Drawing.Point(643, 363);
            this.processButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.processButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(100, 36);
            this.processButton.TabIndex = 33;
            this.processButton.Text = "Ввод";
            this.processButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.processButton.UseAccentColor = false;
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            this.processButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCut);
            // 
            // aboutButton
            // 
            this.aboutButton.AutoSize = false;
            this.aboutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.aboutButton.Depth = 0;
            this.aboutButton.DrawShadows = true;
            this.aboutButton.HighEmphasis = true;
            this.aboutButton.Icon = null;
            this.aboutButton.Location = new System.Drawing.Point(2, 66);
            this.aboutButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.aboutButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(112, 23);
            this.aboutButton.TabIndex = 35;
            this.aboutButton.Text = "О программе";
            this.aboutButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.aboutButton.UseAccentColor = false;
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            this.aboutButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCut);
            // 
            // helpButton
            // 
            this.helpButton.AutoSize = false;
            this.helpButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.helpButton.BackColor = System.Drawing.SystemColors.Control;
            this.helpButton.Depth = 0;
            this.helpButton.DrawShadows = true;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.HighEmphasis = true;
            this.helpButton.Icon = null;
            this.helpButton.Location = new System.Drawing.Point(117, 66);
            this.helpButton.Margin = new System.Windows.Forms.Padding(2);
            this.helpButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(112, 23);
            this.helpButton.TabIndex = 36;
            this.helpButton.Text = "Помощь";
            this.helpButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.helpButton.UseAccentColor = false;
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            this.helpButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCut);
            // 
            // quitButton
            // 
            this.quitButton.AutoSize = false;
            this.quitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.quitButton.BackColor = System.Drawing.SystemColors.Control;
            this.quitButton.Depth = 0;
            this.quitButton.DrawShadows = true;
            this.quitButton.HighEmphasis = true;
            this.quitButton.Icon = null;
            this.quitButton.Location = new System.Drawing.Point(233, 66);
            this.quitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.quitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(112, 23);
            this.quitButton.TabIndex = 37;
            this.quitButton.Text = "Выход";
            this.quitButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.quitButton.UseAccentColor = false;
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            this.quitButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCut);
            // 
            // MenuDevider
            // 
            this.MenuDevider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MenuDevider.Depth = 0;
            this.MenuDevider.Location = new System.Drawing.Point(-14, 64);
            this.MenuDevider.MouseState = MaterialSkin.MouseState.HOVER;
            this.MenuDevider.Name = "MenuDevider";
            this.MenuDevider.Size = new System.Drawing.Size(796, 25);
            this.MenuDevider.TabIndex = 38;
            // 
            // MeasurementTextBox
            // 
            this.MeasurementTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MeasurementTextBox.Depth = 0;
            this.MeasurementTextBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.MeasurementTextBox.Location = new System.Drawing.Point(12, 150);
            this.MeasurementTextBox.MaxLength = 500;
            this.MeasurementTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.MeasurementTextBox.Multiline = false;
            this.MeasurementTextBox.Name = "MeasurementTextBox";
            this.MeasurementTextBox.Size = new System.Drawing.Size(731, 50);
            this.MeasurementTextBox.TabIndex = 27;
            this.MeasurementTextBox.Text = "";
            this.MeasurementTextBox.TextChanged += new System.EventHandler(this.MeasurementTextBox_TextChanged);
            this.MeasurementTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCut);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(756, 413);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.mainErrorButton);
            this.Controls.Add(this.additionalErrorButton);
            this.Controls.Add(this.probabilityComboBox);
            this.Controls.Add(this.probabiilityLabel);
            this.Controls.Add(this.MeasurementTextBox);
            this.Controls.Add(this.infoLabel2);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.MenuDevider);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ValuesEstimating";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ShortCut);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel InfoLabel;
        private MaterialSkin.Controls.MaterialLabel infoLabel2;
        private MaterialSkin.Controls.MaterialLabel probabiilityLabel;
        private MaterialSkin.Controls.MaterialComboBox probabilityComboBox;
        private MaterialSkin.Controls.MaterialButton additionalErrorButton;
        private MaterialSkin.Controls.MaterialButton mainErrorButton;
        private MaterialSkin.Controls.MaterialButton processButton;
        private MaterialSkin.Controls.MaterialButton aboutButton;
        private MaterialSkin.Controls.MaterialButton helpButton;
        private MaterialSkin.Controls.MaterialButton quitButton;
        private MaterialSkin.Controls.MaterialDivider MenuDevider;
        private MaterialSkin.Controls.MaterialTextBox MeasurementTextBox;
    }
}

