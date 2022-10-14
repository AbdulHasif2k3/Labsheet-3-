using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet_3_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetProductCost("Jeans"));
            Console.WriteLine(GetProductCost("Jacket"));
            Console.WriteLine(GetProductCost("Boots"));
            Console.WriteLine(GetProductCost("Scarves"));
            Console.WriteLine(GetProductCost("Socks"));
            Console.WriteLine(GetProductCost("T-Shirts"));
            Console.Read();

        }

        static decimal GetProductCost (string desc)
        {
            decimal  cost;

            switch (desc)
            {
                case "Jeans":
                    cost = 67.99m;
                    break;
                case "Jacket":
                    cost = 68.99m;
                    break;
                case "Boots":
                    cost = 34.99m;
                    break;
                case "Scarves":
                case "Belts":
                case "Socks":
                    cost = 10m;
                    break;

                default:
                    cost = -999m;
                    break;             

            }
            return cost;
        }



    }
}
