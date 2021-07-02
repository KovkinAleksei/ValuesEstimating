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
        bool accuracy = false;

        public MainForm()
        {
            InitializeComponent();

            // Отключение кнопки обработки серии измереий
            processButton.Enabled = false;

            // Скрытие элементов
            accuracyClassLabel.Visible = false;
            accuracyClassTextBox.Visible = false;
            errorCharacterComboBox.Visible = false;
            errorCharacterLabel.Visible = false;
            resultLabel.Visible = false;
            errorLimitLabel.Visible = false;
            missesLabel.Visible = false;

            // Добавление в список характеров основной погрешности
            errorCharacterComboBox.Items.Add("Аддитивная");
            errorCharacterComboBox.Items.Add("Мультипликативная");
            errorCharacterComboBox.Items.Add("Аддитивная и мультипликативная");

            // Выбор аддитивной погрешности
            errorCharacterComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Выбор обработки серии измерений по основной инструментальной погрешности
        /// </summary>
        private void основнаяИнструментальнаяПогрешностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainErrorRateLabel.Visible = true;
            mainErrorRateTextBox.Visible = true;
            accuracyClassLabel.Visible = false;
            accuracyClassTextBox.Visible = false;
            errorCharacterComboBox.Visible = false;
            errorCharacterLabel.Visible = false;
        }

        /// <summary>
        /// Выбор обработки серии измерений по классу точности и характеру основной погрешности
        /// </summary>
        private void accuracyClass_Click(object sender, EventArgs e)
        {
            mainErrorRateLabel.Visible = false;
            mainErrorRateTextBox.Visible = false;
            accuracyClassLabel.Visible = true;
            accuracyClassTextBox.Visible = true;
            errorCharacterComboBox.Visible = true;
            errorCharacterLabel.Visible = true;
        }

        /// <summary>
        /// Сохранение серии измерений
        /// </summary>
        private void inputButton_Click(object sender, EventArgs e)
        {
            try
            {
                values.Add(MeasurementTextBox.Text);
                input = true;
                Process();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Включение / выключение кнопки обработки серии измерений
        /// </summary>
        private void Process()
        {
            if ((input && mainError) || (input && accuracy))
                processButton.Enabled = true;
            else
                processButton.Enabled = false;
        }

        /// <summary>
        /// Ввод класса точности
        /// </summary>
        private void accuracyClassTextBox_TextChanged(object sender, EventArgs e)
        {
            double idk;

            if (double.TryParse(accuracyClassTextBox.Text, out idk))
                accuracy = true;
            else
            {
                accuracy = false;

                if (accuracyClassTextBox.Text.Length >= 1)
                accuracyClassTextBox.Text = 
                    accuracyClassTextBox.Text.Remove(accuracyClassTextBox.Text.Length - 1, 1);

                accuracyClassTextBox.SelectionStart = accuracyClassTextBox.Text.Length;
            }
            Process();
        }

        /// <summary>
        /// Ввод основной инструментальной погрешности
        /// </summary>
        private void mainErrorRateTextBox_TextChanged(object sender, EventArgs e)
        {
            double idk;

            if (mainErrorRateTextBox.Text == "")
                mainError = false;
            else if (double.TryParse(mainErrorRateTextBox.Text, out idk))
                mainError = true;
            else
                mainError = false;

            Process();
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

        /// <summary>
        /// Ввод доверительной вероятности
        /// </summary>
        private void probabilityTextBox_TextChanged(object sender, EventArgs e)
        {
            double check;

            if (!(double.TryParse(probabilityTextBox.Text, out check)))
            {
                if (probabilityTextBox.Text.Length >= 1)
                    probabilityTextBox.Text =
                        probabilityTextBox.Text.Remove(probabilityTextBox.Text.Length - 1, 1);

                probabilityTextBox.SelectionStart = probabilityTextBox.Text.Length;
            }
        }
    }
}
