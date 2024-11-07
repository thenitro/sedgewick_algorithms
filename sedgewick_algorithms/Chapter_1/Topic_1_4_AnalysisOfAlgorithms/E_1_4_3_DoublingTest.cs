using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;

namespace sedgewick_algorithms.Chapter_1.Topic_1_4_AnalysisOfAlgorithms
{
    public class E_1_4_3_DoublingTest : AbstractGraphicExercise
    {
        public E_1_4_3_DoublingTest(int max)
        {
            var trials = new List<double>();
            
            for (var N = 250; N < max; N += N)
            {
                Console.WriteLine($"starting {N}...");
                var time = TimeTrial(N);
                trials.Add(time);
                Console.WriteLine($"elapsed {N} {time}");
            }

            Console.WriteLine("done.");
            
            Draw(trials);
        }

        private double TimeTrial(int N)
        {
            var max = 1000000;
            var a = new int[N];

            for (var i = 0; i < N; i++)
            {
                a[i] = new Random().Next(-max, max);
            }

            Stopwatch timer = new Stopwatch();
            timer.Start();
            int count = ThreeSum.Count(a);
            return timer.ElapsedMilliseconds;
        }
        
        private void Draw(List<double> trials)
        {
            var operationWidth = ImageSize / trials.Count;
            var operationHeight = ImageSize;

            var maxValue = trials.Max();
            
            for (var i = 0; i < trials.Count; i++)
            {
                var value = trials[i];
                var relativeValue = (double)value / maxValue;
                
                var x = operationWidth * i;
                var y = (int)(operationHeight * (1.0 - relativeValue));

                var width = operationWidth;
                var height = operationHeight - y;
                
                Graphics.DrawRectangle(Pens.Firebrick, x, y, width, height);
            }
            
            SaveImage();
        }
    }

    public class ThreeSum
    {
        public static int Count(int[] a)
        {
            var N = a.Length;
            var count = 0;

            for (var i = 0; i < N; i++)
            {
                for (var j = i + 1; j < N; j++)
                {
                    for (var k = j + 1; k < N; k++)
                    {
                        if (a[i] + a[j] + a[k] == 0) count++;
                    }
                }
            }

            return count;
        }
    }
}