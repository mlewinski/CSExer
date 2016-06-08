using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dt5
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI*radius*radius;
            double perimeter = Math.PI*2*radius;

            Console.WriteLine("Area : {0}, Perimeter : {1}", area, perimeter);
            Console.ReadLine();
        }
    }
}
