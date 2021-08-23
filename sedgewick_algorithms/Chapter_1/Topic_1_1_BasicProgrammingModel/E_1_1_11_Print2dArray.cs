using System;
using System.Text;

namespace sedgewick_algorithms.Chapter_1.Topic_1_1_BasicProgrammingModel
{
    public class E_1_1_11_Print2dArray
    {
        private const string STAR = "*";
        private const string SPACE = " ";
        
        public string PrintArray(bool[,] array)
        {
            var result = new StringBuilder();
            
            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var j = 0; j < array.GetLength(1); j++)
                {
                    result.Append(array[i,j] ? STAR : SPACE);
                }

                if (i < array.GetLength(0) - 1)
                {
                    result.AppendLine();
                }
            }

            return result.ToString();
        }
    }
}