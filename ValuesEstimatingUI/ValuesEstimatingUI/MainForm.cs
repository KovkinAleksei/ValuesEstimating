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

        // Введённые значения
        bool input = false;
        bool mainError = false;

        public MainForm()
        {
            InitializeComponent();

            // Отключение кнопки обработки серии измереий
            processButton.Enabled = false;

            // Скрытие элементов
            accuracyClassLabel.Visible = false;
            accuracyClassComboBox.Visible = false;
            errorCharacterComboBox.Visible = false;
            errorCharacterLabel.Visible = false;
            resultLabel.Visible = false;
            errorLimitLabel.Visible = false;
            missesLabel.Visible = false;

            // Добавление в список характеров основной погрешности
            errorCharacterComboBox.Items.Add("Аддитивная");
            errorCharacterComboBox.Items.Add("Мультипликативная");
            errorCharacterComboBox.Items.Add("Аддитивная и мультипликативная");

            // Добавление в список доверительных вероятностей
            probabilityComboBox.Items.Add("0,95");
            probabilityComboBox.Items.Add("0,99");
            probabilityComboBox.Items.Add("0,999");

            // Добавление в список классов точности
            accuracyClassComboBox.Items.Add("0,05");
            accuracyClassComboBox.Items.Add("0,1");
            accuracyClassComboBox.Items.Add("0,2");
            accuracyClassComboBox.Items.Add("0,5");
            accuracyClassComboBox.Items.Add("1,0");
            accuracyClassComboBox.Items.Add("1,5");
            accuracyClassComboBox.Items.Add("2,5");
            accuracyClassComboBox.Items.Add("4,0");

            // Выбор аддитивной погрешности
            errorCharacterComboBox.SelectedIndex = 0;

            // Выбор доверительной погрешности 0,95
            probabilityComboBox.SelectedIndex = 0;

            // Выбор класса точности 0,05
            accuracyClassComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Выбор обработки серии измерений по основной инструментальной погрешности
        /// </summary>
        private void основнаяИнструментальнаяПогрешностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainErrorRateLabel.Visible = true;
            mainErrorRateTextBox.Visible = true;
            accuracyClassLabel.Visible = false;
            accuracyClassComboBox.Visible = false;
            errorCharacterComboBox.Visible = false;
            errorCharacterLabel.Visible = false;

            Process();
        }

        /// <summary>
        /// Выбор обработки серии измерений по классу точности и характеру основной погрешности
        /// </summary>
        private void accuracyClass_Click(object sender, EventArgs e)
        {
            mainErrorRateLabel.Visible = false;
            mainErrorRateTextBox.Visible = false;
            accuracyClassLabel.Visible = true;
            accuracyClassComboBox.Visible = true;
            errorCharacterComboBox.Visible = true;
            errorCharacterLabel.Visible = true;

            Process();
        }

        /// <summary>
        /// Ввод основной инструментальной погрешности
        /// </summary>
        private void mainErrorRateTextBox_TextChanged(object sender, EventArgs e)
        {
            double check;

            if (mainErrorRateTextBox.Text == "")
                mainError = false;
            else if (double.TryParse(mainErrorRateTextBox.Text, out check))
                mainError = true;
            else
            {
                mainErrorRateTextBox.Text =
                        mainErrorRateTextBox.Text.Remove(mainErrorRateTextBox.Text.Length - 1, 1);

                mainErrorRateTextBox.SelectionStart = mainErrorRateTextBox.Text.Length;
            }
            Process();
        }

        /// <summary>
        /// Ввод дополнительной погрешности
        /// </summary>
        private void additionalErrorTextBox_TextChanged(object sender, EventArgs e)
        {
            double check;

            if (!(double.TryParse(additionalErrorTextBox.Text, out check)))
            {
                if (additionalErrorTextBox.Text.Length >= 1)
                    additionalErrorTextBox.Text =
                        additionalErrorTextBox.Text.Remove(additionalErrorTextBox.Text.Length - 1, 1);

                additionalErrorTextBox.SelectionStart = additionalErrorTextBox.Text.Length;
            }
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
                input = true;
            else
                input = false;

            Process();
        }

        /// <summary>
        /// Включение / выключение кнопки обработки серии измерений
        /// </summary>
        private void Process()
        {
            if (input && (mainError || !mainErrorRateTextBox.Visible))
                processButton.Enabled = true;
            else
                processButton.Enabled = false;
        }
        /// <summary>
        /// Обработка серии измерений
        /// </summary>
        private void processButton_Click(object sender, EventArgs e)
        {
            resultLabel.Visible = true;
            errorLimitLabel.Visible = true;
            missesLabel.Visible = true;
        }
    }
}
