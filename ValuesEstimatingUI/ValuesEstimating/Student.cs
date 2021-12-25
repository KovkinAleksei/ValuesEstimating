using System;
using System.Collections.Generic;
using System.Text;

namespace ValuesEstimating
{
    class Student
    {
        private double[,] _coefficients;

        /// <summary>
        /// Конструктор
        /// </summary>
        public Student()
        {
            _coefficients = new double[4, 31];

            // Заполнение массива
            _coefficients[0, 3] = 31.598;
            _coefficients[0, 4] = 12.941;
            _coefficients[0, 5] = 8.610;
            _coefficients[0, 6] = 6.859;
            _coefficients[0, 7] = 5.959;
            _coefficients[0, 8] = 5.405;
            _coefficients[0, 9] = 5.041;
            _coefficients[0, 10] = 4.781;
            _coefficients[0, 11] = 4.587;
            _coefficients[0, 12] = 4.487;
            _coefficients[0, 13] = 4.318;
            _coefficients[0, 14] = 4.221;
            _coefficients[0, 15] = 4.140;
            _coefficients[0, 16] = 4.073;
            _coefficients[0, 17] = 4.015;
            _coefficients[0, 18] = 3.965;
            _coefficients[0, 19] = 3.992;
            _coefficients[0, 20] = 3.883;
            _coefficients[0, 21] = 3.850;
            _coefficients[0, 22] = 3.819;
            _coefficients[0, 23] = 3.792;
            _coefficients[0, 24] = 3.767;
            _coefficients[0, 25] = 3.745;
            _coefficients[0, 26] = 3.725;
            _coefficients[0, 27] = 3.707;
            _coefficients[0, 28] = 3.69;
            _coefficients[0, 29] = 3.674;
            _coefficients[0, 30] = 3.659;

            _coefficients[1, 3] = 9.925;
            _coefficients[1, 4] = 5.841;
            _coefficients[1, 5] = 4.604;
            _coefficients[1, 6] = 4.032;
            _coefficients[1, 7] = 3.707;
            _coefficients[1, 8] = 3.499;
            _coefficients[1, 9] = 3.355;
            _coefficients[1, 10] = 3.25;
            _coefficients[1, 11] = 3.169;
            _coefficients[1, 12] = 3.103;
            _coefficients[1, 13] = 3.055;
            _coefficients[1, 14] = 3.012;
            _coefficients[1, 15] = 2.977;
            _coefficients[1, 16] = 2.947;
            _coefficients[1, 17] = 2.921;
            _coefficients[1, 18] = 2.898;
            _coefficients[1, 19] = 2.878;
            _coefficients[1, 20] = 2.861;
            _coefficients[1, 21] = 2.845;
            _coefficients[1, 22] = 2.831;
            _coefficients[1, 23] = 2.819;
            _coefficients[1, 24] = 2.807;
            _coefficients[1, 25] = 2.797;
            _coefficients[1, 26] = 2.787;
            _coefficients[1, 27] = 2.779;
            _coefficients[1, 28] = 2.771;
            _coefficients[1, 29] = 2.763;
            _coefficients[1, 30] = 2.756;

            _coefficients[2, 3] = 4.303;
            _coefficients[2, 4] = 3.182;
            _coefficients[2, 5] = 2.776;
            _coefficients[2, 6] = 2.571;
            _coefficients[2, 7] = 2.447;
            _coefficients[2, 8] = 2.365;
            _coefficients[2, 9] = 2.306;
            _coefficients[2, 10] = 2.262;
            _coefficients[2, 11] = 2.228;
            _coefficients[2, 12] = 2.201;
            _coefficients[2, 13] = 2.179;
            _coefficients[2, 14] = 2.160;
            _coefficients[2, 15] = 2.145;
            _coefficients[2, 16] = 2.131;
            _coefficients[2, 17] = 2.12;
            _coefficients[2, 18] = 2.11;
            _coefficients[2, 19] = 2.103;
            _coefficients[2, 20] = 2.093;
            _coefficients[2, 21] = 2.086;
            _coefficients[2, 22] = 2.08;
            _coefficients[2, 23] = 2.074;
            _coefficients[2, 24] = 2.069;
            _coefficients[2, 25] = 2.064;
            _coefficients[2, 26] = 2.06;
            _coefficients[2, 27] = 2.056;
            _coefficients[2, 28] = 2.052;
            _coefficients[2, 29] = 2.048;
            _coefficients[2, 30] = 2.045;

            _coefficients[3, 3] = 2.92;
            _coefficients[3, 4] = 2.353;
            _coefficients[3, 5] = 2.132;
            _coefficients[3, 6] = 2.015;
            _coefficients[3, 7] = 1.943;
            _coefficients[3, 8] = 1.895;
            _coefficients[3, 9] = 1.860;
            _coefficients[3, 10] = 1.833;
            _coefficients[3, 11] = 1.812;
            _coefficients[3, 12] = 1.796;
            _coefficients[3, 13] = 1.782;
            _coefficients[3, 14] = 1.771;
            _coefficients[3, 15] = 1.761;
            _coefficients[3, 16] = 1.753;
            _coefficients[3, 17] = 1.746;
            _coefficients[3, 18] = 1.74;
            _coefficients[3, 19] = 1.734;
            _coefficients[3, 20] = 1.729;
            _coefficients[3, 21] = 1.725;
            _coefficients[3, 22] = 1.721;
            _coefficients[3, 23] = 1.717;
            _coefficients[3, 24] = 1.714;
            _coefficients[3, 25] = 1.711;
            _coefficients[3, 26] = 1.708;
            _coefficients[3, 27] = 1.706;
            _coefficients[3, 28] = 1.703;
            _coefficients[3, 29] = 1.701;
            _coefficients[3, 30] = 1.699;
        }

        /// <summary>
        /// Возвращает квантиль Стьюдента
        /// </summary>
        public double GetQuantile(int probability, int count)
        {
            return _coefficients[probability, count];
        }
    }
}
