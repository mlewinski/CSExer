using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con14
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            string typeOfTriangle = "";
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            if (Compare(a,b))
            {
                if (Compare(b,c)) typeOfTriangle = "equilateral";
                else typeOfTriangle = "isosceles";
            }
            else if (Compare(b, c)) typeOfTriangle = "isosceles";
            else typeOfTriangle = "scalene";
            Console.WriteLine("Triangle is {0}", typeOfTriangle);
            Console.ReadLine();
        }

        static bool Compare(double a, double b)
        {
            if (Math.Abs(a - b) < 0.0000001) return true;
            return false;
        }
    }
}
