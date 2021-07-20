using System;
using System.Collections.Generic;

namespace ValuesEstimating
{
    public class Values
    {
        private List<double> _values;
        private List<double> _originalValues;
        private double _additionalError = 0;
        private double _mainError = 0;
        private int _probability = 0;
        private List<double> _misses;
        private double _probabilityCoefficient = 0;
        private double _result;
        private double _resultError = 0;

        /// <summary>
        /// Конструктор
        /// </summary>
        public Values()
        {
            _values = new List<double>();
            _misses = new List<double>();
            _originalValues = new List<double>();
        }

        /// <summary>
        /// Возвращает серию измерений без промахов
        /// </summary>
        public List<double> Measures
        {
            get
            {
                return _values;
            }
        }

        /// <summary>
        /// Возвращает введённую серию измерений
        /// </summary>
        public List<double> OrigianlValues
        {
            get
            {
                return _originalValues;
            }
        }
        /// <summary>
        /// Возвращает кол-во измерений в серии
        /// </summary>
        public int Count
        {
            get
            {
                return _values.Count;
            }
        }

        /// <summary>
        /// Возвращает результат измерения
        /// </summary>
        public double Result
        {
            get
            {
                return _result;
            }
        }

        /// <summary>
        /// Возвращает общую доверительную границу
        /// </summary>
        public double ResultError
        {
            get
            {
                return _resultError;
            }
        }

        /// <summary>
        /// Возвращает список промахов
        /// </summary>
        public List<double> Misses
        {
            get
            {
                return _misses;
            }
        }

        /// <summary>
        /// Задаёт  или возаращает дополнительную погрешность измерения
        /// </summary>
        public double AdditionalError
        {
            set
            {
                _additionalError = value;
            }

            get
            {
                return _additionalError;
            }
        }

        /// <summary>
        /// Задаёт основную погрешность
        /// </summary>
        public double MainError
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

                if (_probability == 0)
                    _probabilityCoefficient = 1.5;
                else if (_probability == 1)
                    _probabilityCoefficient = 1.4;
                else if (_probability == 2)
                    _probabilityCoefficient = 1.1;
                else if (_probability == 3)
                    _probabilityCoefficient = 0.95;
            }
        }

        /// <summary>
        /// Добавление значений в серию измерений
        /// </summary>
        public void Add(string numbers)
        {
            // Удаление старых значений
            _values.RemoveRange(0, _values.Count);
            _originalValues.RemoveRange(0, _originalValues.Count);

            if (numbers.Length == 0)
                return;

            // Деление строки
            if (numbers[numbers.Length - 1] == ' ')
                numbers = numbers.Remove(numbers.Length - 1, 1);

            string[] splitNumbers = numbers.Split(new char[] { ' ' });

            // Добавление значений к серии измерений
            for (int i = 0; i < splitNumbers.Length; i++)
            {
                double convertedNumber;

                if (double.TryParse(splitNumbers[i], out convertedNumber))
                {
                    _values.Add(convertedNumber);
                    _originalValues.Add(convertedNumber);
                }
                else
                    throw new Exception("Невозможно перевести введёные значения в числовой формат");
            }
        }

        /// <summary>
        /// Взятие модуля числа
        /// </summary>
        private double Abs(double number)
        {
            if (number < 0)
                number += number * (-2);

            return number;
        }

        /// <summary>
        /// Среднее арифметическое результатов измерения
        /// </summary>
        private double Average()
        {
            double average = 0;

            foreach (double measure in _values)
                average += measure;

            average /= _values.Count;

            return average;
        }

        /// <summary>
        /// Средняя квадратическая погрешность
        /// </summary>
        private double SqrtAverage(double average)
        {
            double sqrSumm = 0;

            foreach (double measure in _values)
            {
                double sqrAverage = (measure - average) * (measure - average) / (_values.Count - 1);
                sqrSumm += sqrAverage;
            }

            double sqrtAverage = Math.Sqrt(sqrSumm);

            return sqrtAverage;
        }

        /// <summary>
        /// Нахождение результата измерения
        /// </summary>
        public void FindResult()
        {
            bool missesNotFound = true;
            _misses.Clear();

            do
            {
                // Кол-во измерений
                int count = _values.Count;

                // Среднее арифметическое
                double average = Average();

                // Средняя квадратическая погрешность
                double sqrtAverage = SqrtAverage(average);

                // Минимальный  и максимальный результаты измерения 
                _values.Sort();
                double[] values = new double[count];
                values = _values.ToArray();

                double minValue = values[0];
                double maxValue = values[count - 1];

                // Отклонение минимального и максимального значений от центра
                double minDeviation = Abs(minValue - average) / sqrtAverage;
                double maxDeviation = Abs(maxValue - average) / sqrtAverage;

                Grubbs grubbs = new Grubbs();
                double grubbsDeviation = grubbs.GetDeviation(_probability, count);

                // Проверка наличия промахов
                if (minDeviation > grubbsDeviation)
                {
                    _misses.Add(minValue);
                    _values.RemoveAt(0);
                    missesNotFound = false;
                }
                else if (maxDeviation > grubbsDeviation)
                {
                    _misses.Add(maxValue);
                    _values.RemoveAt(_values.Count - 1);
                    missesNotFound = false;
                }
                else
                    missesNotFound = true;

            } while (!missesNotFound);

            // За результат измерения принимается среднее арифметическое выборки без промахов
            _result = Average();
        }

        /// <summary>
        /// Нахождение обшей доверительной границы погрешности
        /// </summary>
        public void FindError()
        {
            // Среднеквадратическая погрешность среднего арифметического
            double RMSerror = SqrtAverage(_result) / Math.Sqrt(_values.Count);

            // Нахождение соответстующего квантиля распределения Стьюдента
            Student student = new Student();
            double quantile = student.GetQuantile(_probability, _values.Count);

            // Определение доверительной границы случайной погрешности
            double randomError = quantile * RMSerror;

            // Доверительная граница суммарной НСП
            double systematicError;

            if (_additionalError != 0 && _mainError != 0)
            {
                systematicError = _probabilityCoefficient *
                    Math.Sqrt(_additionalError * _additionalError + _mainError * _mainError);
            }
            else if (_additionalError != 0 && _mainError == 0)
            {
                systematicError = _additionalError * _probabilityCoefficient;
            }
            else if (_additionalError == 0 && _mainError != 0)
            {
                systematicError = _mainError * _probabilityCoefficient;
            }
            else
                return;

            // Среднеквадратическая погрешность суммарной НСП
            double systematicRMS = systematicError / (Math.Sqrt(3) * _probabilityCoefficient);

            // Эмприрический коэффициент
            double K = (systematicError + randomError) / (RMSerror + systematicRMS);

            // Суммарная среднеквадратическая погрешность результата измерения
            double resultErrorSumm = Math.Sqrt(systematicRMS * systematicRMS + RMSerror * RMSerror);

            // Общая доверительная граница
            _resultError = K * resultErrorSumm;
        }
    }
}
