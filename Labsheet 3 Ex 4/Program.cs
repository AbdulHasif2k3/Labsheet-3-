using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet_3_Ex_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(2, 10));
            Console.ReadLine();
        }


        static int Sum (int number1, int number2)
        {
            int total = 0, temp;

            //ensure lowest number is number 1 
            if (number2 < number1)
            {
                temp = number2;
                number2  = number1;
                number1 = temp;

            }

            for(int i =number1; i <= number2; i++)
            {
                if (i % 2 == 0)
                    total += i;
            }
            return total;
        }
    }
}
