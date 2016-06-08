using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con8
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            if (a > b)
            {
                if (a > c) Console.WriteLine(a);
                else Console.WriteLine(c);
            }
            else
            {
                if (b > c) Console.WriteLine(b);
                else Console.WriteLine(c);
            }
            Console.ReadLine();
        }
    }
}
