using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_C_
{
    public class Employee
    {
        public static event EventHandler<EmployeeLayOffEventArgs>? EmployeeLayOff;
        protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            EmployeeLayOff?.Invoke(this, e);
        }
        public int EmployeeID { get; set; }
        DateTime birthDate;
        int vacationStock;
        public DateTime BirthDate
        {
            get { return birthDate; }
            set {
                birthDate = value;
                if((DateTime.Now-birthDate).TotalDays/365>=60)
                {
                    OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.tooOld });
                }
            }
        }
        public int VacationStock
        {
            get { return vacationStock; }
            set {
                vacationStock = value;
                if (vacationStock <0)
                {
                    OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.theUltimateVacation });
                }
            }
        }
        public Employee(int _ID,DateTime _date,int _vacation)
        {
            EmployeeID = _ID;
            birthDate = _date;
            vacationStock = _vacation;
        }
        public bool RequestVacation(DateTime From, DateTime To)
        {
            return (From - To).Days <= VacationStock;
        }
        public void EndOfYearOperation()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"Employee ID : {EmployeeID}\nBirth Date : {BirthDate}\nVacation Stock : {VacationStock}";
        }
    }
    public enum LayOffCause
    {
        theUltimateVacation,
        tooOld,
        noTargetNoMarket,
        resign
    }
    public class EmployeeLayOffEventArgs : EventArgs
    {
        public LayOffCause Cause { get; set; }
    }
}
