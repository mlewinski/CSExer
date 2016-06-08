using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" {0} + {1} = {2}",a,b,a+b);
            Console.WriteLine(" {0} - {1} = {2}", a, b, a-b);
            Console.WriteLine(" {0} * {1} = {2}", a, b, a * b);
            Console.WriteLine(" {0} / {1} = {2}", a, b, a / b);
            Console.WriteLine(" {0} mod {1} = {2}", a, b, a % b);
            Console.ReadLine();
        }
    }
}
