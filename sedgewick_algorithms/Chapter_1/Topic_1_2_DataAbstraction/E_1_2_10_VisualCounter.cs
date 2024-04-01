using System.Drawing;

namespace sedgewick_algorithms.Chapter_1.Topic_1_2_DataAbstraction
{
    public class E_1_2_10_VisualCounter : AbstractGraphicExercise
    {
        private readonly int _N;
        private readonly int _max;
        
        private readonly int[] _memo;
        
        private int _operationsCounter = 0;
        private int _counter = 0;

        public E_1_2_10_VisualCounter(int N, int max)
        {
            _N = N;
            _max = max;
            _memo = new int[N];
        }

        public void Increment()
        {
            _counter++;
            TallyChanged();
        }

        public void Decrement()
        {
            _counter--;
            TallyChanged();
        }

        public void Draw()
        {
            var operationWidth = ImageSize / _N;
            var operationHeight = ImageSize;

            var maxValue = _max;
            
            for (var i = 0; i < _N; i++)
            {
                var value = _memo[i];
                var relativeValue = (double)value / maxValue;
                
                var x = operationWidth * i;
                var y = (int)(operationHeight * (1.0 - relativeValue));

                var width = operationWidth;
                var height = operationHeight - y;
                
                Graphics.DrawRectangle(Pens.Firebrick, x, y, width, height);
            }
            
            SaveImage();
        }

        private void TallyChanged()
        {
            _memo[_operationsCounter] = _counter;
            _operationsCounter++;
        }
    }
}