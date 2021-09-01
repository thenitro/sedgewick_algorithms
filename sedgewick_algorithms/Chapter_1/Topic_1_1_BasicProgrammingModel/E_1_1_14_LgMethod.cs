using System;

namespace sedgewick_algorithms.Chapter_1.Topic_1_1_BasicProgrammingModel
{
    public class E_1_1_14_LgMethod
    {
        public int Lg(int value)
        {
            if (value == 0)
            {
                return int.MinValue;
            }

            if (value == 1)
            {
                return 0;
            }

            var result = 1;
            var calculation = 2;

            while (calculation < value)
            {
                calculation *= 2;
                result++;
            }

            return result;
        }
    }
}