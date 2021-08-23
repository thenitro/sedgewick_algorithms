using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_1_BasicProgrammingModel;

namespace Tests.Chapter_1.Topic_1_1_BasicProgrammingModel
{
    [TestFixture]
    public class Test_E_1_1_11_Print2dArray
    {
        [Test]
        public void Smoke()
        {
            var input = new [,]
            {
                { false, false, true, false, false, },
                { false, false, true, false, false, },
                { true, true, true, true, true, },
                { false, false, true, false, false, },
                { false, false, true, false, false, },
            };

            var result = new E_1_1_11_Print2dArray().PrintArray(input);
            var expected =
                "  *  \n" +
                "  *  \n" +
                "*****\n" +
                "  *  \n" +
                "  *  ";
            
            Assert.AreEqual(expected, result);
        }
    }
}