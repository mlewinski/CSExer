using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dt3
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "dupa1";
            int wrongPasswordCount = 0;
            string userProvidedPassword = "";
            bool authorized = false;
            while (wrongPasswordCount != 3 && !authorized)
            {
                Console.WriteLine("Enter password : ");
                userProvidedPassword = Console.ReadLine();
                if (userProvidedPassword == password) authorized = true;
                else wrongPasswordCount++;
            }
            if(authorized) Console.WriteLine("Login succesful!");
            else Console.WriteLine("Access denied");
            Console.ReadLine();
        }
    }
}
