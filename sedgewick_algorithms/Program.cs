using sedgewick_algorithms.Chapter_1.Topic_1_1_BasicProgrammingModel;

namespace sedgewick_algorithms
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            TestPrint2dArray();
        }

        private static void TestPrint2dArray()
        {
            var input = new[]
            {
                new[] { false, false, true, false, false, },
                new[] { false, false, true, false, false, },
                new[] { true, true, true, true, true, },
                new[] { false, false, true, false, false, },
                new[] { false, false, true, false, false, },
            };

            new E_1_1_11_Print2dArray().PrintArray(input);
        }
    }
}