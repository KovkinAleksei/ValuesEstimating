using System;
using System.Collections.Generic;

namespace ValuesEstimating
{
    public class Values
    {
        private List<double> _values;

        /// <summary>
        /// Конструктор
        /// </summary>
        public Values()
        {
            _values = new List<double>();
        }

        /// <summary>
        /// Добавление значений в серию измерений
        /// </summary>
        public void Add(string numbers)
        {
            // Удаление старых значений
            for (int j = 0; j < _values.Count; j++)
                _values.RemoveAt(j);

            // Деление строки
            string[] splitNumbers = numbers.Split(new char[] { ' ' });

            // Добавление значений к серии измерений
            for (int i = 0; i < splitNumbers.Length; i++)
            {
                double convertedNumber;

                if (double.TryParse(splitNumbers[i], out convertedNumber))
                    _values.Add(convertedNumber);
                else
                    throw new Exception("Невозможно перевести введёные значения в числовой формат");
            }
        }
    }
}
