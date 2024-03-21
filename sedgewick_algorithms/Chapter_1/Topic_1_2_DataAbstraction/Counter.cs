namespace sedgewick_algorithms.Chapter_1.Topic_1_2_DataAbstraction
{
    public class Counter
    {
        private readonly string _name;
        private int _count;

        public Counter(string name)
        {
            _name = name;
        }

        public void Increment()
        {
            _count++;
        }

        public int Tally => _count;

        public override string ToString()
        {
            return _count + " " + _name;
        }
    }
}