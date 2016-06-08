using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con5
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Can vote? {0}", (age>=21));
            Console.ReadLine();
        }
    }
}
