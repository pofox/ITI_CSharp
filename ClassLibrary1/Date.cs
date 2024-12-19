using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public struct Date
    {
        public int year { get; }
        public int month { get; }
        public int day { get; }
        public Date()
        {
            year = 0;
            month = 0;
            day = 0;
        }
        public Date(int _year, int _month, int _day)
        {
            year = _year;
            month = _month;
            day = _day;
        }
        public override string? ToString()
        {
            return $"{day}/{month}/{year}";
        }
    }
}
