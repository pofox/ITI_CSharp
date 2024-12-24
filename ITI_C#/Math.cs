using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_C_
{
    public static class Math
    {
        public static Point3D Add(Point3D p1, Point3D p2)
        {
            return new Point3D(p1.x+p2.x,p1.y+p2.y,p1.z+p2.z);
        }
        public static Point3D Sub(Point3D p1, Point3D p2)
        {
            return new Point3D(p1.x - p2.x, p1.y - p2.y, p1.z - p2.z);
        }
        public static Point3D Mul(Point3D p1, Point3D p2)
        {
            return new Point3D(p1.x * p2.x, p1.y * p2.y, p1.z * p2.z);
        }
        public static Point3D Div(Point3D p1, Point3D p2)
        {
            return new Point3D(p1.x / p2.x, p1.y / p2.y, p1.z / p2.z);
        }
    }
}
