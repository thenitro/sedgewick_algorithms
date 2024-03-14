using System;
using System.Drawing;

namespace sedgewick_algorithms.Chapter_1.Topic_1_1_BasicProgrammingModel
{
    public class E_1_1_31_RandomConnections : AbstractGraphicExercise
    {
        public void DrawAndConnect(int N, double p)
        {
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
                    Graphics.DrawLine(Pens.Firebrick, (int)positionX, (int)positionY, (int)prevPositionX, (int)prevPositionY);
                }
                
                Graphics.DrawRectangle(Pens.Firebrick, (int)prevPositionX, (int)prevPositionY, 5, 5);

                prevPositionX = positionX;
                prevPositionY = positionY;
            }

            SaveImage();
        }
    }
}