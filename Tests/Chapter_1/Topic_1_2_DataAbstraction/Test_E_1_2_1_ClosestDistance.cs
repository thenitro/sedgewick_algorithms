using System;
using System.Collections.Generic;
using NUnit.Framework;
using sedgewick_algorithms.Chapter_1.Topic_1_2_DataAbstraction;

namespace Tests.Chapter_1.Topic_1_2_DataAbstraction
{
    [TestFixture]
    public class Test_E_1_2_1_ClosestDistance
    {
        private static IEnumerable<TestCaseData> SmokeTestData
        {
            get
            {
                yield return new TestCaseData(100, new Rect(0, 0, 100, 100));
            }
        }

        [Test]
        [TestCaseSource(nameof(SmokeTestData))]
        public void Smoke(int N, Rect pointsRect)
        {
            var pointsToTest = new Point2D[N];
            
            for (var i = 0; i < N; i++)
            {
                pointsToTest[i] = new Point2D(
                    pointsRect.X + new Random().NextDouble() * pointsRect.Width,
                    pointsRect.Y + new Random().NextDouble() * pointsRect.Height);
            }

            var (pointA, pointB) = new E_1_2_1_ClosestDistance().GetClosestPair(pointsToTest);
            
            Console.WriteLine($"Smallest distance is {pointA.DistanceTo(pointB)}");
        }
    }
}