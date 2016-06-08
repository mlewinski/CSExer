using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con6
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int n = (m != 0) ? m/Math.Abs(m) : 0;
            Console.WriteLine(n);
            Console.ReadLine();
        }
    }
}
