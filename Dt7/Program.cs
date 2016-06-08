using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dt7
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance, hours, seconds;
            Console.WriteLine("Enter distance: ");
            distance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter hours: ");
            hours = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter seconds: ");
            seconds = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Meters per second : {0}", distance/seconds);
            Console.WriteLine("Kilometers per hour : {0}", (distance/1000)*hours);
            Console.WriteLine("Miles per hour : {0}", (distance/1000)*hours*(1.609f));
            Console.ReadLine();
        }
    }
}
