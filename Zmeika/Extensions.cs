using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeika
{
    public static class Extensions
    {
        public static void AddRange(this Point[] points, IEnumerable<Point> ts, int AmountAdded)
        {
            int NewSize = AmountAdded;
            int Count = 0;

            if (points == null)
            {
                return;
            }


            foreach (var item in ts)
            {
                points.Append(item);

                Count++;
                if (Count == NewSize)
                {
                    break;
                }
            }
        }
    }
}
