using System;

namespace sedgewick_algorithms.Chapter_1.Topic_1_1_BasicProgrammingModel
{
    public class E_1_1_14_LgMethod
    {
        public double Lg(double value)
        {
            if (value == 0)
            {
                return double.NegativeInfinity;
            }

            if (Math.Abs(value - 1) < Double.Epsilon)
            {
                return 0;
            }

            var result = 1;
            
            
        }
    }
}