namespace ITI_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x, y, z;
            Point3D p1, p2;
            Console.Write("P1.x = ");
            while (!float.TryParse(Console.ReadLine(),out x))
            {
                Console.ResetColor();
                Console.WriteLine("Error Try Again");
                Console.ResetColor();
                Console.Write("P1.x = ");
            }
        }
    }
}
