using System;
using System.Collections.Generic;
using System.Text;

namespace ValuesEstimating
{
    class Grubbs
    {
        private double[,] _coefficient;

        /// <summary>
        /// Конструктор
        /// </summary>
        public Grubbs()
        {
            _coefficient = new double[4, 30];

            // Заполнение массива
            _coefficient[0, 3] = 1.414;
            _coefficient[0, 4] = 1.732;
            _coefficient[0, 5] = 1.994;
            _coefficient[0, 6] = 2.212;
            _coefficient[0, 7] = 2.395;
            _coefficient[0, 8] = 2.547;
            _coefficient[0, 9] = 2.677;
            _coefficient[0, 10] = 2.788;
            _coefficient[0, 11] = 2.884;
            _coefficient[0, 12] = 2.969;
            _coefficient[0, 13] = 3.004;
            _coefficient[0, 14] = 3.111;
            _coefficient[0, 15] = 3.171;
            _coefficient[0, 16] = 3.225;
            _coefficient[0, 17] = 3.274;
            _coefficient[0, 18] = 3.320;
            _coefficient[0, 19] = 3.361;
            _coefficient[0, 20] = 3.4;
            _coefficient[0, 21] = 3.436;
            _coefficient[0, 22] = 3.469;
            _coefficient[0, 23] = 3.5;
            _coefficient[0, 24] = 3.529;
            _coefficient[0, 25] = 3.556;
            _coefficient[0, 26] = 3.582;
            _coefficient[0, 27] = 3.606;
            _coefficient[0, 28] = 3.629;
            _coefficient[0, 29] = 3.651;
            _coefficient[0, 30] = 3.672;

            _coefficient[1, 3] = 1.414;
            _coefficient[1, 4] = 1.728;
            _coefficient[1, 5] = 1.972;
            _coefficient[1, 6] = 2.161;
            _coefficient[1, 7] = 2.310;
            _coefficient[1, 8] = 2.431;
            _coefficient[1, 9] = 2.532;
            _coefficient[1, 10] = 2.616;
            _coefficient[1, 11] = 2.689;
            _coefficient[1, 12] = 2.753;
            _coefficient[1, 13] = 2.809;
            _coefficient[1, 14] = 2.859;
            _coefficient[1, 15] = 2.905;
            _coefficient[1, 16] = 2.946;
            _coefficient[1, 17] = 2.983;
            _coefficient[1, 18] = 3.017;
            _coefficient[1, 19] = 3.049;
            _coefficient[1, 20] = 3.079;
            _coefficient[1, 21] = 3.106;
            _coefficient[1, 22] = 3.132;
            _coefficient[1, 23] = 3.156;
            _coefficient[1, 24] = 3.179;
            _coefficient[1, 25] = 3.2;
            _coefficient[1, 26] = 3.22;
            _coefficient[1, 27] = 3.239;
            _coefficient[1, 28] = 3.258;
            _coefficient[1, 29] = 3.275;
            _coefficient[1, 30] = 3.291;

            _coefficient[2, 3] = 1.414;
            _coefficient[2, 4] = 1.71;
            _coefficient[2, 5] = 1.917;
            _coefficient[2, 6] = 2.067;
            _coefficient[2, 7] = 2.182;
            _coefficient[2, 8] = 2.273;
            _coefficient[2, 9] = 2.349;
            _coefficient[2, 10] = 2.414;
            _coefficient[2, 11] = 2.47;
            _coefficient[2, 12] = 2.519;
            _coefficient[2, 13] = 2.563;
            _coefficient[2, 14] = 2.602;
            _coefficient[2, 15] = 2.638;
            _coefficient[2, 16] = 2.67;
            _coefficient[2, 17] = 2.701;
            _coefficient[2, 18] = 2.728;
            _coefficient[2, 19] = 2.754;
            _coefficient[2, 20] = 2.779;
            _coefficient[2, 21] = 2.801;
            _coefficient[2, 22] = 2.823;
            _coefficient[2, 23] = 2.843;
            _coefficient[2, 24] = 2.862;
            _coefficient[2, 25] = 2.88;
            _coefficient[2, 26] = 2.897;
            _coefficient[2, 27] = 2.913;
            _coefficient[2, 28] = 2.929;
            _coefficient[2, 29] = 2.944;
            _coefficient[2, 30] = 2.958;

            _coefficient[3, 3] = 1.412;
            _coefficient[3, 4] = 1.689;
            _coefficient[3, 5] = 1.869;
            _coefficient[3, 6] = 1.996;
            _coefficient[3, 7] = 2.093;
            _coefficient[3, 8] = 2.172;
            _coefficient[3, 9] = 2.238;
            _coefficient[3, 10] = 2.294;
            _coefficient[3, 11] = 2.343;
            _coefficient[3, 12] = 2.387;
            _coefficient[3, 13] = 2.426;
            _coefficient[3, 14] = 2.461;
            _coefficient[3, 15] = 2.494;
            _coefficient[3, 16] = 2.523;
            _coefficient[3, 17] = 2.551;
            _coefficient[3, 18] = 2.557;
            _coefficient[3, 19] = 2.601;
            _coefficient[3, 20] = 2.623;
            _coefficient[3, 21] = 2.644;
            _coefficient[3, 22] = 2.664;
            _coefficient[3, 23] = 2.683;
            _coefficient[3, 24] = 2.701;
            _coefficient[3, 25] = 2.718;
            _coefficient[3, 26] = 2.734;
            _coefficient[3, 27] = 2.749;
            _coefficient[3, 28] = 2.764;
            _coefficient[3, 29] = 2.778;
            _coefficient[3, 30] = 2.792;
        }
    }
}
