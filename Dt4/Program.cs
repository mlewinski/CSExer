using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dt4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            char op = Convert.ToChar(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            switch (op)
            {
                case '-':
                    Console.WriteLine(a-b);
                    break;
                case '+':
                    Console.WriteLine(a + b);
                    break;
                case '*':
                    Console.WriteLine(a*b);
                    break;
                case '/':
                    if (b != 0) Console.WriteLine(a/b);
                    else Console.WriteLine("Error - division by 0");
                    break;
            }
            Console.ReadLine();
        }
    }
}
