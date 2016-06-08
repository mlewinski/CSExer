using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con17
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal buyPrice, sellPrice;
            Console.WriteLine("Buying price : ");
            buyPrice = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Selling Price : ");
            sellPrice = Convert.ToDecimal(Console.ReadLine());
            if (buyPrice > sellPrice) Console.WriteLine("Loss : {0}", (buyPrice-sellPrice).ToString("C"));
            else if (buyPrice<sellPrice) Console.WriteLine("Profit : {0}", (sellPrice-buyPrice).ToString("C"));
            else Console.WriteLine("No change recorded");
            Console.ReadLine();
        }
    }
}
