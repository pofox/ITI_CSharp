namespace ITI_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(1, new DateTime(2000, 1, 1),15);
            Employee e2 = new Employee(2,new DateTime(1975, 3, 4),20);
            Employee e3 = new Employee(3,new DateTime(1919, 12, 7),17);
            Employee e4 = new Employee(4,new DateTime(2001, 2, 26),23);
            Department d1 = new Department(1,"department1");
            Department d2 = new Department(2,"department2");
            SalesPerson s1 = new SalesPerson(5,new DateTime(2002, 5, 18),15);
            SalesPerson s2 = new SalesPerson(6,new DateTime(1992, 7, 11),20);
            BoardMember b1 = new BoardMember(7,new DateTime(2002, 4, 8));
            BoardMember b2 = new BoardMember(8,new DateTime(1954, 9, 16));
            Club club = new Club(1,"Club");
            club.AddMember(e1);
            club.AddMember(e2);
            club.AddMember(e3);
            club.AddMember(e4);
            club.AddMember(b1);
            club.AddMember(b2);
            club.AddMember(s1);
            club.AddMember(s2);
            d1.AddStaff(e1);
            d1.AddStaff(e2);
            d1.AddStaff(b1);
            d1.AddStaff(s1);
            d2.AddStaff(e3);
            d2.AddStaff(e4);
            d2.AddStaff(b2);
            d2.AddStaff(s2);
            Console.WriteLine(d1.ToString());
            Console.WriteLine();
            Console.WriteLine(d2.ToString());
            Console.WriteLine();
            Console.WriteLine(club.ToString());
            Console.WriteLine();
            Console.WriteLine("b1 resigned");
            Console.WriteLine();
            b1.Resign();
            Console.WriteLine(d1.ToString());
            Console.WriteLine();
            Console.WriteLine(club.ToString());
            Console.WriteLine();
            Console.WriteLine("e3 and b2 are too old");
            Console.WriteLine();
            e3.BirthDate = new DateTime(1919, 12, 7);
            b2.BirthDate = new DateTime(1954, 9, 16);
            Console.WriteLine(d2.ToString());
            Console.WriteLine();
            Console.WriteLine(club.ToString());
            Console.WriteLine();
            Console.WriteLine("s2 didn't achive the target");
            Console.WriteLine();
            s2.CheckTarget(30);
            Console.WriteLine(d2.ToString());
            Console.WriteLine();
            Console.WriteLine(club.ToString());
            Console.WriteLine();
            Console.WriteLine("e1 took too many vacations");
            Console.WriteLine();
            e1.VacationStock = -1;
            Console.WriteLine(d1.ToString());
            Console.WriteLine();
            Console.WriteLine(club.ToString());
            Console.WriteLine();
        }
    }
}
