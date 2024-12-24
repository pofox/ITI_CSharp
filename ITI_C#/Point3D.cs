using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_C_
{
    public class Point3D:ICloneable,IComparable
    {
        public int x {  get; set; }
        public int y { get; set; }
        public int z { get; set; }
        public Point3D()
        {
            x = default;
            y = default;
            z = default;
        }
        public Point3D(int _x, int _y, int _z):this(_x, _y)
        {
            z = _z;
        }
        public Point3D(Point3D p)
        {
            x = p.x;
            y = p.y;
            z = p.z;
        }
        public Point3D(int _x)
        {
            x = _x;
        }
        public Point3D(int _x,int _y):this(_x)
        {
            y = _y;
        }
        public static implicit operator string(Point3D p)
        {
            return $"Point Coordinates: ({p.x}, {p.y}, {p.z})";
        }
        public static bool operator ==(Point3D p1, Point3D p2)
        {
            return p1.Equals(p2);
        }
        public static bool operator !=(Point3D p1, Point3D p2)
        {
            return !p1.Equals(p2);
        }
        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Point3D))
                return false;
            Point3D p = (Point3D)obj;
            if (GetType() != p.GetType())
                return false;
            return x == p.x && y == p.y && z == p.z;
        }
        public override string ToString()
        {
            return $"Point Coordinates: ({x}, {y}, {z})";
        }

        public object Clone()
        {
            Point3D p = new Point3D(x,y,z);
            return p;
        }

        public int CompareTo(object? obj)
        {
            if (obj == null || !(obj is Point3D))
                throw new ArgumentException();
            Point3D p = (Point3D)obj;
            if (GetType()!=p.GetType())
                throw new ArgumentException();
            return (x * x + y * y + z * z).CompareTo(p.x * p.x + p.y * p.y + p.z * p.z);
        }
    }
}
