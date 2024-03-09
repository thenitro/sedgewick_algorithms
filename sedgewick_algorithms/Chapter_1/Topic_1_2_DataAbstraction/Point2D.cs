using System;

namespace sedgewick_algorithms.Chapter_1.Topic_1_2_DataAbstraction
{
    public class Point2D
    {
        public double X { get; }
        public double Y { get; }

        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double DistanceTo(Point2D other)
        {
            var dx = X - other.X;
            var dy = Y - other.Y;
            
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}