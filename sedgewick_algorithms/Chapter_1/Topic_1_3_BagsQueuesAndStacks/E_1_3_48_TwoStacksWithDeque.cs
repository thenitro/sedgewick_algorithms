namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class E_1_3_48_TwoStacksWithDeque<T>
    {
        private E_1_3_33_Deque_DoublyLinkedList<T> _deque = new E_1_3_33_Deque_DoublyLinkedList<T>();

        public int FirstCount { get; private set; }
        
        public void FirstPush(T item)
        {
            _deque.PushLeft(item);
            FirstCount++;
        }

        public T FirstPop()
        {
            if (FirstCount <= 0) return default;
            FirstCount--;
            return _deque.PopLeft();
        }
        
        public int SecondCount { get; private set; }
        
        public void SecondPush(T item)
        {
            SecondCount++;
            _deque.PushRight(item);
        }

        public T SecondPop()
        {
            if (SecondCount <= 0) return default;
            SecondCount--;
            return _deque.PopRight();
        }
    }
}