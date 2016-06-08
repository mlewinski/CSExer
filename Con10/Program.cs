using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Con10
{
    class Program
    {
        static void Main(string[] args)
        {
            int math, phys, chem;
            math = Convert.ToInt32(Console.ReadLine());
            phys = Convert.ToInt32(Console.ReadLine());
            chem = Convert.ToInt32(Console.ReadLine());
            string isNot = "";
            if (math >= 65)
            {
                if (phys >= 55)
                {
                    if (chem >= 50)
                    {
                        if (!((math + phys + chem) >= 180 || (math + phys) >= 140)) isNot = "not";
                    }
                    else isNot = "not";
                }
                else isNot = "not";
            }
            else isNot = "not";

            Console.WriteLine("Candidate is {0} eligible for admission", isNot);
            Console.ReadLine();
        }
    }
}
