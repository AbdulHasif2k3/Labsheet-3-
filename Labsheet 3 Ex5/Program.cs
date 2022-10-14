using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet_3_Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stock = 10, sales = 5;

            Console.WriteLine($"Stock on hand = {stock}");

            if (UpdateStock(ref stock, sales))
            {
                Console.WriteLine($"Sale successful, sold {sales}, remaining stock {stock}");
            }
            else
                Console.WriteLine($"Insufficient stock");
            Console.ReadLine();

        }

        static bool UpdateStock(ref int stock,int sales)
        {
            bool stockUpdated = false;

            if (stock >= sales)
            {
                stock -= sales;
                stockUpdated = true;
            }

            return stockUpdated;
        }
    }
}
