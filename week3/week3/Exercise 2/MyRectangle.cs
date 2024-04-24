using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3.Exercise_2
{
    internal class MyRectangle
    {
        public double Perimeter { get; set; }
        public double Area { get; set; }

        public MyRectangle(Point a, Point b)
        {
            Perimeter = Math.Abs(a.X - b.X) * 2 + Math.Abs(a.Y - b.Y) * 2;
            Area = Math.Abs(a.X - b.X) * Math.Abs(a.Y - b.Y);
        }

    }
}
