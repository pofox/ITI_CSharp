using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_C_
{
    public class BoardMember : Employee
    {
        public BoardMember(int _ID,DateTime _date):base(_ID, _date,0)
        {
            
        }
        protected override void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            if (e.Cause == LayOffCause.resign)
            {
                base.OnEmployeeLayOff(e);
            }
        }
        public void Resign()
        {
            OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.resign });
        }
        public override string ToString()
        {
            return $"Board Member ID : {EmployeeID}\nBirth Date : {BirthDate.ToString()}";
        }
    }
}
