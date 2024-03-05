using System;
using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_1_BasicProgrammingModel;

namespace Tests.Chapter_1.Topic_1_1_BasicProgrammingModel
{
    [TestFixture]
    public class Test_E_1_1_37_BadShuffling
    {
        [Test]
        public void SmokeTest()
        {
            const int arraySize = 10;
            const int amountOfShuffles = 10000;

            var arrays = new double[amountOfShuffles][];

            for (var shuffleIndex = 0; shuffleIndex < amountOfShuffles; shuffleIndex++)
            {
                var array = new double[arraySize];

                for (var i = 0; i < arraySize; i++)
                {
                    array[i] = i;
                }
                
                E_1_1_37_BadShuffling.Shuffle(array);

                arrays[shuffleIndex] = array;
            }

            var positions = new int[arraySize, arraySize];

            foreach (var array in arrays)
            {
                for (var index = 0; index < array.Length; index++)
                {
                    positions[index, (int)array[index]]++;
                }
            }
            
            for (var row = 0; row < arraySize; row++)
            {
                for (var col = 0; col < arraySize; col++)
                {
                    Console.Write($"{positions[row, col]} ");
                }

                Console.WriteLine();
            }
        }
    }
}