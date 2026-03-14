using System;
using System.Collections.Generic;
using System.Text;

namespace PointApp.Model
{
    internal class Point
    {
        public int X { get; set; }

        public Point()
        {

        }

        public Point(int x)
        {
            X = x;
        }

        public override string ToString() => $"X={X}";

        public virtual void Move5()
        {
            X += 5;
        }

    }
}