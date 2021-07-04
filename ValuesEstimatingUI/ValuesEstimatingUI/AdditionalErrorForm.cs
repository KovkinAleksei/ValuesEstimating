using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValuesEstimatingUI
{
    public partial class AdditionalErrorForm : Form
    {
        private double _additionalError = 0;

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
        }

        /// <summary>
        /// Ввод дополнительной погрешности
        /// </summary>
        private void additionalErrorTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(additionalErrorTextBox.Text, out _additionalError) ||
                additionalErrorTextBox.Text[additionalErrorTextBox.Text.Length - 1] == ' ')
            {
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
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Отмена ввода дополнительной погрешности
        /// </summary>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
