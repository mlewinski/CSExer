using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con12
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int rollNumber;
            double phys, chem, ca;
            rollNumber = Convert.ToInt32(Console.ReadLine());
            name = Console.ReadLine();
            string[] marks = Console.ReadLine().Split();
            phys = Convert.ToDouble(marks[0]);
            chem = Convert.ToDouble(marks[1]);
            ca = Convert.ToDouble(marks[2]);
            Console.WriteLine("{0} \n {1} \n Average \t\t: \t{2} \n Total \t\t\t: \t{3} \n Percentage \t\t: \t{4} %", name, rollNumber, (phys+chem+ca)/3, (phys+chem+ca), ((phys+chem+ca)/300)*100);
            Console.ReadLine();
        }
    }
}
