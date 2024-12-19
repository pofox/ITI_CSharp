using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Employee : IComparable
    {
        private int? ID;
        private string Name;
        private int? Age;
        private int? Target;
        private SecurityLevel? SecurityLevel;
        private int? salary;
        private Date? hireDate;
        private Gender? gender;

        public Employee()
        {
            ID = null;
            Name = null;
            Age = null;
            Target = null;
            SecurityLevel = null;
            salary = null;
            hireDate = null;
            gender = null;
        }
        public Employee(int _ID,string _Name,int _Age,int _Target,SecurityLevel _securityLevel, int _salary, Date _hiredate, Gender _gender)
        {
            ID = _ID;
            Name = _Name;
            Age = _Age;
            Target = _Target;
            SecurityLevel = _securityLevel;
            salary = _salary;
            hireDate = _hiredate;
            gender = _gender;
        }
        public int GetID() { return ID ?? 0; }
        public void SetID(int _ID) { ID = _ID; }
        public string GetName() { return Name; }
        public void SetName(string _Name) { Name = _Name; }
        public int GetAge() { return Age ?? 0; }
        public void SetAge(int _Age) {  Age = _Age; }
        public int GetTarget() { return Target ?? 0; }
        public void SetTarget(int _Target) { Target = _Target; }
        public SecurityLevel GetSecurityLevel() { return SecurityLevel ?? 0; }
        public void SetSecurityLevel(SecurityLevel _securityLevel) { SecurityLevel = _securityLevel; }
        public int GetSalary() { return salary ?? 0; }
        public void setSalary(int _Salary) { salary = _Salary; }
        public Date GetHireDate()
        {
            Date nulldate = new Date();
            return hireDate ?? nulldate;
        }
        public void SetHireDate(Date _HireDate) { hireDate = _HireDate; }
        public Gender GetGender() { return gender ?? 0; }
        public void SetGender(Gender _Gender) { gender = _Gender; }
        public override string? ToString()
        {
            return $"ID = {ID},\nName : {Name},\nAge = {Age},\nTargrt = {Target},\nSecurity Level is {SecurityLevel.ToString()},\nsalary = {salary},\nhire date is {hireDate.ToString()},\nGender is {gender.ToString()}";
        }

        public int CompareTo(object? obj)
        {
            Employee other = obj as Employee;
            return hireDate.Value.year==other.hireDate.Value.year&&hireDate.Value.month==other.hireDate.Value.month&&hireDate.Value.day==other.hireDate.Value.day?0:hireDate.Value.year>other.hireDate.Value.year?1:hireDate.Value.year==other.hireDate.Value.year&&hireDate.Value.month>other.hireDate.Value.month?1:hireDate.Value.year==other.hireDate.Value.year&&hireDate.Value.month==other.hireDate.Value.month&&hireDate.Value.day>other.hireDate.Value.day?1:-1;
        }
    }
}
