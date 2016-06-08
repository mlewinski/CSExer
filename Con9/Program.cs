using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con9
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            string quadrant = "";
            if (x >= 0)
            {
                if (y >= 0) quadrant = "I";
                else quadrant = "IV";
            }
            else
            {
                if (y >= 0) quadrant = "II";
                else quadrant = "III";
            }
            Console.WriteLine("Point ({0},{1}) lies in quadrant {2}",x,y,quadrant);
            Console.ReadLine();
        }
    }
}
