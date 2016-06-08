using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con16
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = Convert.ToChar(Console.ReadLine());
            string type = "";
            if (a < 65 || a > 122 || (a > 90 && a < 97)) type = "illegal symbol";
            else
            {
                a = Char.ToLower(a);
                char[] vowels = {'a', 'e', 'u', 'i', 'o', 'p'};
                if (vowels.Contains(a)) type = "vowel";
                else type = "consonant";
            }
            Console.WriteLine("The alphabet is {0}", type);
            Console.ReadLine();
        }
    }
}
