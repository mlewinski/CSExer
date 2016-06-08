using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dt1
{
    class Program
    {
        static void Main(string[] args)
        {
            char a, b, c;
            a = Convert.ToChar(Console.ReadLine());
            b = Convert.ToChar(Console.ReadLine());
            c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("{0} {1} {2}", c, b, a);
            Console.ReadLine();
        }
    }
}
