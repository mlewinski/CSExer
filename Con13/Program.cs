using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con13
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp = Convert.ToDouble(Console.ReadLine());
            string weather = "";
            if (temp < 0) weather = "Freezing";
            else if (temp < 10) weather = "Very Cold";
            else if (temp < 20) weather = "Cold";
            else if (temp < 30) weather = "Normal";
            else if (temp < 40) weather = "Hot";
            else weather = "Very Hot";

            Console.WriteLine("The weather is {0}", weather);
            Console.ReadLine();
        }
    }
}
