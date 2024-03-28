using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassT
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Product product = new Product(2, "Apple", "8", 100, 50, 0, 20);

           
            Console.WriteLine("Umumi Melumat:");
            product.GetInfo();

           
            product.Sale(9);

            
            Console.WriteLine("Satisdan sonra umumi melumat:");
            product.GetInfo();

            Console.ReadLine();
        }
    }
}
