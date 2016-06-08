using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            if(a==b) Console.WriteLine("Equal");
            else Console.WriteLine("Not equal");
            Console.ReadLine();
        }
    }
}
