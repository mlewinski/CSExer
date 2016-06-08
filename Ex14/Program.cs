using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            double tempC = Convert.ToDouble(Console.ReadLine());
            double tempF = 32 + (9*tempC)/5;
            double tempK = tempC + 273.15;
            Console.WriteLine("{0} C = {1} F = {2} K", tempC, tempF, tempK);
            Console.ReadLine();
        }
    }
}
