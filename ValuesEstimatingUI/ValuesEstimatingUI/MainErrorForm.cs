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
        // Текущие значения
        private double _mainError = 0;
        private double _normalizingValue = 0;
        private double _reducedErrorBeginning = 0;
        private double _reducedErrorEnd = 0;
        private double _trueValue;

        // Введённые ранее значения
        private int _previousAccuracy = 0;
        private int _previousErrorCharater = 0;
        private double _previousMainError = 0;
        private double _previousNormalizingValue = 0;
        private double _previousReducedErrorBeginning = 0;
        private double _previousReducedErrorEnd = 0;

        /// <summary>
        /// Возвращает основную погрешность
        /// </summary>
        public double MainError
        {
            get
            {
                // Нахождение основной погрешности
                if (errorCharacterComboBox.SelectedIndex == 1)
                    return _normalizingValue * Convert.ToDouble(accuracyClassComboBox.SelectedItem) / 100;

                else if (errorCharacterComboBox.SelectedIndex == 2)
                    return Convert.ToDouble(accuracyClassComboBox.SelectedItem) * _trueValue / 100;

                else if (errorCharacterComboBox.SelectedIndex == 3)
                    return _reducedErrorBeginning / 100 * _normalizingValue +
                        (_reducedErrorEnd - _reducedErrorBeginning) / 100 * _trueValue;

                // Возврат основной погрешности
                return _mainError;
            }
        }

        /// <summary>
        /// Задаёт результат измерения
        /// </summary>
        public double TrueValue
        {
            set
            {
                _trueValue = value;
            }
        }

        /// <summary>
        /// Возвращает класс точности
        /// </summary>
        public int AccuracyClass
        {
            get
            {
                if (errorCharacterComboBox.SelectedIndex != 0)
                    return accuracyClassComboBox.SelectedIndex;

                return 0;
            }
        }

        /// <summary>
        /// Возвращает характер основной погрешности
        /// </summary>
        public int ErrorCharacter
        {
            get
            {
                return errorCharacterComboBox.SelectedIndex;
            }
        }

        /// <summary>
        /// Возвращает приведённую погрешность в начале шкалы
        /// </summary>
        public string FirstReducedError
        {
            get
            {
                return reducedErrorBeginningTextBox.Text;
            }
        }

        /// <summary>
        /// Возвращает приведённую погрешность в конце шкалы
        /// </summary>
        public string LastReducedError
        {
            get
            {
                return reducedErrorEndTextBox.Text;
            }
        }

        /// <summary>
        /// Возвращает нормирующую величину
        /// </summary>
        public double NormalizingValue
        {
            get
            {
                return _normalizingValue;
            }
        }

        /// <summary>
        /// Возвращает введённой значение основной погрешности
        /// </summary>
        public double Main
        {
            get
            {
                return _mainError;
            }
        }

        public MainErrorForm()
        {
            InitializeComponent();

            // Скрытие элементов ввода нормирующей величины и приведённой погрешности до момента выбора 
            // характера основной погрешности
            normalizingValueLabel.Visible = false;
            normalizingValueTextBox.Visible = false;

            reducedErrorBeginningTextBox.Visible = false;
            reducedErrorEndTextBox.Visible = false;
            reducedErrorLabel.Visible = false;
            reducedErrorSeparatorLabel.Visible = false;

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

            // По умолчанию класс точности не выбран
            accuracyClassComboBox.SelectedIndex = 0;

            // По умолчанию характер основной погрешности не выбран
            errorCharacterComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Выбор класса точности
        /// </summary>
        private void accuracyClassComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Скрыть элемент ввода основной погрешности при выборе класса точности
            if (accuracyClassComboBox.SelectedIndex == 0 &&
                errorCharacterComboBox.SelectedIndex == 0)
                mainErrorTextBox.Enabled = true;
            else
                mainErrorTextBox.Enabled = false;

            orLabel.Focus();
        }

        /// <summary>
        /// Ввод основной погрешности
        /// </summary>
        private void mainErrorTextBox_TextChanged(object sender, EventArgs e)
        {
            // Проверка наличия лишних символов
            if (!double.TryParse(mainErrorTextBox.Text, out _mainError) ||
                mainErrorTextBox.Text[mainErrorTextBox.Text.Length - 1] == ' ')
            {
                if (mainErrorTextBox.Text.Length >= 1)
                    mainErrorTextBox.Text =
                        mainErrorTextBox.Text.Remove(mainErrorTextBox.Text.Length - 1, 1);

                mainErrorTextBox.SelectionStart = mainErrorTextBox.Text.Length;
            }

            // Скрыть выбор класса точности и характера основной погрешности при вводе основной погрешности
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

        /// <summary>
        /// Ввод нормирующей величины
        /// </summary>
        private void normalizingValueTextBox_TextChanged(object sender, EventArgs e)
        {
            // Проверка наличия лишних символов
            if (!double.TryParse(normalizingValueTextBox.Text, out _normalizingValue) ||
                normalizingValueTextBox.Text[normalizingValueTextBox.Text.Length - 1] == ' ')
            {
                if (normalizingValueTextBox.Text.Length > 0)
                    normalizingValueTextBox.Text =
                        normalizingValueTextBox.Text.Remove(normalizingValueTextBox.Text.Length - 1, 1);

                normalizingValueTextBox.SelectionStart = normalizingValueTextBox.Text.Length;
            }
        }

        /// <summary>
        /// Ввод приведённой погрешности в начале шкалы прибора
        /// </summary>
        private void reducedErrorBeginningTextBox_TextChanged(object sender, EventArgs e)
        {
            // Проверка наличия лишних символов
            if (!double.TryParse(reducedErrorBeginningTextBox.Text, out _reducedErrorBeginning) ||
                reducedErrorBeginningTextBox.Text[reducedErrorBeginningTextBox.Text.Length - 1] == ' ')
            {
                if (reducedErrorBeginningTextBox.Text.Length > 0)
                    reducedErrorBeginningTextBox.Text =
                        reducedErrorBeginningTextBox.Text.Remove(reducedErrorBeginningTextBox.Text.Length - 1, 1);

                reducedErrorBeginningTextBox.SelectionStart = reducedErrorBeginningTextBox.Text.Length;
            }
        }

        /// <summary>
        /// Ввод приведённой погрешности в конце шкалы прибора
        /// </summary>
        private void reducedErrorEndTextBox_TextChanged(object sender, EventArgs e)
        {
            // Проверка наличия лишних символов
            if (!double.TryParse(reducedErrorEndTextBox.Text, out _reducedErrorEnd) ||
                reducedErrorEndTextBox.Text[reducedErrorEndTextBox.Text.Length - 1] == ' ')
            {
                if (reducedErrorEndTextBox.Text.Length > 0)
                    reducedErrorEndTextBox.Text =
                        reducedErrorEndTextBox.Text.Remove(reducedErrorEndTextBox.Text.Length - 1, 1);

                reducedErrorEndTextBox.SelectionStart = reducedErrorEndTextBox.Text.Length;
            }
        }

        /// <summary>
        /// Выбор характера основной погрешности
        /// </summary>
        private void errorCharacterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Скрыть элемент ввода основной погрешности при выборе характера основной погрешности
            if (accuracyClassComboBox.SelectedIndex == 0 &&
                errorCharacterComboBox.SelectedIndex == 0)
                mainErrorTextBox.Enabled = true;
            else
                mainErrorTextBox.Enabled = false;

            // При выборе аддитивной погрешности
            if (errorCharacterComboBox.SelectedIndex == 1)
            {
                this.Height = 301;

                // Скрываются элементы ввода приведённой погрешности 
                reducedErrorBeginningTextBox.Visible = false;
                reducedErrorEndTextBox.Visible = false;
                reducedErrorLabel.Visible = false;
                reducedErrorSeparatorLabel.Visible = false;

                // Появляются элементы ввода нормирующей величины
                normalizingValueLabel.Visible = true;
                normalizingValueTextBox.Visible = true;

                // Включается элемент выбора класса точности
                accuracyClassComboBox.Enabled = true;
            }
            // При выборе мультипликативной погрешности или "Не выбрано"
            else if (errorCharacterComboBox.SelectedIndex == 0 || errorCharacterComboBox.SelectedIndex == 2)
            {
                this.Height = 268;

                // Скрываются элементы ввода нормирующей величины
                normalizingValueLabel.Visible = false;
                normalizingValueTextBox.Visible = false;

                // Скрываются элементы ввода приведённой величины
                reducedErrorBeginningTextBox.Visible = false;
                reducedErrorEndTextBox.Visible = false;
                reducedErrorLabel.Visible = false;
                reducedErrorSeparatorLabel.Visible = false;

                // Включается элемент выбора класса точности
                accuracyClassComboBox.Enabled = true;
            }
            // При выборе аддитивной и мультипликативной погрешности
            else if (errorCharacterComboBox.SelectedIndex == 3)
            {
                this.Height = 370;

                // Появляются элементы ввода нормирующей величины
                normalizingValueLabel.Visible = true;
                normalizingValueTextBox.Visible = true;

                // Появляются элементы ввода приведённой погрешности
                reducedErrorBeginningTextBox.Visible = true;
                reducedErrorEndTextBox.Visible = true;
                reducedErrorLabel.Visible = true;
                reducedErrorSeparatorLabel.Visible = true;

                // Выключается элемент выбора класса точности
                accuracyClassComboBox.Enabled = false;
            }

            orLabel.Focus();
        }

        /// <summary>
        /// Сохранение введйнных значений при нажатии кнопки Ввод
        /// </summary>
        private void OKbutton_Click(object sender, EventArgs e)
        {
            Save();
        }

        /// <summary>
        /// Сохранение введённых значений
        /// </summary>
        private void Save()
        {
            // Проверка выбранных и введённых значений
            if (accuracyClassComboBox.SelectedIndex == 0 && errorCharacterComboBox.SelectedIndex == 2)
            {
                MessageBox.Show("Выберете класс точности", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (errorCharacterComboBox.SelectedIndex == 0 && accuracyClassComboBox.SelectedIndex != 0)
            {
                MessageBox.Show("Выберете характер основной погрешности", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (errorCharacterComboBox.SelectedIndex == 1 &&
                accuracyClassComboBox.SelectedIndex == 0 && normalizingValueTextBox.Text != "")
            {
                MessageBox.Show("Выберете класс точности", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (errorCharacterComboBox.SelectedIndex == 1 &&
                accuracyClassComboBox.SelectedIndex != 0 && normalizingValueTextBox.Text == "")
            {
                MessageBox.Show("Введите нормирующую величину", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (errorCharacterComboBox.SelectedIndex == 1 &&
                accuracyClassComboBox.SelectedIndex == 0 && normalizingValueTextBox.Text == "")
            {
                MessageBox.Show("Выберете класс точности и введите нормирующюу величину", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (errorCharacterComboBox.SelectedIndex == 3 && normalizingValueTextBox.Text == "" &&
                (reducedErrorBeginningTextBox.Text == "" || reducedErrorEndTextBox.Text == ""))
            {
                MessageBox.Show("Введите нормирующую величину и " +
                    "приведённую погрешность в начале и в конце шкалы", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (errorCharacterComboBox.SelectedIndex == 3 && normalizingValueTextBox.Text == "" &&
                reducedErrorBeginningTextBox.Text != "" && reducedErrorEndTextBox.Text != "")
            {
                MessageBox.Show("Введите нормирующую величину", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (errorCharacterComboBox.SelectedIndex == 3 && normalizingValueTextBox.Text != "" &&
                 (reducedErrorBeginningTextBox.Text == "" || reducedErrorEndTextBox.Text == ""))
            {
                MessageBox.Show("Введите приведённую погрешность в начале и в конце шкалы", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Сохранение введёныых значений
            _previousAccuracy = accuracyClassComboBox.SelectedIndex;
            _previousErrorCharater = errorCharacterComboBox.SelectedIndex;
            _previousMainError = _mainError;
            _previousNormalizingValue = _normalizingValue;
            _previousReducedErrorBeginning = _reducedErrorBeginning;
            _previousReducedErrorEnd = _reducedErrorEnd;

            // Закрытие окна
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Отмена ввода основной погрешности
        /// </summary>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            // Возвращение прошлых введённых значений
            if (_previousMainError != 0 && _previousErrorCharater == 0 && _previousAccuracy == 0)
                mainErrorTextBox.Text = _previousMainError.ToString();
            else
                mainErrorTextBox.Text = "";

            if (_previousNormalizingValue != 0)
                normalizingValueTextBox.Text = _previousNormalizingValue.ToString();
            else
                normalizingValueTextBox.Text = "";

            if (_previousReducedErrorBeginning != 0)
                reducedErrorBeginningTextBox.Text = _previousReducedErrorBeginning.ToString();
            else
                reducedErrorBeginningTextBox.Text = "";

            if (_previousReducedErrorEnd != 0)
                reducedErrorEndTextBox.Text = _previousReducedErrorEnd.ToString();
            else
                reducedErrorEndTextBox.Text = "";

            accuracyClassComboBox.SelectedIndex = _previousAccuracy;
            errorCharacterComboBox.SelectedIndex = _previousErrorCharater;

            // Закрытие окна
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Нажатие горячих клавиш
        /// </summary>
        private void ShortCut(object sender, KeyEventArgs e)
        {
            // Сохранение результатов при нажатии кнопки Enter
            if (e.KeyCode == Keys.Enter)
            {
                Save();
            }
        }
    }
}
