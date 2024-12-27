using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_C_
{
    public class Club
    {
        public int ClubID { get; set; }
        public string ClubName { get; set; }
        List<Employee> Members;
        public Club(int _ID,string _name)
        {
            ClubID = _ID;
            ClubName = _name;
            Members = new List<Employee>();
        }
        public void AddMember(Employee E)
        {
            Members.Add(E);
            Employee.EmployeeLayOff += RemoveMember;
            ///Try Register for EmployeeLayOff Event Here
        }
        ///CallBackMethod
        public void RemoveMember(object sender, EmployeeLayOffEventArgs e)
        {
            if (e.Cause == LayOffCause.theUltimateVacation && e.Cause != LayOffCause.resign)
            {
                Members.Remove((Employee)sender);
            }
            ///Employee Will not be removed from the Club if Age>60
            ///Employee will be removed from Club if Vacation Stock < 0
        }
        public override string ToString()
        {
            string str = $"Club ID : {ClubID}\nname :{ClubName}";
            foreach (Employee e in Members)
            {
                str += "\n=============\n" + e.ToString();
            }
            return str;
        }
    }
}
