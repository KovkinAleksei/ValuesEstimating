using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValuesEstimating;


namespace ValuesEstimatingUI
{
    public partial class MainForm : Form
    {
        // Серия измерений
        Values values = new Values();

        public MainForm()
        {
            InitializeComponent();

            // Отключение кнопки обработки серии измереий
            processButton.Enabled = false;

            // Добавление в список доверительных вероятностей
            probabilityComboBox.Items.Add("0,9");
            probabilityComboBox.Items.Add("0,95");
            probabilityComboBox.Items.Add("0,99");
            probabilityComboBox.Items.Add("0,999");

            // Выбор доверительной погрешности 0,9
            probabilityComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Ввод серии измерений
        /// </summary>
        private void MeasurementTextBox_TextChanged(object sender, EventArgs e)
        {
            char lastChar = 'h';

            // Проверка длины строки
            if (MeasurementTextBox.Text.Length > 0)
                lastChar = MeasurementTextBox.Text[MeasurementTextBox.Text.Length - 1];

            // Проверка нвличия лишних символов в строке
            if ((lastChar < '0' && lastChar != ',' && lastChar != ' ') ||
                (lastChar > '9' && lastChar != ',' && lastChar != ' ') ||
                MeasurementTextBox.Text.Contains("  "))
            {
                if (MeasurementTextBox.Text.Length >= 1)
                    MeasurementTextBox.Text =
                        MeasurementTextBox.Text.Remove(MeasurementTextBox.Text.Length - 1, 1);

                MeasurementTextBox.SelectionStart = MeasurementTextBox.Text.Length;
            }

            // Добавление введённых значений в серию измерений
            values.Add(MeasurementTextBox.Text);

            // Вкл/выкл кнопки обработки измерений
            if (values.Count >= 3)
                processButton.Enabled = true;
            else
                processButton.Enabled = false;
        }

        /// <summary>
        /// Ввод дополнительной погрешности
        /// </summary>
        private void additionalErrorButton_Click(object sender, EventArgs e)
        {
            AdditionalErrorForm additionalErrorForm = new AdditionalErrorForm();
            additionalErrorForm.ShowDialog();

            if (additionalErrorForm.DialogResult == DialogResult.OK)
                values.AdditionalError = additionalErrorForm.AdditionalError;
        }

        /// <summary>
        /// Ввод основной погрешности
        /// </summary>
        private void mainErrorButton_Click(object sender, EventArgs e)
        {
            MainErrorForm mainErrorForm = new MainErrorForm();
            mainErrorForm.ShowDialog();

            if (mainErrorForm.DialogResult == DialogResult.OK)
                values.MainError = mainErrorForm.MainError;
        }

        /// <summary>
        /// Обработка серии измерений
        /// </summary>
        private void processButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
