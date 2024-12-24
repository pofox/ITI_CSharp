using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_C_
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public Duration(int _hours, int _minutes, int _seconds)
        {
            Hours = _hours;
            Minutes = _minutes;
            Seconds = _seconds;
        }
        public Duration(int _seconds) : this(_seconds / 3600, _seconds / 60 % 60, _seconds % 60) { }
        public static explicit operator int(Duration d) { return d.Hours*3600+d.Minutes*60+d.Seconds; }
        public static explicit operator DateTime(Duration t) { return new DateTime((int)t * (long)MathF.Pow(10, 7)); }
        public static implicit operator bool(Duration d) { return (int)d>0; }
        public static Duration operator +(Duration t1, Duration t2)
        {
            return new Duration((int)t1 + (int)t2);
        }
        public static Duration operator -(Duration t1)
        {
            return new Duration(-t1.Hours, -t1.Minutes, -t1.Seconds);
        }
        public static Duration operator +(Duration t1, int _seconds)
        {
            return new Duration((int)t1 + _seconds);
        }
        public static Duration operator +(int _seconds, Duration t1)
        {
            return new Duration((int)t1 + _seconds);
        }
        public static Duration operator ++(Duration t)
        {
            return new Duration((int)t + 60);
        }
        public static Duration operator --(Duration t)
        {
            return new Duration((int)t-60);
        }
        public static bool operator <(Duration t1, Duration t2) { return (int)t1 < (int)t2; }
        public static bool operator >(Duration t1, Duration t2) { return (int)t1 > (int)t2; }
        public static bool operator <=(Duration t1, Duration t2) { return (int)t1 <= (int)t2; }
        public static bool operator >=(Duration t1, Duration t2) { return (int)t1 >= (int)t2; }
        public override string ToString()
        {
            string val = Hours != 0 ? $"Hours : {Hours}, Minutes : {Minutes}, Seconds : {Seconds}" : Minutes != 0 ? $"Minutes : {Minutes}, Seconds : {Seconds}" : $"Seconds : {Seconds}";
            return val;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Duration))
                throw new ArgumentException();
            Duration t = (Duration)obj;
            if (GetType() != t.GetType())
                throw new ArgumentException();
            return Hours == t.Hours && Minutes == t.Minutes && Seconds == t.Seconds;
        }
        public override int GetHashCode()
        {
            return Seconds+60*Minutes+3600*Hours;
        }
    }
}
