using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ValuesEstimatingUI
{
    public partial class AdditionalErrorForm : MaterialForm
    {
        private double _additionalError = 0;
        private double _previousAdditionalError = 0;

        /// <summary>
        /// Возвращает дополнительную погрешность
        /// </summary>
        public double AdditionalError
        {
            get
            {
                return _additionalError;
            }
        }

        public AdditionalErrorForm()
        {
            InitializeComponent();

            // Темная тема окна
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green700, Primary.LightGreen900,
                Primary.Green500, Accent.Green400, TextShade.WHITE);
        }

        /// <summary>
        /// Ввод дополнительной погрешности
        /// </summary>
        private void additionalErrorTextBox_TextChanged(object sender, EventArgs e)
        {
            // Проверка наличия лишних символов
            if (!double.TryParse(additionalErrorTextBox.Text, out _additionalError) ||
                additionalErrorTextBox.Text[additionalErrorTextBox.Text.Length - 1] == ' ')
            {
                if (additionalErrorTextBox.Text.Length > 0)
                    additionalErrorTextBox.Text =
                        additionalErrorTextBox.Text.Remove(additionalErrorTextBox.Text.Length - 1, 1);

                additionalErrorTextBox.SelectionStart = additionalErrorTextBox.Text.Length;
            }
        }

        /// <summary>
        /// Сохранение введённого значения дополнительной погрешности
        /// </summary>
        private void OKbutton_Click(object sender, EventArgs e)
        {
            _previousAdditionalError = _additionalError;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Отмена ввода дополнительной погрешности
        /// </summary>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (_previousAdditionalError != 0)
                additionalErrorTextBox.Text = _previousAdditionalError.ToString();
            else
                additionalErrorTextBox.Text = "";

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Нажатие горячих клавиш
        /// </summary>
        private void ShortCut(object sender, KeyEventArgs e)
        {
            // Сохранение введённого значения дополнительной погрешности при нажатии Enter
            if (e.KeyCode == Keys.Enter)
            {
                _previousAdditionalError = _additionalError;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
