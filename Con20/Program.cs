using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con20
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = {"Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"};
            int dayNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("It's {0}", days[Math.Abs(dayNumber-1)%7]);
            Console.ReadLine();
        }
    }
}
