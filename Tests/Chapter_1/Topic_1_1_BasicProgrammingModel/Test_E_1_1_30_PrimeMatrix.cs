using System;
using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_1_BasicProgrammingModel;

namespace Tests.Chapter_1.Topic_1_1_BasicProgrammingModel
{
    [TestFixture]
    public class Test_E_1_1_30_PrimeMatrix
    {
        [Test]
        public void Smoke()
        {
            var expected = new bool[,]
            {
                { true, true, true, true, false },
                { true, true, true, true, false },
                { true, true, true, true, false },
                { true, true, true, true, false },
                { false, false, false, false, false },
            };
            
            var result = new E_1_1_30_PrimeMatrix().Build(5);

            for (var i = 0; i < result.GetLength(0); i++)
            {
                for (var j = 0; j < result.GetLength(1); j++)
                {
                    Assert.AreEqual(expected[i, j], result[i, j]);
                }
            }
        }
    }
}