using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dt11
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = Convert.ToInt64(Console.ReadLine());
            while (a != 0)
            {
                Console.Write(a%2);
                a /= 2;
            }
            Console.ReadLine();
        }
    }
}
