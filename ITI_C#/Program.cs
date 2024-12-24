using System.Security.Cryptography;

namespace ITI_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Point3D p1 = new Point3D(), p2 = new Point3D();
            Console.Write("P1.x = ");
            while (!int.TryParse(Console.ReadLine(),out x))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error Try Again");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("P1.x = ");
            }
            Console.Write("P1.y = ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("P1.z = ");
            z = int.Parse(Console.ReadLine());
            p1.x = x;
            p1.y = y;
            p1.z = z;
            Console.Write("P2.x = ");
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error Try Again");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("P2.x = ");
            }
            Console.Write("P2.y = ");
            while (!int.TryParse(Console.ReadLine(), out y))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error Try Again");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("P2.y = ");
            }
            Console.Write("P2.z = ");
            while (!int.TryParse(Console.ReadLine(), out z))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error Try Again");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("P2.z = ");
            }
            p2.x = x;
            p2.y = y;
            p2.z = z;
            Console.WriteLine(p1);
            Console.WriteLine((string)p2);
            Console.WriteLine(p1 == p2 ? "P1 == P2" : "P1 != P2");
            Console.WriteLine("p1 + p2 = " + Math.Add(p1,p2));
            Console.WriteLine("p1 - p2 = " + Math.Sub(p1,p2));
            Console.WriteLine("p1 * p2 = " + Math.Mul(p1,p2));
            Console.WriteLine("p1 / p2 = " + Math.Div(p1, p2));
            Point3D[] points = new Point3D[3];
            Console.WriteLine("Unsorted random points");
            for (int i = 0; i < 3; i++)
            {
                points[i]=new Point3D(RandomNumberGenerator.GetInt32(10), RandomNumberGenerator.GetInt32(10),RandomNumberGenerator.GetInt32(10));
                Console.WriteLine(points[i]);
            }
            Array.Sort(points);
            Console.WriteLine("Sorted points");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(points[i]);
            }

            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString());
            Duration D2 = new Duration(3600);
            Console.WriteLine(D2.ToString());
            Duration D3 = new Duration(7800);
            Console.WriteLine(D3.ToString());
            Duration D4 = new Duration(666);
            Console.WriteLine(D4.ToString());
            D3 = D1 + D2;
            Console.WriteLine(D3.ToString());
            D3 = D1 + 7800;
            Console.WriteLine(D3.ToString());
            D3 = 666 + D3;
            Console.WriteLine(D1.ToString());
            Console.WriteLine(D2.ToString());
            Console.WriteLine(D3.ToString());
            D3 = D1++;
            Console.WriteLine(D1.ToString());
            Console.WriteLine(D2.ToString());
            Console.WriteLine(D3.ToString());
            D3 = --D2;
            Console.WriteLine(D1.ToString());
            Console.WriteLine(D2.ToString());
            Console.WriteLine(D3.ToString());
            D1 = -D2;
            Console.WriteLine(D1.ToString());
            Console.WriteLine(D2.ToString());
            Console.WriteLine(D3.ToString());
            Console.WriteLine("D1 > D2 ?");
            Console.WriteLine(D1 > D2);
            Console.WriteLine("D1 <= D2 ?");
            Console.WriteLine(D1 <= D2);
            Console.WriteLine("D1 ?");
            Console.WriteLine(D1);
            D1 = new Duration(7200);
            DateTime Obj = (DateTime)D1;
            Console.WriteLine(Obj.ToString());
        }
    }
}
