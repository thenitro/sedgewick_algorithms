using System;

namespace sedgewick_algorithms.Chapter_1.Topic_1_4_AnalysisOfAlgorithms
{
    public class E_1_4_11_StaticSetOfInts
    {
        private readonly int[] _keys;
        
        public E_1_4_11_StaticSetOfInts(int[] keys)
        {
            _keys = new int[keys.Length];

            for (var i = 0; i < keys.Length; i++)
            {
                _keys[i] = keys[i];
            }
            
            Array.Sort(_keys);
        }

        public bool Contains(int key)
        {
            return Rank(key) != -1;
        }

        public int HowMany(int key)
        {
            var index = Rank(key);
            if (index == -1) return 0;
            var counter = 0;

            while (index < _keys.Length && _keys[index] == key)
            {
                index++;
                counter++;
            }

            return counter;
        }

        private int Rank(int key)
        {
            var lo = 0;
            var hi = _keys.Length - 1;

            while (lo <= hi)
            {
                var mid = lo + (hi - lo) / 2;
                if (key < _keys[mid])
                {
                    hi = mid - 1;
                }
                else if (key > _keys[mid])
                {
                    lo = mid + 1;
                }
                else
                {
                    hi = mid - 1;
                }
            }

            return lo < _keys.Length && _keys[lo] == key ? lo : -1;
        }
    }
}