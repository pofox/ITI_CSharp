using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_C_
{
    public class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        List<Employee> Staff;
        public Department(int _ID,string _name)
        {
            DeptID = _ID;
            DeptName = _name;
            Staff = new List<Employee>();
        }
        public void AddStaff(Employee E)
        {
            Staff.Add(E);
            Employee.EmployeeLayOff += RemoveStaff;
            ///Try Register for EmployeeLayOff Event Here
        }
        ///CallBackMethod
        public void RemoveStaff(object sender, EmployeeLayOffEventArgs e)
        {
            Staff.Remove((Employee)sender);
        }
        public override string ToString()
        {
            string str = $"Department ID : {DeptID}\nname : {DeptName}";
            foreach (Employee e in Staff) {
                str += "\n=============\n" + e.ToString();
            }
            return str;
        }
    }
}
