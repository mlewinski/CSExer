using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Customer IDNO:");
            int idno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Customer name:");
            string name = Console.ReadLine();
            Console.WriteLine("Units consumed:");
            double units = Convert.ToDouble(Console.ReadLine());
            decimal bill = 0;

            float charge = 0.0f;
            if (units < 200) charge = 1.2f;
            else if (units < 400) charge = 1.5f;
            else if (units < 600) charge = 1.8f;
            else charge = 2.0f;

            bill = (decimal) (units*charge);
            Console.WriteLine("Basic bill : {0} / {1} charge per unit", bill, charge);
            decimal surcharge = bill * (decimal)0.15;
            if(bill>400) Console.WriteLine("Surcharge : {0}", surcharge);
            if(bill>100) Console.WriteLine("Final bill : {0}", bill+surcharge);
            else Console.WriteLine("Final bill : {0}", 100.ToString("C"));
            Console.ReadLine();
        }
    }
}
