using System.Diagnostics;
using ClassLibrary1;

namespace ITI_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int thisYear = 2024;
            Employee[] EmpArr = new Employee[3];
            for (int i=0;i<EmpArr.Length;i++)
            {
                EmpArr[i] = new Employee();
                EmpArr[i].SetID(i+1);
                Console.WriteLine("Enter Name");
                string name = Console.ReadLine();
                EmpArr[i].SetName(name);
                Console.WriteLine("Enter Age");
                int Age;
                while(!int.TryParse(Console.ReadLine(), out Age)||Age<18||Age>45)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Enter A valid Age [a number between 18 and 45]");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                EmpArr[i].SetAge(Age);
                Console.WriteLine("Enter Target");
                int Target;
                while(!int.TryParse(Console.ReadLine(),out Target)||Target<300)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Enter A valid Target [a number grater than 300]");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                EmpArr[i].SetTarget(Target);
                Console.WriteLine("Enter Security Level [admin,hr,officer] [0,1,2]");
                int securityLevel; 
                while(!int.TryParse(Console.ReadLine(),out securityLevel)||(securityLevel!=0&&securityLevel!=1&&securityLevel!=2))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Enter A valid Security Level [a number 0 or 1 or 2]");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                SecurityLevel security = new SecurityLevel();
                switch (securityLevel)
                {
                    case 0:
                        security = SecurityLevel.admin;
                        break;
                    case 1:
                        security = SecurityLevel.hr;
                        break;
                    case 2:
                        security = SecurityLevel.officer;
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Enter salary");
                int salary;
                while(!int.TryParse(Console.ReadLine(),out salary)||salary<6000||salary>20000)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Enter A valid Salary [a number between 6000 and 20000]");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                EmpArr[i].setSalary(salary);
                Console.WriteLine("Enter Hire Date");
                Console.Write("year : ");
                int year;
                while(!int.TryParse(Console.ReadLine(),out year)||year<thisYear-Age+17||year>thisYear)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Invalide Year [Enter a number from {thisYear-Age+17} to {thisYear}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.Write("month : ");
                int month;
                while (!int.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalide month [Enter a number from 1 to 12]");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.Write("day : ");
                int day;
                while (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 31)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalide day [Enter a number from 1 to 31]");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Date hireDate = new Date(year,month,day);
                EmpArr[i].SetHireDate(hireDate);
                Console.Write("Male/Female[m/f] : ");
                char gender;
                while(!char.TryParse(Console.ReadLine(),out gender)||(gender!='m'&&gender!='M'&&gender!='f'&&gender!='F'))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Enter A valid Gender [m/f]");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Gender gender1=new Gender();
                switch (gender)
                {
                    case 'm':
                    case 'M':
                        gender1 = Gender.Male;
                        break;
                    case 'f':
                    case 'F':
                        gender1 = Gender.Female;
                        break;
                    default:
                        Console.WriteLine("invalide gender");
                        break;
                }
                EmpArr[i].SetGender(gender1);
            }

            Console.WriteLine("____________________________");

            Array.Sort(EmpArr);
            
            foreach(var emp in EmpArr)
            {
                Console.WriteLine(emp.ToString());
                Console.WriteLine();
            }
        }
    }
}
