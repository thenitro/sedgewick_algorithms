using System;
using sedgewick_algorithms.Chapter_1.Topic_1_1_BasicProgrammingModel;
using sedgewick_algorithms.Chapter_1.Topic_1_2_DataAbstraction;
using sedgewick_algorithms.Chapter_1.Topic_1_4_AnalysisOfAlgorithms;

namespace DrawingsCheck
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //CheckRandomConnections();
            //CheckHistogram();
            //CheckIntersections();
            //CheckVisualCounter();
            CheckDoublingTest();
        }

        private static void CheckRandomConnections()
        {
            new E_1_1_31_RandomConnections().DrawAndConnect(10, 0.5);
        }

        private static void CheckHistogram()
        {
            var N = 100;
            var values = new double[N];

            for (var i = 0; i < N; i++)
            {
                values[i] = new Random().NextDouble() * 10.0;
            }

            new E_1_1_32_Histogram().Draw(10, 0.0, 10.0, values);
        }
        
        private static void CheckIntersections()
        {
            new E_1_2_3_IntersectedIntervals2D().Generate(10, 10, 300);
        }

        private static void CheckVisualCounter()
        {
            var N = 1000;
            var counter = new E_1_2_10_VisualCounter(N, N);

            for (var i = 0; i < N; i++)
            {
                if (new Random().NextDouble() > 0.7)
                {
                    counter.Decrement();
                }
                else
                {
                    counter.Increment();
                }
            }
            
            counter.Draw();
        }

        private static void CheckDoublingTest()
        {
            new E_1_4_3_DoublingTest(5000);
        }
    }
}