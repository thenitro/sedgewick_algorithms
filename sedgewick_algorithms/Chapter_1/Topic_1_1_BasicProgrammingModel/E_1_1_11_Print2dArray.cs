using System;

namespace sedgewick_algorithms.Chapter_1.Topic_1_1_BasicProgrammingModel
{
    public class E_1_1_11_Print2dArray
    {
        public void PrintArray(bool[][] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] ? "*" : " ");
                }

                Console.WriteLine();
            }
        }
    }
}