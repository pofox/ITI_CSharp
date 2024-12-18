using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_C_
{
    public struct Employee
    {
        private int? ID;
        private int? salary;
        private Date? hireDate;
        private Gender? gender;

        public Employee()
        {
            ID = null;
            salary = null;
            hireDate = null;
            gender = null;
        }
        public Employee(int _ID,int _salary,Date _hiredate,Gender _gender)
        {
            ID= _ID;
            salary = _salary;
            hireDate = _hiredate;
            gender = _gender;
        }
        public int GetID() {  return ID??0; }
        public void SetID(int _ID) { ID = _ID; }
        public int GetSalary() { return salary??0; }
        public void setSalary(int _Salary) { salary = _Salary; }
        Date GetHireDate() { 
            Date nulldate = new Date();
            return hireDate?? nulldate;
        }
        public void SetHireDate(Date _HireDate) { hireDate = _HireDate; }
        Gender GetGender() { return gender??0; }
        public void SetGender(Gender _Gender) { gender = _Gender; }
        public override string? ToString()
        {
            return $"ID = {ID},\nsalary = {salary},\nhire date is {hireDate.ToString()},\nGender is {gender.ToString()}";
        }
    }
}
