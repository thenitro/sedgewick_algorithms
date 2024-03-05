using System;

namespace sedgewick_algorithms.Chapter_1.Topic_1_1_BasicProgrammingModel
{
    public class E_1_1_37_BadShuffling
    {
        public static void Shuffle(double[] a)
        {
            var arraySize = a.Length;
            
            for (var index = 0; index < arraySize; index++)
            {
                var randomIndex = new Random().Next(arraySize);
                (a[index], a[randomIndex]) = (a[randomIndex], a[index]);
            }
        }
    }
}