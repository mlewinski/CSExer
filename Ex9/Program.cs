using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            List<double> list = new List<double>();
            for (int i = 0; i < number; i++)
            {
                list.Add(Convert.ToDouble(Console.ReadLine()));
            }
            Console.WriteLine(list.Average());
            Console.ReadLine();
        }
    }
}
