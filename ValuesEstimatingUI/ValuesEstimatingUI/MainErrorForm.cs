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
    public partial class MainErrorForm : Form
    {
        private double _mainError = 0;

        /// <summary>
        /// Возвращает основную погрешность
        /// </summary>
        public double MainError
        {
            get
            {
                return _mainError;
            }
        }
        public MainErrorForm()
        {
            InitializeComponent();

            // Добавление в список классов точности
            accuracyClassComboBox.Items.Add("Не выбрано");
            accuracyClassComboBox.Items.Add("0,05");
            accuracyClassComboBox.Items.Add("0,1");
            accuracyClassComboBox.Items.Add("0,2");
            accuracyClassComboBox.Items.Add("0,5");
            accuracyClassComboBox.Items.Add("1,0");
            accuracyClassComboBox.Items.Add("1,5");
            accuracyClassComboBox.Items.Add("2,5");
            accuracyClassComboBox.Items.Add("4,0");

            // Добавление в список характеров погрешности
            errorCharacterComboBox.Items.Add("Не выбрано");
            errorCharacterComboBox.Items.Add("Аддитивная");
            errorCharacterComboBox.Items.Add("Мультипликативная");
            errorCharacterComboBox.Items.Add("Аддитивная и мультипликативная");

            // Выбор класса точности
            accuracyClassComboBox.SelectedIndex = 0;

            // Выбор характера основной погрешности
            errorCharacterComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Сохранение введйнных значений
        /// </summary>
        private void OKbutton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Отмена ввода основной погрешности
        /// </summary>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Выбор класса точности
        /// </summary>
        private void accuracyClassComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (accuracyClassComboBox.SelectedIndex == 0 && 
                errorCharacterComboBox.SelectedIndex == 0)
            {
                mainErrorTextBox.Enabled = true;
            }
            else
            {
                mainErrorTextBox.Enabled = false;
            }
        }

        /// <summary>
        /// Выбор характера основной погрешности
        /// </summary>
        private void errorCharacterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Включение/выключение элемента ввода основной погрешности
            if (accuracyClassComboBox.SelectedIndex == 0 &&
                errorCharacterComboBox.SelectedIndex == 0)
            {
                mainErrorTextBox.Enabled = true;
            }
            else
            {
                mainErrorTextBox.Enabled = false;
            }
        }

        /// <summary>
        /// Ввод основной погрешности
        /// </summary>
        private void mainErrorTextBox_TextChanged(object sender, EventArgs e)
        {
            if(!double.TryParse(mainErrorTextBox.Text, out _mainError) ||
                mainErrorTextBox.Text[mainErrorTextBox.Text.Length - 1] == ' ')
            {
                if (mainErrorTextBox.Text.Length >= 1)
                    mainErrorTextBox.Text =
                        mainErrorTextBox.Text.Remove(mainErrorTextBox.Text.Length - 1, 1);

                mainErrorTextBox.SelectionStart = mainErrorTextBox.Text.Length;
            }

            // Включение/выключение элементов выбора класса точности и характера основной погрешности
            if (mainErrorTextBox.Text == "")
            {
                accuracyClassComboBox.Enabled = true;
                errorCharacterComboBox.Enabled = true;
            }
            else
            {
                accuracyClassComboBox.Enabled = false;
                errorCharacterComboBox.Enabled = false;
            }
        }
    }
}
