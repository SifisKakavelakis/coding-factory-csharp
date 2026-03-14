using System;
using System.Collections.Generic;
using System.Text;

namespace PointApp.Model
{
    internal class Point3D : Point2D
    {

        public int Z { get; set; }

        public Point3D()
        {
        }

        public Point3D(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }

        public override string ToString() => $"X={X}, Y={Y}, Z={Z}";

        public override void Move5()
        {
            base.Move5();
            Z += 5;
        }
    }
}