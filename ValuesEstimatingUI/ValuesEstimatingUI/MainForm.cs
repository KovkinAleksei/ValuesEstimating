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
using MaterialSkin;
using MaterialSkin.Controls;


namespace ValuesEstimatingUI
{
    public partial class MainForm : MaterialForm
    {
        // Серия измерений
        Values values = new Values();
        MainErrorForm mainErrorForm;
        AdditionalErrorForm additionalErrorForm;
        ResultForm resultForm;

        public MainForm()
        {
            InitializeComponent();

            // Тёмная тема окна
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green700, Primary.LightGreen900,
                Primary.Green500, Accent.Green400, TextShade.WHITE);

            // Создание формы ввода основной погрешности
            mainErrorForm = new MainErrorForm();

            // Создание формы ввода дополнительной погрешности
            additionalErrorForm = new AdditionalErrorForm();

           // Отключение кнопки обработки серии измереий до введения не менее трёх измерений
            processButton.Enabled = false;

            // Добавление в список доверительных вероятностей
            probabilityComboBox.Items.Add("0,999");
            probabilityComboBox.Items.Add("0,99");
            probabilityComboBox.Items.Add("0,95");
            probabilityComboBox.Items.Add("0,9");

            // По умолчанию значение доверительной вероятности равно 0,95
            // в соответствии с правилами метрологии
            probabilityComboBox.SelectedIndex = 2;

            
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
                MeasurementTextBox.Text.Contains("  ") ||
                (values.Count >= 30 && MeasurementTextBox.Text[MeasurementTextBox.Text.Length - 1] == ' '))
            {
                if (MeasurementTextBox.Text.Length >= 1)
                    MeasurementTextBox.Text =
                        MeasurementTextBox.Text.Remove(MeasurementTextBox.Text.Length - 1, 1);

                MeasurementTextBox.SelectionStart = MeasurementTextBox.Text.Length;
            }

            // Проверка на возможность добавления значений в серию измерений
            try
            {
                values.Add(MeasurementTextBox.Text);
                
            }
            catch(Exception ex)
            {
                if (MeasurementTextBox.Text.Length >= 1)
                    MeasurementTextBox.Text =
                        MeasurementTextBox.Text.Remove(MeasurementTextBox.Text.Length - 1, 1);

                MeasurementTextBox.SelectionStart = MeasurementTextBox.Text.Length;
            }

            // Включение кнопки обработки измерений при вводе трёх и более значений
            if (values.Count >= 3)
                processButton.Enabled = true;
            else
                processButton.Enabled = false;
        }

        /// <summary>
        /// Выбор доверительной вероятности
        /// </summary>
        private void probabilityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            values.Probability = probabilityComboBox.SelectedIndex;

            probabiilityLabel.Focus();
        }

        /// <summary>
        /// Ввод дополнительной погрешности
        /// </summary>
        private void additionalErrorButton_Click(object sender, EventArgs e)
        {
            additionalErrorForm.ShowDialog();

            if (additionalErrorForm.DialogResult == DialogResult.OK)
                values.AdditionalError = additionalErrorForm.AdditionalError;

            this.ActiveControl = probabiilityLabel;
        }

        /// <summary>
        /// Ввод основной погрешности
        /// </summary>
        private void mainErrorButton_Click(object sender, EventArgs e)
        {
            mainErrorForm.ShowDialog();

            this.ActiveControl = probabiilityLabel;
        }

        /// <summary>
        /// Вывод результатов измерений при нажатии кнопки Ввод
        /// </summary>
        private void processButton_Click(object sender, EventArgs e)
        {
            Process();
        }

        /// <summary>
        /// Обработка серии измерений
        /// </summary>
        private void Process()
        {
            this.ActiveControl = probabiilityLabel;

            // Нахождение результата измерения
            values.Add(MeasurementTextBox.Text);
            values.FindResult();

            // Нахождение общей границы погрешности измерений
            mainErrorForm.TrueValue = values.Result;
            values.MainError = mainErrorForm.MainError;
            values.FindError();

            // Вывод результата
            ResultForm resultForm = new ResultForm(values.Result, values.ResultError, values.Misses);
            resultForm.Measures = values.Measures;
            resultForm.AdditionalError = values.AdditionalError;
            resultForm.AccuracyClass = mainErrorForm.AccuracyClass;
            resultForm.ErrorCharacter = mainErrorForm.ErrorCharacter;
            resultForm.FirstReducedError = mainErrorForm.FirstReducedError;
            resultForm.LastReducedError = mainErrorForm.LastReducedError;
            resultForm.NormalizingValue = mainErrorForm.NormalizingValue;
            resultForm.Main = mainErrorForm.Main;
            resultForm.Probability = probabilityComboBox.SelectedIndex;
            resultForm.OriginalValues = values.OrigianlValues;
            resultForm.ResultError = values.ResultError;

            resultForm.ShowDialog();
        }

        /// <summary>
        /// Выход из программы
        /// </summary>
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult quitAnswer = MaterialMessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButtons.YesNo);
           
            if (quitAnswer == DialogResult.Yes)
                this.Close();
        }

        /// <summary>
        /// Вывод окна о программе
        /// </summary>
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }

        /// <summary>
        /// Вывод окна помощи
        /// </summary>
        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            help.Show();
        }

        /// <summary>
        /// Нажатие горячих клавиш
        /// </summary>
        private void ShortCut(object sender, KeyEventArgs e)
        {
            // Вывод окна помощи при нажатии F1
            if (e.KeyCode == Keys.F1)
            {
                HelpForm helpForm= new HelpForm();
                helpForm.ShowDialog();
            }
            // Вывод результата измерений при нажатии Enter
            if (e.KeyCode == Keys.Enter)
            {
                if (processButton.Enabled == true)
                    Process();
            }
        }
    }
}
