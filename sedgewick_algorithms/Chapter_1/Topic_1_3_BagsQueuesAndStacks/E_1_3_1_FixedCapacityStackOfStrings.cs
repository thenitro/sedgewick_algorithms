namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class E_1_3_1_FixedCapacityStackOfStrings
    {
        public bool IsEmpty => _n == 0;
        public int Size => _n;
        public bool IsFull => _n == _a.Length;

        private readonly string[] _a;
        private int _n;

        public E_1_3_1_FixedCapacityStackOfStrings(int cap)
        {
            _a = new string[cap];
        }

        public void Push(string item)
        {
            _a[_n++] = item;
        }

        public string Pop()
        {
            return _a[--_n];
        }
    }
}