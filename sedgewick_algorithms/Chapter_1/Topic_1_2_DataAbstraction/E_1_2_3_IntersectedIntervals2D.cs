using System;
using System.Drawing;

namespace sedgewick_algorithms.Chapter_1.Topic_1_2_DataAbstraction
{
    public class E_1_2_3_IntersectedIntervals2D : AbstractGraphicExercise
    {
        public void Generate(int N, int min, int max)
        {
            Graphics.DrawRectangle(Pens.OrangeRed, min, min, max, max);
            
            var intervals = new Interval2D[N];

            for (var i = 0; i < N; i++)
            {
                var x = GenerateInterval(min, max);
                var y = GenerateInterval(min, max);
                
                intervals[i] = new Interval2D(x, y);
                
                Graphics.DrawRectangle(Pens.LawnGreen, (int)x.Lo, (int)y.Lo, (int)(x.Hi - x.Lo), (int)(y.Hi - y.Lo));
            }

            var intersectingIntervals = 0;
            
            foreach (var intervalA in intervals)
            {
                foreach (var intervalB in intervals)
                {
                    if (intervalA == intervalB) continue;
                    if (intervalA.Intersects(intervalB))
                    {
                        intersectingIntervals++;
                    }
                }
            }

            Console.WriteLine($"Amount of intersections {intersectingIntervals}");
            
            SaveImage();
        }

        private Interval1D GenerateInterval(int min, int max)
        {
            var lo = new Random().Next(min, max);
            var hi = new Random().Next(min, max);

            if (lo > hi)
            {
                (lo, hi) = (hi, lo);
            }
            
            Console.WriteLine($"lo {lo} hi {hi}");

            return new Interval1D(lo, hi);
        }
    }
}