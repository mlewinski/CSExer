using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con7
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = Convert.ToDouble(Console.ReadLine());
            string whoIs = "";
            if (height > 190) whoIs = "giant";
            else if (height > 165) whoIs = "normal";
            else if (height > 140) whoIs = "midget";
            else whoIs = "dwarf";

            Console.WriteLine("This person is a {0} !", whoIs);
            Console.ReadLine();
        }
    }
}
