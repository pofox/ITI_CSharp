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
        }
    }
}
