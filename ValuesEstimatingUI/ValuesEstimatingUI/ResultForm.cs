using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ValuesEstimatingUI
{
    public partial class ResultForm : Form
    {
        private List<double> _measures;
        private List<double> _originalValues;
        private double _additionalError = 0;
        private int _accuracyClass = 0;
        private int _errorCharacter = 0;
        private string _firstReducedError = "none";
        private string _lastReducedError = "none";
        private double _normalizingValue = 0;
        private double _mainError = 0;
        private int _probability;
        private double _resultError;

        /// <summary>
        /// Задаёт серию измерений без промахов
        /// </summary>
        public List<double> Measures
        {
            set
            {
                _measures = value;
            }
        }

        /// <summary>
        /// Задаёт введённую серию измерений
        /// </summary>
        public List<double> OriginalValues
        {
            set
            {
                _originalValues = value;
            }
        }

        /// <summary>
        /// Задает дополнительную погрешность
        /// </summary>
        public double AdditionalError
        {
            set
            {
                _additionalError = value;

            }
        }

        /// <summary>
        /// Задаёт класс точности
        /// </summary>
        public int AccuracyClass
        {
            set
            {
                _accuracyClass = value;
            }
        }

        /// <summary>
        /// Задаёт характер основной погрешности
        /// </summary>
        public int ErrorCharacter
        {
            set
            {
                _errorCharacter = value;
            }
        }

        /// <summary>
        /// Задаёт приведённую погрешность в начале шкалы
        /// </summary>
        public string FirstReducedError
        {
            set
            {
                _firstReducedError = value;
            }
        }

        /// <summary>
        /// Задаёт приведённую погрешность в конце шкалы
        /// </summary>
        public string LastReducedError
        {
            set
            {
                _lastReducedError = value;
            }
        }

        /// <summary>
        /// Задаёт нормирующую величину
        /// </summary>
        public double NormalizingValue
        {
            set
            {
                _normalizingValue = value;
            }
        }

        /// <summary>
        /// Задаёт введённое значение основной погрешности
        /// </summary>
        public double Main
        {
            set
            {
                _mainError = value;
            }
        }

        /// <summary>
        /// Задаёт доверительную вероятность
        /// </summary>
        public int Probability
        {
            set
            {
                _probability = value;
            }
        }

        /// <summary>
        /// Задаёт общую погрешность измерений
        /// </summary>
        public double ResultError
        {
            set
            {
                _resultError = value;
            }
        }

        public ResultForm(double result, double resultError, List<double> misses)
        {
            InitializeComponent();

            // Вывод результатов
            double[] missesArray = misses.ToArray();
            string missesStr = "";

            for (int i = 0; i < missesArray.Length; i++)
            {
                string temp = missesArray[i].ToString();
                missesStr += temp;
                missesStr += " ";
            }
          
            missesInfoLabel.Text = missesStr;

            if (missesInfoLabel.Text == "")
                missesInfoLabel.Text = "нет";

                resultInfoLabel.Text = Math.Round(result, 2).ToString();
            resultErrorInfoLabel.Text = Math.Round(resultError, 2).ToString();

            this.ActiveControl = missesLabel;
        }

        /// <summary>
        /// Нажатие на кнопку ОК
        /// </summary
        private void OKbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Сохранение результатов в файле
        /// </summary>
        private void saveButton_Click(object sender, EventArgs e)
        {
            this.ActiveControl = missesLabel;

            // Создание файла
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "Измерения";

            saveFile.DefaultExt = ".txt";
            saveFile.Filter = "(*.txt)|*.txt";

            if (saveFile.ShowDialog() == DialogResult.Cancel)
                return;

            // Сохранение названия файла
            string fileName = saveFile.FileName;

            // Открытие файла
            StreamWriter sw = new StreamWriter(fileName);

            // Запись результатов измерений в файл
            sw.WriteLine("Начальные значения");
            string measures = "Серия измерений: ";

            for (int i = 0; i < _originalValues.Count; i++)
            {
                measures += _originalValues[i];
                measures += ' ';
            }

            sw.WriteLine(measures);

            if (_probability == 0)
                sw.WriteLine("Доверительная вероятность: 0,999");
            else if (_probability == 1)
                sw.WriteLine("Доверительная вероятность: 0,99");
            else if (_probability == 2)
                sw.WriteLine("Доверительная вероятность: 0,95");
            else if (_probability == 3)
                sw.WriteLine("Доверительная вероятность: 0,9");

            if (_additionalError != 0)
                sw.WriteLine("Значение дополнительной погрешности: " + _additionalError);
            else
                sw.WriteLine("Значение дополнительной погрешности: не указано");

            if (_accuracyClass == 1 && _errorCharacter != 3)
                sw.WriteLine("Класс точности: 0,05");
            else if (_accuracyClass == 2 && _errorCharacter != 3)
                sw.WriteLine("Класс точности: 0,1");
            else if (_accuracyClass == 3 && _errorCharacter != 3)
                sw.WriteLine("Класс точности: 0,2");
            else if (_accuracyClass == 4 && _errorCharacter != 3)
                sw.WriteLine("Класс точности: 0,5");
            else if (_accuracyClass == 5 && _errorCharacter != 3)
                sw.WriteLine("Класс точности: 1,0");
            else if (_accuracyClass == 6 && _errorCharacter != 3)
                sw.WriteLine("Класс точности: 1,5");
            else if (_accuracyClass == 7 && _errorCharacter != 3)
                sw.WriteLine("Класс точности: 2,5");
            else if (_accuracyClass == 8 && _errorCharacter != 3)
                sw.WriteLine("Класс точности: 4,0");

            if (_errorCharacter == 1)
                sw.WriteLine("Характер основной погрешности: аддитивная");
            if (_errorCharacter == 2)
                sw.WriteLine("Характер основной погрешности: мультипликативная");
            if (_errorCharacter == 3)
                sw.WriteLine("Характер основной погрешности: аддитивная и мультипликативная");

            if (_firstReducedError != "" && _lastReducedError != "" && _errorCharacter == 3)
                sw.WriteLine("Значение основной погрешности в начале и в конце шкалы: " + _firstReducedError + '/' + _lastReducedError);

            if (_normalizingValue != 0)
                sw.WriteLine("Значение нормирующей величины: " + _normalizingValue);

            if (_mainError != 0)
                sw.WriteLine("Значение основной погрешности: " + _mainError);
            else if (_mainError == 0 && _accuracyClass == 0 && _errorCharacter == 0)
                sw.WriteLine("Значение основной погрешности: не указано");

            sw.WriteLine("");
            sw.WriteLine("Результаты");
            sw.WriteLine("Результат измерений: " + resultInfoLabel.Text);
            sw.WriteLine("Промахи: " + missesInfoLabel.Text);
            sw.WriteLine("Общая доверительная граница погрешности: " + resultErrorInfoLabel.Text);

            string noMissesMeasures = "Серия измерений без промахов: ";

            for (int i = 0; i < _measures.Count; i++)
            {
                noMissesMeasures += _measures[i];
                noMissesMeasures += ' ';
            }

            sw.WriteLine(noMissesMeasures);

            if (_mainError != 0)
                sw.WriteLine("Основная погрешность: " + _resultError);

            // Закрытие файла
            sw.Close();
        }
    }
}
