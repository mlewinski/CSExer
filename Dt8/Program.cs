using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dt8
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Area : {0} PI Volume : {1} PI", (4*radius*radius), ((double)(4f/3f)*radius*radius*radius));
            Console.ReadLine();
        }
    }
}
