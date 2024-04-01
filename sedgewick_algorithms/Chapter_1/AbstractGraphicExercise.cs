using System.Drawing;

namespace sedgewick_algorithms.Chapter_1
{
    public abstract class AbstractGraphicExercise
    {
        protected const int ImageSize = 1000;
        protected Graphics Graphics { get; }
        
        private Bitmap _bitmap;

        public AbstractGraphicExercise()
        {
            _bitmap = new Bitmap(ImageSize, ImageSize, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            
            Graphics = Graphics.FromImage(_bitmap);
            Graphics.Clear(Color.FromKnownColor(KnownColor.White));
        }
        
        protected void SaveImage()
        {
            _bitmap.Save("output.png");
        }
    }
}