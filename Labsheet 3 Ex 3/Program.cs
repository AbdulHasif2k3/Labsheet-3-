using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet_3_Ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3, 4, 7, 9, 11 };

            DisplayArray(numbers);

            Zero(numbers);

            DisplayArray(numbers);
            Console.ReadLine();

        }

        static void DisplayArray(int[] numbers)
        {
            for(int i = 0; i <numbers.Length; i++)
            {
                Console.WriteLine($"element {i} >> {numbers[i]}");
            }
        }

        static void Zero(int [] numbers)
        {
            for (int i=0; i < numbers.Length; i++)
            {
                numbers[i] = 0;
            }
        }
    }
}
