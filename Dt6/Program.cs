using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dt6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|\tx\t|\tf(x)\t|");
            for (int i = -5; i <= 5; i++)
            {
                Console.WriteLine("|\t{0}\t|\t{1}\t|",i,f(i));
            }
            Console.ReadLine();
        }

        static double f(double x)
        {
            return (x*x) + (2*x) + 1;
        }
    }
}
