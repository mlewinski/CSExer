using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con11
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());

            double delta = b*b - 4*a*c;
            if(delta<0) Console.WriteLine("Roots are irrational, no roots in real domain");
            else if (delta == 0.0) Console.WriteLine("x0 = {0}", (-b/2*a));
            else
            {
                double sqrtDelta = Math.Sqrt(delta);
                Console.WriteLine("x1 = {0} x2 = {1}", ((-b-sqrtDelta)/(2*a)), ((-b+sqrtDelta)/(2*a)));
            }
            Console.ReadLine();
        }
    }
}
