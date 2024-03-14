namespace sedgewick_algorithms.Chapter_1.Topic_1_2_DataAbstraction
{
    public class Interval2D
    {
        public Interval1D X { get; }
        public Interval1D Y { get; }

        public Interval2D(Interval1D x, Interval1D y)
        {
            X = x;
            Y = y;
        }

        public bool Intersects(Interval2D other)
        {
            return (X.Intersects(other.X) && Y.Intersects(other.Y)) ||
                   (other.X.Intersects(X) && other.Y.Intersects(Y));
        }
    }
}