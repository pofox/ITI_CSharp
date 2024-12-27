using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_C_
{
    public class SalesPerson : Employee
    {
        public SalesPerson(int _ID,DateTime _date,int _Target):base(_ID, _date, 0)
        {
            AchievedTarget = _Target;
        }
        public int AchievedTarget { get; set; }
        protected override void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            if (e.Cause != LayOffCause.theUltimateVacation)
            {
                base.OnEmployeeLayOff(e);
            }
        }
        public bool CheckTarget(int Quota)
        {
            if (AchievedTarget < Quota) OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.noTargetNoMarket });
            return AchievedTarget >= Quota;
        }
        public override string ToString()
        {
            return $"Sales Person ID : {EmployeeID}\nBirth Date : {BirthDate.ToString()}\nTarget : {AchievedTarget}";
        }
    }
}
