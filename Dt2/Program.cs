using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dt2
{
    class Program
    {
        static void Main(string[] args)
        {
            char sign = Convert.ToChar(Console.ReadLine());
            int width = Convert.ToInt32(Console.ReadLine());
            for (int i = width; i > 0; i--)
            {
                for (int j = 0; j < i; j++) Console.Write(sign);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
