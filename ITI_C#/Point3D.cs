using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_C_
{
    internal class Point3D
    {
        public float x {  get; set; }
        public float y { get; set; }
        public float z { get; set; }
        Point3D()
        {
            x = default;
            y = default;
            z = default;
        }
        Point3D(float _x, float _y, float _z):this(_x, _y)
        {
            z = _z;
        }
        Point3D(Point3D p)
        {
            x = p.x;
            y = p.y;
            z = p.z;
        }
        Point3D(float _x)
        {
            x = _x;
        }
        Point3D(float _x,float _y):this(_x)
        {
            y = _y;
        }
        public static implicit operator string(Point3D p)
        {
            return $"Point Coordinates: ({p.x}, {p.y}, {p.z})";
        }
        public override string ToString()
        {
            return $"Point Coordinates: ({x}, {y}, {z})";
        }
    }
}
