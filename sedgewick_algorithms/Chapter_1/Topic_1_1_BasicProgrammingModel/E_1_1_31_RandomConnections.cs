using System;
using System.Drawing;

namespace sedgewick_algorithms.Chapter_1.Topic_1_1_BasicProgrammingModel
{
    public class E_1_1_31_RandomConnections
    {
        public void DrawAndConnect(int N, double p)
        {
            var bitmap = new Bitmap(1000, 1000, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            var graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.FromKnownColor(KnownColor.White));

            var centerX = 500.0;
            var centerY = 500.0;
            
            var circleStep = (Math.PI * 2) / N;

            var distance = 100;

            var prevPositionX = centerX;
            var prevPositionY = centerY;
            
            for (var i = 0; i < N; i++)
            {
                var random = new Random().NextDouble();
                var connectWithPrevious = i != 0 && random < p;
                
                var currentAngle = circleStep * i;
                
                var positionX = centerX + Math.Cos(currentAngle) * distance;
                var positionY = centerY + Math.Sin(currentAngle) * distance;

                if (connectWithPrevious)
                {
                    graphics.DrawLine(Pens.Firebrick, (int)positionX, (int)positionY, (int)prevPositionX, (int)prevPositionY);
                }
                
                graphics.DrawRectangle(Pens.Firebrick, (int)prevPositionX, (int)prevPositionY, 5, 5);

                prevPositionX = positionX;
                prevPositionY = positionY;
            }

            bitmap.Save("output.png");
        }
    }
}