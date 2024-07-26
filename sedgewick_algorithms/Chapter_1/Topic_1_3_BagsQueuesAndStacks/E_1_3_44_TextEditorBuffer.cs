using System.Collections.Generic;

namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class E_1_3_44_TextEditorBuffer
    {
        private readonly Stack<char> _left = new Stack<char>();
        private readonly Stack<char> _right = new Stack<char>();
        
        public int Size => _left.Count + _right.Count;
        
        public void Insert(char c)
        {
            _left.Push(c);
        }

        public char Delete()
        {
            return _left.Count == 0 ? default : _left.Pop();
        }

        public void Left(int k)
        {
            while (k > 0)
            {
                if (_left.Count > 0)
                {
                    _right.Push(_left.Pop());
                }

                k--;
            }
        }

        public void Right(int k)
        {
            while (k > 0)
            {
                if (_right.Count > 0)
                {
                    _left.Push(_right.Pop());
                }

                k--;
            }
        }
    }
}