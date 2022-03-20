using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zmeika
{
    class Apple
    {
        public Point Point
        { 
            get
            {
                return point;
            }
        }

        private Point point;
        private Random randomXY;

        public Apple(List<Point> body)
        {
            point = new Point();
            randomXY = new Random();
            NewPos(body);
        }

        public void NewPos(List<Point> body)
        {
            do
            {
                point.X = (int)Math.Round((double)randomXY.Next(10, 390) / 10) * 10;
                point.Y = (int)Math.Round((double)randomXY.Next(10, 390) / 10) * 10;
            } while (body.Contains(point) == true);           
        }

        public void Show(PaintEventArgs paint)
        {
            SolidBrush b = new SolidBrush(Color.Green);
            paint.Graphics.FillEllipse(b, point.X, point.Y, 10, 10);
        }
    }
}
