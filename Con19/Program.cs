using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con19
{
    class Program
    {
        static void Main(string[] args)
        {
            char markSymbol = Convert.ToChar(Console.ReadLine());
            string mark = "";
            switch (markSymbol)
            {
                case 'V':
                    mark = "Very good";
                    break;
                case 'E':
                    mark = "Excellent";
                    break;
                case 'G':
                    mark = "Good";
                    break;
                case 'A':
                    mark = "Average";
                    break;
                case 'F':
                    mark = "Fail";
                    break;
                default:
                    mark = "Unknown";
                    break;
            }
            Console.WriteLine("Your mark is {0} which means {1}", markSymbol, mark);
            Console.ReadLine();
        }
    }
}
