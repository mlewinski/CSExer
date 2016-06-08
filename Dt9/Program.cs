using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dt9
{
    class Program
    {
        static void Main(string[] args)
        {
            char x = Convert.ToChar(Console.ReadLine());
            char[] vowels = {'a', 'e', 'i', 'o', 'u', 'y'};
            if (vowels.Contains(x))
            {
                Console.WriteLine("It's a lowercase vowel");
            }
            else Console.WriteLine("It's not a lowercase vowel");
            Console.ReadLine();
        }
    }
}
