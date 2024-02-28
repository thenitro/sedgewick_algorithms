using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace sedgewick_algorithms.Chapter_1.Topic_1_1_BasicProgrammingModel
{
    public class E_1_1_32_Histogram
    {
        /**
         * This is definitely fast-handed solution, which is O(M * N), where M is amount of values
         * and it seems to me like it's could be solved using modification of binary search or binary tree down to O(M log N)
         * which is not significant improvement, but still could be nice to explore
         */
        public void Draw(int N, double l, double r, double[] values)
        {
            var step = (r - l) / N;
            var buckets = new List<double>[N];
            var intervals = new Interval[N];
            
            for (int i = 0; i < N; i++)
            {
                var left = l + step * i;
                var right = left + step;
                
                intervals[i] = new Interval(i, left, right, i == N - 1);
                buckets[i] = new List<double>();
            }

            foreach (var value in values)
            {
                foreach (var interval in intervals)
                {
                    if (interval.IsInInterval(value))
                    {
                        buckets[interval.Index].Add(value);
                        break;
                    }
                }
            }

            DrawHistogram(buckets);
        }

        private void DrawHistogram(List<double>[] buckets)
        {
            var imageSize = 1000;
            
            var bitmap = new Bitmap(imageSize, imageSize, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            var graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.FromKnownColor(KnownColor.White));

            var graphOffset = 100;
            var canvasSize = imageSize - graphOffset * 2;
            var barSize = canvasSize / buckets.Length;
            var maxCount = buckets.Max(l => l.Count);
            
            for (var i = 0; i < buckets.Length; i++)
            {
                var bucket = buckets[i];
                
                var width = barSize;
                var height = canvasSize * (1.0 * bucket.Count / maxCount);
                
                var positionX = graphOffset + barSize * i;
                var positionY = graphOffset + (canvasSize - height);
                
                graphics.DrawRectangle(Pens.Firebrick, positionX, (int)positionY, width, (int)height);
            }
            
            bitmap.Save("output.png");
        }

        private class Interval
        {
            public int Index { get; }
            private readonly double _left;
            private readonly double _right;
            private readonly bool _includeRight;

            public Interval(int index, double left, double right, bool includeRight)
            {
                Index = index;
                
                _left = left;
                _right = right;
                _includeRight = includeRight;
            }

            public bool IsInInterval(double value)
            {
                return value >= _left &&
                       (_includeRight ? value <= _right : value < _right);
            }
        }
    }
}