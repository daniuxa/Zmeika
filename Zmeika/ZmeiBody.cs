using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeika
{
    class ZmeiBody
    {
        private Stack<Point> body;

        public ZmeiBody()
        {
            body = new Stack<Point>();           
        }

        public void Add(ref Point point)
        {
            body.Push(point);
        }

        public Point this[int index]
        {
            get
            {
                int Count = 0;
                foreach (var item in body)
                {
                    if (Count == index)
                    {
                        return item;
                    }
                    Count++;
                }
                return default(Point);
            }
        }


    }
}
