using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con15
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Triangle is{0} valid",(Math.Abs((a+b+c) - 180) > Double.Epsilon)?" not":"");
            Console.ReadLine();
        }
    }
}
