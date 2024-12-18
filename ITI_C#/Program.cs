using System.Diagnostics;

namespace ITI_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] EmpArr = new Employee[3];
            for (int i=0;i<EmpArr.Length;i++)
            {
                EmpArr[i].SetID(i);
                Console.WriteLine("Enter salary");
                int salary = int.Parse(Console.ReadLine());
                EmpArr[i].setSalary(salary);
                Console.WriteLine("Enter Hire Date");
                Console.Write("day : ");
                int day = int.Parse(Console.ReadLine());
                Console.Write("month : ");
                int month = int.Parse(Console.ReadLine());
                Console.Write("year : ");
                int year = int.Parse(Console.ReadLine());
                Date hireDate = new Date(year,month,day);
                EmpArr[i].SetHireDate(hireDate);
                Console.Write("Male/Female[m/f] : ");
                char gender = char.Parse(Console.ReadLine());
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
            
            foreach(var emp in EmpArr)
            {
                Console.WriteLine(emp.ToString());
            }
        }
    }
}
