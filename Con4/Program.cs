using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con4
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = Convert.ToInt32(Console.ReadLine());
            bool is_leap = false;
            if (year%400 == 0) is_leap = true;
            else if (year%100 == 0) is_leap = false;
            else if (year%4 == 0) is_leap = true;
            else is_leap = false;
            Console.WriteLine("Year {0} is leap? {1}", year, is_leap);
            Console.ReadLine();
        }
    }
}
