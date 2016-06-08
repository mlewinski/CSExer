using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write(x);
            Console.Write(x);
            Console.Write(x);
            Console.Write(x);

            Console.WriteLine();
            Console.WriteLine("{0}{0}{0}{0}", x);
            Console.ReadLine();
        }
    }
}
