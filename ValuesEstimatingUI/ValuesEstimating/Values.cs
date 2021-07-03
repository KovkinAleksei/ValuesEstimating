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
            _values.RemoveRange(0, _values.Count);

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
                    _values.Add(convertedNumber);
                else
                    throw new Exception("Невозможно перевести введёные значения в числовой формат");
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
    }
}
